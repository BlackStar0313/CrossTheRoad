﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCollider : MonoBehaviour {

	public GameObject m_parent;
	private bool m_isCollide = false ; 
	private Vector3 m_direction ; 
	protected float m_speed = 10.0f; 
	protected float m_drag = 1.0f;
	protected float m_deadHeight = 0.3f;

	private float c_rangHitXDistHigh = 1.3f;	//碰撞时候飞出去的距离  随机一点，看起来自然一点  
	private float c_rangHitXDistLow = 0.7f;
	private float c_rangHitZDistHigh = 2f;
	private float c_rangHitZDistLow = 0.4f;
	private float c_rangDeadHeight = 1.1f;

	void OnCollisionEnter(Collision collisionInfo)
	{
		if (collisionInfo.gameObject.tag == "Cars" && !this.m_isCollide) {
			CarControl car = collisionInfo.gameObject.GetComponent<CarControl>();
			if (car) {
				car.playHitSounds();
			}
			this.handleCarCollision(collisionInfo.gameObject.transform.position, true);
		}
	}

 	void Update()
	{
		if (!this.m_isCollide) {
			return ; 
		}

		if (m_speed <= 0) {
			return ;
		}

		Vector3 move = m_direction * this.m_speed ;
		m_speed -= m_drag;

		this.m_parent.GetComponent<CharacterController>().Move(move * Time.deltaTime );

		if (m_speed <= 0) {
			this.m_parent.GetComponent<CharacterController>().enabled = false ; 
		}
	}

	public void handleCarCollision(Vector3 carPos ,bool isDispatcher) {
		m_direction = this.m_parent.GetComponent<CharacterController>().transform.position - carPos;
		m_direction = new Vector3(Random.Range(c_rangHitXDistLow, c_rangHitXDistHigh) * m_direction.x, m_direction.y , Random.Range(c_rangHitZDistLow, c_rangHitZDistHigh) * m_direction.z ) ;
		m_direction.y = m_deadHeight * Random.Range(0.8f,c_rangDeadHeight);
		this.m_isCollide = true ; 

		//调整下平躺下死亡时候的动画碰撞范围
		this.GetComponent<CapsuleCollider>().direction = 2;
		this.GetComponent<CapsuleCollider>().center = new Vector3(-this.GetComponent<CapsuleCollider>().center.y, this.GetComponent<CapsuleCollider>().center.y, - this.GetComponent<CapsuleCollider>().center.y );

		this.m_parent.GetComponent<BasicController>().HandleDead();

		if (isDispatcher) {
			DispatchManager.getInstance().onCollidePlayer.Invoke(carPos , this);
			GameManager.getInstance().handlePlayerDead(false);
		}
	}
}
