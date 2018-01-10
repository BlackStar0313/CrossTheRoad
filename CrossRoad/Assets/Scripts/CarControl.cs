using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour {
	public Transform m_carStartPos1;
	public Transform m_carEndPos1;
	public LayerMask m_blockingLayer; 

	private float m_moveSpeedRangeMax = 10f ; 
	private float m_moveSpeedRangeMin = 6f ; 
	private float m_moveSpeedAvg = 0f;
	private float m_moveSpeedCurrent = -1f ;
	private float m_acceleratedSpeedRangeMax = 6.0f ;
	private float m_acceleratedSpeedRangeMin = 3.0f ;
	private float m_acceleratedSpeedCurrent = 2.0f ;

	private Rigidbody m_rigidBody = null ; 
	private CapsuleCollider m_capsuleCollider = null ; 
	private bool m_isMoving = false ; 
	private float m_RaycasthitDist = 10f;


	// Use this for initialization
	void Awake()
	{
		this.m_rigidBody = GetComponent<Rigidbody> ();
		this.m_capsuleCollider = GetComponent<CapsuleCollider>();
		// this.transform.position = m_carStartPos1.position;
		this.m_rigidBody.position = m_carStartPos1.position ; 

		this.m_moveSpeedAvg = Random.Range(m_moveSpeedRangeMin , m_moveSpeedRangeMax);
		this.m_moveSpeedCurrent = this.m_moveSpeedAvg;
		this.m_acceleratedSpeedCurrent = Random.Range(m_acceleratedSpeedRangeMin , m_acceleratedSpeedRangeMax);

		this.handleCreate();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void FixedUpdate()
	{
		if (this.isCanMove()) {
			this.handleSpeed();
			this.handleMove();
		}
	}

	public float GetCurrentSpeed() { return this.m_moveSpeedCurrent; }
	public float GetMaxSpeed() { return this.m_moveSpeedAvg; }


	private bool isCanMove() {
		//是否到达终点
		if (this.m_rigidBody.position.z >= this.m_carEndPos1.position.z) {
			this.gameObject.SetActive(false);
			DestroyObject(this.gameObject);
			return false ; 
		}

		//前方是否有车
		CarControl targetCar;
		if (this.isNearCars<CarControl>(out targetCar) && targetCar ) {
			if (this.m_moveSpeedAvg > targetCar.GetMaxSpeed()) {
				this.m_moveSpeedAvg = targetCar.GetMaxSpeed();
			}
		}

		//是否到达红绿灯的位置了

		return true ;  
	}

	private bool isWaitForTraffic() {
		return true ;
	}

	private bool isNearCars <T>(out T targetCar) where T: Component {
		Vector3 startPos = this.m_rigidBody.position ; 

		RaycastHit hit ;
		this.m_capsuleCollider.enabled = false ;
		bool isNear = Physics.Raycast(startPos , Vector3.forward , out hit , this.m_RaycasthitDist , this.m_blockingLayer);
		this.m_capsuleCollider.enabled = true ; 

		targetCar = hit.transform ? hit.transform.GetComponent<T>() : null ; 


		return isNear;
	}

	private void handleMove() {
		if (this.m_moveSpeedCurrent <= 0f ) {
			return ; 
		}

		Vector3 endPos = new Vector3(this.m_rigidBody.position.x , this.m_rigidBody.position.y ,this.m_carEndPos1.position.z);

		float step = this.m_moveSpeedCurrent * Time.deltaTime;
		this.m_rigidBody.position = Vector3.MoveTowards(this.m_rigidBody.position , endPos , step );
		// Debug.Log(" ~~~~ m_rigidBody pos is x : " + this.m_rigidBody.position.x + " y: " + this.m_rigidBody.position.y + " z: " + this.m_rigidBody.position.z );
	}

	private void handleSpeed() {
		if (this.m_moveSpeedCurrent < this.m_moveSpeedAvg) {
			this.m_moveSpeedCurrent += this.m_acceleratedSpeedCurrent * Time.deltaTime ; 
		}
		else if (this.m_moveSpeedCurrent > this.m_moveSpeedAvg) {
			this.m_moveSpeedCurrent = this.m_moveSpeedAvg ; 
		}
	}




	private bool isCanCreateCar() {
		Vector3 startPos = this.m_rigidBody.position ; 

		RaycastHit hit ;
		this.m_capsuleCollider.enabled = false ;
		bool isNear = Physics.Raycast(startPos , Vector3.forward , out hit ,this.m_RaycasthitDist , this.m_blockingLayer);
		if (!isNear) {
			isNear = Physics.Raycast(startPos , Vector3.up , out hit ,this.m_RaycasthitDist , this.m_blockingLayer);
		}
		this.m_capsuleCollider.enabled = true ; 

		return isNear;
	}

	private void handleCreate() {
		if (this.isCanCreateCar() ) {
			this.gameObject.SetActive(false);
			DestroyObject(this.gameObject);
			Debug.Log("~~~~~~~~~~  cannot create a car ");
		}
	}
}
