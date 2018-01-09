using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour {
	public Transform m_carStartPos1;
	public Transform m_carEndPos1;

	private float m_moveSpeedMax = 8f ; 
	private float m_moveSpeedMin = 3f ; 
	private float m_moveSpeedAvg = 0f;
	private Rigidbody m_rigidBody = null ; 
	private bool m_isMoving = false ; 

	// Use this for initialization
	void Awake()
	{
		this.m_rigidBody = GetComponent<Rigidbody> ();
		// this.transform.position = m_carStartPos1.position;
		this.m_rigidBody.position = m_carStartPos1.position ; 
		this.m_moveSpeedAvg = Random.Range(m_moveSpeedMin , m_moveSpeedMax);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void FixedUpdate()
	{
		if (this.m_rigidBody.position.z >= this.m_carEndPos1.position.z) {
			this.gameObject.SetActive(false);
			DestroyObject(this.gameObject);
			return ; 
		}

		Vector3 endPos = new Vector3(this.m_rigidBody.position.x , this.m_rigidBody.position.y ,this.m_carEndPos1.position.z);

		float step = this.m_moveSpeedAvg * Time.deltaTime;
		this.m_rigidBody.position = Vector3.MoveTowards(this.m_rigidBody.position , endPos , step );
		// Debug.Log(" ~~~~ m_rigidBody pos is x : " + this.m_rigidBody.position.x + " y: " + this.m_rigidBody.position.y + " z: " + this.m_rigidBody.position.z );
	
	}

}
