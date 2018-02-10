using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour {
	public LayerMask m_blockingLayer; 
	public AudioSource m_audioSource; 

	private Transform m_carStartPos {get; set;}
	private Transform m_carEndPos {get; set;}
	private Transform m_carPausePos {get; set;}

	private float m_moveSpeedRangeMax = 7f ; 
	private float m_moveSpeedRangeMin = 3f ; 
	private float m_moveSpeedAvg = 0f;
	private float m_moveBeginSpeedAvg = 0f;		//存储小车本身最大速度;
	private float m_moveSpeedCurrent = -1f ;
	private float m_acceleratedSpeedRangeMax = 8.0f ;
	private float m_acceleratedSpeedRangeMin = 4.0f ;
	private float m_acceleratedSpeedCurrent = 2.0f ;

	private Rigidbody m_rigidBody = null ; 
	private CapsuleCollider m_capsuleCollider = null ; 
	private bool m_isMoving = false ; 
	private float m_puaseDist = 4f;
	private bool m_isInit = false ;

	private float c_RaycastHitDistMin = 10f ; 
	private float c_RaycastHitDistMax = 20f ;

	private float m_RaycasthitDist = 10f;

	private Vector3 m_direction ;

	// Use this for initialization
	void Awake()
	{
		m_RaycasthitDist = Random.Range(c_RaycastHitDistMin , c_RaycastHitDistMax);
	}

	public void HandleInit(Transform StartPos , Transform pausePos , Transform endPos) {

		this.m_carStartPos = StartPos;
		this.m_carPausePos = pausePos;
		this.m_carEndPos = endPos;

		this.m_rigidBody = GetComponent<Rigidbody> ();
		this.m_capsuleCollider = GetComponent<CapsuleCollider>();
		this.m_rigidBody.position = m_carStartPos.position ; 

		this.m_moveSpeedAvg = Random.Range(m_moveSpeedRangeMin , m_moveSpeedRangeMax);
		this.m_moveSpeedCurrent = this.m_moveSpeedAvg;
		this.m_moveBeginSpeedAvg = this.m_moveSpeedAvg;
		this.m_acceleratedSpeedCurrent = Random.Range(m_acceleratedSpeedRangeMin , m_acceleratedSpeedRangeMax);

		if (StartPos.position.z < 0) {
			this.m_direction = new Vector3(0,0,1);
		}
		else {
			this.m_direction = new Vector3(0,0,-1);
			Quaternion turnRotation = Quaternion.Euler(0f,180f , 0f);
			this.m_rigidBody.MoveRotation(this.m_rigidBody.rotation * turnRotation);
		}

		this.m_isInit = true ; 
		this.handleCreate();
	}

	void Start()
	{
		// Debug.Log("");
	}
	
	// Update is called once per frame
	void Update () {
	}

	void FixedUpdate()
	{
		if (this.m_isInit && this.isCanMove()) {
			this.handleSpeed();
			this.handleMove();
		}
	}

	public float GetCurrentSpeed() { return this.m_moveSpeedCurrent; }
	public float GetMaxSpeed() { return this.m_moveSpeedAvg; }


	private bool isCanMove() {
		if (!GameManager.getInstance().IsPlaying()) {
			return false; 
		}

		//是否到达终点
		if (this.m_rigidBody.position.z*this.m_direction.z >= this.m_carEndPos.position.z*this.m_direction.z) {
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

			if (this.m_moveSpeedCurrent > targetCar.GetCurrentSpeed()) {
				this.m_moveSpeedCurrent = targetCar.GetCurrentSpeed();
			}
		}

		//是否到达红绿灯的位置了
		if (this.isWaitForTraffic()) {
			this.m_moveSpeedCurrent = 0 ; 
			this.m_moveSpeedAvg = this.m_moveBeginSpeedAvg;
			return false; 
		}

		return true ;  
	}

	private bool isWaitForTraffic() {
		if (!GameManager.getInstance().isTrafficRed || 
			(GameManager.getInstance().isTrafficRed && 
				this.m_rigidBody.position.z*this.m_direction.z > this.m_carPausePos.position.z*this.m_direction.z) ) {
			return false ;
		}

		float dist = (this.m_carPausePos.position - this.m_rigidBody.position).magnitude;
		if (dist <= this.m_puaseDist) {
			return true; 
		}

		return false ;
	}

	private bool isNearCars <T>(out T targetCar) where T: Component {
		Vector3 startPos = this.m_rigidBody.position + new Vector3(0,1f,0);

		RaycastHit hit ;
		this.m_capsuleCollider.enabled = false ;
		bool isNear = Physics.Raycast(startPos , Vector3.forward * this.m_direction.z , out hit , this.m_RaycasthitDist , this.m_blockingLayer);
		this.m_capsuleCollider.enabled = true ; 

		Debug.DrawLine(startPos,startPos+ Vector3.forward * this.m_direction.z * this.m_RaycasthitDist,Color.red);  //这个就是绘制出的射线了，包含发射位置，发射距离和射线的颜色；  

		// if (isNear) {
		// 	Debug.Log("!~~~isNearCars");
		// }

		targetCar = hit.transform ? hit.transform.GetComponent<T>() : null ; 


		return isNear;
	}

	private void handleMove() {
		if (this.m_moveSpeedCurrent <= 0f ) {
			return ; 
		}

		Vector3 endPos = new Vector3(this.m_rigidBody.position.x , this.m_rigidBody.position.y ,this.m_carEndPos.position.z);

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
		Vector3 startPos = new Vector3(this.m_rigidBody.position.x,1f,this.m_rigidBody.position.z);

		//检查下方，前方，和斜前方应该就可以了
		RaycastHit hit ;
		this.m_capsuleCollider.enabled = false ;
		bool isNear = Physics.Raycast(startPos , Vector3.forward * this.m_direction.z , out hit ,this.c_RaycastHitDistMax , this.m_blockingLayer);
		Debug.DrawLine(startPos , Vector3.forward * this.m_direction.z , Color.red);
		if (!isNear) {
			isNear = Physics.Raycast(startPos , -Vector3.up , out hit ,this.c_RaycastHitDistMax , this.m_blockingLayer);
			Debug.DrawLine(startPos ,  -Vector3.up , Color.green);
		}
		if (!isNear) {
			Vector3 dir = Vector3.forward * this.m_direction.z + Vector3.up * -1 ; 
			isNear = Physics.Raycast(startPos , dir , out hit ,this.c_RaycastHitDistMax , this.m_blockingLayer);
			Debug.DrawLine(startPos , dir , Color.blue);
		}
		this.m_capsuleCollider.enabled = true ; 

		return isNear;
	}

	private void handleCreate() {
		if (this.isCanCreateCar() ) {
			this.gameObject.SetActive(false);
			DestroyObject(this.gameObject);
			// Debug.Log("~~~~~~~~~~  cannot create a car ");
		}
	}

	public void playHitSounds() {
		m_audioSource.Play();
	}
}
