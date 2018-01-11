using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour {

	public Transform m_startPos;
	public Transform m_endPos;

	private Rigidbody m_rigidbody ;
	private Animator m_animator;

	private bool m_isMoving = false ; 
	private float m_moveStep = 1f;
	private float m_moveSpeed = 0.2f;

	void Awake()
	{
		this.m_rigidbody = GetComponent<Rigidbody>();
		this.m_animator = GetComponent<Animator>();
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
				Debug.Log("&&&&  left ");
				this.move(true);
			}
			else {
				Debug.Log("******  right ");
				this.move(false);
			}
			
		}
	}

	private void move(bool isLeft) {
		if (this.m_rigidbody.position.x < this.m_endPos.position.x ) {
			//TODO: add sth logic here .
			return ; 
		}

		if (isLeft) {
			
			float endX = Mathf.Max(this.m_endPos.position.x , this.m_rigidbody.position.x - m_moveStep) ;
			Vector3 stepPos = new Vector3(endX ,this.m_rigidbody.position.y , this.m_rigidbody.position.z );
			StartCoroutine(SmoothMovement(stepPos));
			
		}
	}

	protected IEnumerator SmoothMovement(Vector3 endPos) {
		m_isMoving = true ; 
		m_animator.SetTrigger("player_run");

		float dist = (m_rigidbody.position-endPos).magnitude;
		while (dist > float.Epsilon) {
			Vector3 newPos = Vector3.MoveTowards(m_rigidbody.position, endPos , m_moveSpeed * Time.deltaTime);
			m_rigidbody.MovePosition(newPos);
			dist = (m_rigidbody.position-endPos).magnitude;
		}
		yield return null ; 

		m_isMoving = false ; 
		m_animator.SetTrigger("player_idle");
	}
}
