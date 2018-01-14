using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour {

	public Transform m_startPos;
	public Transform m_endPos;

	private Rigidbody m_rigidbody ;
	private CharacterController m_character ; 
	private Animator m_animator;

	private bool m_isMoving = false ; 
	private float m_moveStep = 1f;
	private float m_moveSpeed = 2000f;
	private float m_direction = 1.0f ; 
	private float m_deltaDist = 1.0f;	//判断玩家是否到位置的一个范围.
	private bool m_isNewRound = false ; 

	void Awake()
	{
		this.m_character = GetComponent<CharacterController>();
		this.m_animator = GetComponent<Animator>();
		this.m_rigidbody = GetComponent<Rigidbody>();

		// this.m_rigidbody.position = new Vector3(this.m_startPos.position.x , this.m_rigidbody.position.y , this.m_rigidbody.position.z ) ;
		this.transform.position = new Vector3(this.m_startPos.position.x , this.m_rigidbody.position.y , this.m_rigidbody.position.z ) ;
	}
	
	// Update is called once per frame
	void Update () {
		// foreach (Touch touch in Input.touches) {
		// 	Debug.Log("~~~dfdasfa ");

		// }

		this.handleTouch();
	}

	private void handleTouch() {
		if (Input.GetMouseButtonDown(0)) {
			// Debug.Log("~~~ Pressed left click.  " + Input.mousePosition );
			// Debug.Log(" screen width is " + Screen.width + " screen height is " + Screen.height);

			if (Input.mousePosition.x < Screen.width/2) {
				// Debug.Log("&&&&  left ");
				this.move(true);
			}
			else {
				// Debug.Log("******  right ");
				this.move(false);
			}
			
		}
	}

	private void move(bool isLeft) {
		if (m_isMoving) {
			return ;
		}

		Vector3 endPos = this.m_direction > 0 ? this.m_endPos.position : this.m_startPos.position ; 
		float deltaDist = this.m_deltaDist ;
		if (this.m_rigidbody.position.x*this.m_direction - deltaDist < endPos.x*this.m_direction ) {
			this.m_direction *= -1;
			float angle = this.m_direction < 0 ? 90.0f : 270f;
			// float angle = 180;
			Quaternion turnRotation = Quaternion.Euler(0f,angle , 0f);
			// this.m_rigidbody.MoveRotation(this.m_rigidbody.rotation * turnRotation);
			this.transform.rotation = turnRotation;

			DispatchManager.getInstance().onPartnerReached.Invoke();
			DispatchManager.getInstance().onPartnerCatched.Invoke();

			this.m_isNewRound = true ; 
			return ; 
		}

		if (isLeft) {
			StartCoroutine(SmoothMovement());
			
			m_isNewRound = false ;
			GameManager.getInstance().CreateNewPartner(GameManager.getInstance().playerDirect ,false );
		}
	}

	protected IEnumerator SmoothMovement() {
		m_isMoving = true ; 
		m_animator.SetTrigger("player_run");


		float speed = m_moveStep / Time.deltaTime;
		speed *= this.m_direction > 0 ? -1 : 1 ;
		Vector3 forward = new Vector3( speed, 0 , 0  );
		m_character.SimpleMove(forward);
		DispatchManager.getInstance().onPartnerMove.Invoke(speed);
		yield return null ; 
		

		m_isMoving = false ; 
		m_animator.SetTrigger("player_idle");
		DispatchManager.getInstance().onPartnerStop.Invoke();
	}
}
