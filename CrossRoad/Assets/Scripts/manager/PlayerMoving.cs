﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour {

	public Transform m_startPos;
	public Transform m_endPos;

	private PlayerController m_controller ; 
	private Rigidbody m_rigidbody ;
	private CharacterController m_character ; 

	private bool m_isMoving = false ; 
	private float m_moveStep = 1f;
	private float m_direction = 1.0f ; 
	private float m_deltaDist = 2.5f;	//判断玩家是否到位置的一个范围.
	private bool m_isNewRound = true ; 

	void Awake()
	{
		this.m_character = GetComponent<CharacterController>();
		this.m_controller = GetComponent<PlayerController>();

		this.transform.position = new Vector3(this.m_startPos.position.x , this.transform.position.y , this.transform.position.z ) ;
	}
	
	// Update is called once per frame
	void Update () {
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
		if (this.transform.position.x*this.m_direction - deltaDist < endPos.x*this.m_direction ) {
			float oldDir = m_direction;
			this.m_direction *= -1;
			GameManager.getInstance().playerDirect = m_direction;

			float speed = (endPos.x - this.transform.position.x) / Time.deltaTime;
			Vector3 forward = new Vector3( speed, 0 , 0  );
			m_character.SimpleMove(forward);

			float angle = this.m_direction < 0 ? 90.0f : 270f;
			Quaternion turnRotation = Quaternion.Euler(0f,angle , 0f);
			m_character.transform.rotation = turnRotation;

			this.m_isNewRound = true ; 

			m_controller.onOneRoungEnd(m_direction);
			return ; 
		}

		if (isLeft) {
			StartCoroutine(SmoothMovement());
			if (m_isNewRound) {
				GameManager.getInstance().CreateNewPartner(GameManager.getInstance().playerDirect ,false );
			}
			m_isNewRound = false ;
		}
	}

	protected IEnumerator SmoothMovement() {
		m_isMoving = true ; 

		float speed = m_moveStep / Time.deltaTime;
		speed *= this.m_direction > 0 ? -1 : 1 ;
		Vector3 forward = new Vector3( speed, 0 , 0  );
		m_character.SimpleMove(forward);

		m_controller.OnStartMove(speed , m_direction);
		yield return null ; 
		

		m_isMoving = false ; 
		m_controller.OnStopMove();
	}

}
