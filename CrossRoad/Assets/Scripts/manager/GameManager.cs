using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

enum enumGameCurrentStatus {
	outside , 
	starting , 
	playing , 
	ending 
}

public class GameManager : MonoBehaviour {
	public GameObject m_car;
	public GameObject m_player ; 
	public GameObject m_partner;
	public Transform[] m_carStartPos;
	public Transform[] m_carEndPos;
	public Transform[] m_carPausePos;

	[HideInInspector] public static GameManager mInstance = null ; 

	private bool[] m_isStartCreateCar = {true , true , true , true };
	private float m_maxIntervelCreatCarTime = 2f ; 
	private float m_minIntervelCreateCarTime = 1f;
	private float m_trafficIntervelCreateCarTime = 0.5f;
	private enumGameCurrentStatus currentStatus { get; set; }

	[HideInInspector] public bool isTrafficRed { get; set; }
	[HideInInspector] public float playerDirect { get; set; }
	

	[HideInInspector] public enumArrowType currentArrowType { get; set; }
	[HideInInspector] public enumArrowDirection currentArrowDirect { get; set; }
	public bool isOffset { get; set; }

	public static GameManager getInstance() {
		return GameManager.mInstance ; 
	}

	GameManager() {
		isTrafficRed = true ; 
		playerDirect = 1 ; 
		currentArrowType = enumArrowType.normal;
		currentArrowDirect = enumArrowDirection.left ;
		currentStatus = enumGameCurrentStatus.outside ; 
	}

	// Use this for initialization
	void Start() {
		StartCoroutine(gameMainLoop());
	}

	void Awake()
	{
		if (GameManager.mInstance == null) {
			GameManager.mInstance = this;
		}
		else if (GameManager.mInstance != this) {
			Destroy(gameObject);
		}
		// DontDestroyOnLoad(gameObject);
		Debug.Log("");
	}

	IEnumerator gameMainLoop() {
		yield return StartCoroutine(RoundStarting());
		yield return StartCoroutine(RoundPlaying());
		yield return StartCoroutine(RoundEnding());

		SceneManager.LoadScene(0);
	}

	IEnumerator RoundStarting() {
		this.ResetGame();
		currentStatus = enumGameCurrentStatus.starting ; 

		this.createPlayer();
		this.CreateNewPartner(1, true);
		this.CreateNewPartner(-1, true);

		DispatchManager.getInstance().onPartnerCatched.Invoke( playerDirect );
		yield return new WaitForSeconds(2);
	}

	IEnumerator RoundPlaying() {
		currentStatus = enumGameCurrentStatus.playing;

		while (currentStatus != enumGameCurrentStatus.ending) {
			yield return null ; 
		}
	}

	IEnumerator RoundEnding() {

		yield return new WaitForSeconds(3) ; 
	}


	
	// Update is called once per frame
	void Update () {
		if (!IsPlaying()) {
			return ;
		}

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
				
		// Debug.Log(" delay time is " + randTime ) ; 
		yield return new WaitForSeconds(randTime) ; 

		this.m_isStartCreateCar[idx] = true ; 
	}

	private void createPlayer() {
		Instantiate(this.m_player);
		playerDirect = 1;
	}

	public void CreateNewPartner(float direction, bool isPlaceHolder) {
		GameObject obj = Instantiate(this.m_partner);
		PartnerMoving partner = obj.GetComponent<PartnerMoving>();
		partner.handleInit(direction , isPlaceHolder);
	}

	public void ResetGame() {
		isTrafficRed = false ;
		playerDirect = 1 ;
	}

	public void handlePlayerDead() {
		currentStatus = enumGameCurrentStatus.ending ;

		DispatchManager.getInstance().onMoveUIHide.Invoke();
	}

	public bool IsPlayerDead() { return currentStatus == enumGameCurrentStatus.ending ; }
	public bool IsPlaying() { return currentStatus == enumGameCurrentStatus.playing ; }

}
