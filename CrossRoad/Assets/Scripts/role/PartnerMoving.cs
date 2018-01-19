using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PartnerMoving : MonoBehaviour {


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
	private float m_autoMoveStep = 0.05f;
	/*
	 * direct 1 ,270度， -1 90度
	 */
	public void handleInit(float direct, bool isPlaceHolder) {


		m_controller.currentDirect = direct > 0 ? EnumMovingDirect.normal : EnumMovingDirect.offoset ;
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
			m_controller.OnStartMove();
			this.m_isStart = true ;
		}
		else {
			m_controller.OnStopMove();
			this.transform.position = direct > 0 ? new Vector3(m_startPos.position.x , transform.position.y, m_startPos.position.z) : new Vector3(m_endPos.position.x , transform.position.y, m_endPos.position.z);
		}

	}

	// Use this for initialization
	void Awake(){
		m_rigidBody = GetComponent<Rigidbody>();
		m_animator = GetComponent<Animator>();
		m_character = GetComponent<CharacterController>();
		m_controller = GetComponent<PartnerController>();
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
				m_controller.OnStopMove();
			}
		}
	}

	private void autoMove() {
		float speed = m_autoMoveStep / Time.deltaTime;
		speed *= GameManager.getInstance().playerDirect > 0 ? -1 : 1 ;
		Vector3 forward = new Vector3( speed, 0 , 0  );
		m_character.SimpleMove(forward);
	}


	public bool isPartnerDirect(float direct) {
		return direct > 0 && m_controller.currentDirect == EnumMovingDirect.normal || 
				direct < 0 && m_controller.currentDirect == EnumMovingDirect.offoset ;
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
		m_controller.OnStartMove();
	}
}
