using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class GameManager : MonoBehaviour {
	public GameObject m_car;
	public Transform[] m_carStartPos;
	public Transform[] m_carEndPos;
	public Transform[] m_carPausePos;

	[HideInInspector] public static GameManager mInstance = null ; 

	private bool[] m_isStartCreateCar = {true , true , true , true };
	private float m_maxIntervelCreatCarTime = 2f ; 
	private float m_minIntervelCreateCarTime = 1f;
	private float m_trafficIntervelCreateCarTime = 0.5f;

	public bool isTrafficRed { get; set; }

	public static GameManager getInstance() {
		return GameManager.mInstance ; 
	}
	
	private void init() {
		isTrafficRed = false ;
	}

	// Use this for initialization
	void Awake () {
		if (GameManager.mInstance == null) {
			GameManager.mInstance = this;
		}
		else if (GameManager.mInstance != this) {
			Destroy(gameObject);
		}
		DontDestroyOnLoad(gameObject);

		this.init();
	}
	
	// Update is called once per frame
	void Update () {
		if (m_isStartCreateCar[0]) {
			StartCoroutine(AutoCreateCar(0));
		}

		if (m_isStartCreateCar[1]) {
			StartCoroutine(AutoCreateCar(1));
		}

		if (m_isStartCreateCar[2]) {
			StartCoroutine(AutoCreateCar(2));
		}

		if (m_isStartCreateCar[3]) {
			StartCoroutine(AutoCreateCar(3));
		}
	}

	protected IEnumerator AutoCreateCar(int idx) {
		this.m_isStartCreateCar[idx] = false ;

		float randTime = m_trafficIntervelCreateCarTime;
		if (!isTrafficRed) {
			GameObject obj = Instantiate(this.m_car);
			CarControl car = obj.GetComponent<CarControl>();
			car.HandleInit(this.m_carStartPos[idx], this.m_carPausePos[idx] , this.m_carEndPos[idx]);
			randTime = Random.Range(m_minIntervelCreateCarTime, m_maxIntervelCreatCarTime);
		}
				
		Debug.Log(" delay time is " + randTime ) ; 
		yield return new WaitForSeconds(randTime) ; 

		this.m_isStartCreateCar[idx] = true ; 
	}

}
