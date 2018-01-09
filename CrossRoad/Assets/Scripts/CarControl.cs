using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour {
	public Transform m_carStartPos1;
	public Transform m_carEndPos1;

	private float m_moveSpeed = 6f ; 
	private Rigidbody m_rigidBody = null ; 

	// Use this for initialization
	void Awake()
	{
		this.transform.position = m_carStartPos1.position ; 

		this.m_rigidBody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate()
	{
		float dist = (this.transform.position - this.m_carEndPos1.position).magnitude;

		if (this.transform.position.z > this.m_carEndPos1.position.z) {
			return ; 
		}

		Vector3 movement = this.transform.forward * m_moveSpeed * Time.deltaTime ;
		this.m_rigidBody.MovePosition(this.m_rigidBody.position + movement );
	}
}
