using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PartnerMoving : MonoBehaviour {
	enum EnumMovingDirect {
		normal,
		offoset
	}

	public Transform m_startBornPos ; 
	public Transform m_startPos; 
	public Transform m_endBornPos;
	public Transform m_endPos;

	private PartnerController m_controller ; 
	private CharacterController m_character ; 
	private Animator m_animator;
	private Rigidbody m_rigidBody ;
	private bool m_isStart = false ;
	private Transform m_autoEndPos;
	private EnumMovingDirect m_currentDirect ;
	private float m_autoMoveStep = 0.05f;
	/*
	 * direct 1 ,270度， -1 90度
	 */
	public void handleInit(float direct, bool isPlaceHolder) {
		DispatchManager.getInstance().onPartnerCatched.AddListener(OnCatched) ;

		m_currentDirect = direct > 0 ? EnumMovingDirect.normal : EnumMovingDirect.offoset ;
		if (direct > 0 ) {
			this.transform.position = new Vector3(m_startBornPos.position.x , transform.position.y, m_startBornPos.position.z) ;
			this.m_autoEndPos = m_startPos;
		}
		else {
			this.transform.position = new Vector3(m_endBornPos.position.x , transform.position.y, m_endBornPos.position.z) ;
			this.m_autoEndPos = m_endPos;
		}
		this.transform.rotation = getCurrentRotation(direct);

		if (!isPlaceHolder) {
			m_animator.SetTrigger("player_run");
			this.m_isStart = true ;
		}
		else {
			m_animator.SetTrigger("player_idle");
			this.transform.position = direct > 0 ? new Vector3(m_startPos.position.x , transform.position.y, m_startPos.position.z) : new Vector3(m_endPos.position.x , transform.position.y, m_endPos.position.z);
		}

	}

	// Use this for initialization
	void Awake(){
		this.m_rigidBody = GetComponent<Rigidbody>();
		this.m_animator = GetComponent<Animator>();
		this.m_character = GetComponent<CharacterController>();
		this.m_controller = GetComponent<PartnerController>();
	}

	private Quaternion getCurrentRotation(float direct) {
		float angle = direct < 0 ? 90.0f : 270f;
		return  Quaternion.Euler(0f,angle , 0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (m_isStart) {
			if (GameManager.getInstance().playerDirect > 0 && m_autoEndPos.position.x < transform.position.x ||
				GameManager.getInstance().playerDirect < 0 && m_autoEndPos.position.x > transform.position.x ) {
				this.autoMove();
			}
			else {
				this.m_isStart = false ; 
				m_animator.SetTrigger("player_idle");
			}
		}
	}

	private void autoMove() {
		float speed = m_autoMoveStep / Time.deltaTime;
		speed *= GameManager.getInstance().playerDirect > 0 ? -1 : 1 ;
		Vector3 forward = new Vector3( speed, 0 , 0  );
		m_character.SimpleMove(forward);
	}


	private bool isPartnerDirect(float direct) {
		return direct > 0 && m_currentDirect == EnumMovingDirect.normal || 
				direct < 0 && m_currentDirect == EnumMovingDirect.offoset ;
	}


	public void OnMove(float speed , float direct ) {
		if (!isPartnerDirect(direct)) {
			return ;
		}

		// Vector3 endPos = new Vector3(directPos.x , m_rigidBody.position.y , m_rigidBody.position.z);
		// Vector3 newPos = Vector3.MoveTowards(m_rigidBody.position , endPos , m_moveSpeed * Time.deltaTime);
		// m_rigidBody.position = newPos;
		// speed *= GameManager.getInstance().playerDirect > 0 ? -1 : 1 ;
		Vector3 forward = new Vector3( speed, 0 , 0  );
		m_character.SimpleMove(forward);
		m_animator.SetTrigger("player_run");
	}

	public void OnStop() {
		m_animator.SetTrigger("player_idle");
	}

	public void OnReachEnd(float direct) {
		if (!isPartnerDirect(direct)) {
			return ;
		}

		this.gameObject.SetActive(false);
		DestroyObject(this.gameObject);
		//TODO: add coin and play coin flying animation .

		this.removeEvent();
	}

	public void OnPlayerCollidetion(Vector3 carPos, BasicCollider collider) {
		if (typeof(PartnerCollider) != collider.GetType()) {
			GameObject colliderObj = GameObject.FindGameObjectWithTag("partnerCollider");
			colliderObj.GetComponent<PartnerCollider>().handleCarCollision(carPos, false);
		}
	}

	private void OnCatched(float direct ) {
		if (isPartnerDirect(direct) ) {

			DispatchManager.getInstance().onPartnerCatched.RemoveListener(this.OnCatched);

			DispatchManager.getInstance().onPartnerMove.AddListener(this.OnMove);
			DispatchManager.getInstance().onPartnerStop.AddListener(this.OnStop);
			DispatchManager.getInstance().onPartnerReached.AddListener(this.OnReachEnd);	
			DispatchManager.getInstance().onCollidePlayer.AddListener(this.OnPlayerCollidetion);	
		}
	}

	private void removeEvent() {
		DispatchManager.getInstance().onPartnerMove.RemoveListener(this.OnMove);
		DispatchManager.getInstance().onPartnerStop.RemoveListener(this.OnStop);
		DispatchManager.getInstance().onPartnerReached.RemoveListener(this.OnReachEnd);
		DispatchManager.getInstance().onCollidePlayer.RemoveListener(this.OnPlayerCollidetion);
	}
}
