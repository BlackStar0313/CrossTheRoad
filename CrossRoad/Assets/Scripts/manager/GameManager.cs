using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.Events;

public enum enumGameCurrentStatus {
	outside , 
	starting , 
	playing , 
	ending 
}

public enum enumDeadType {
	timeout ,
	hit
}

public class GameManager : MonoBehaviour {
	public GameObject[] m_cars;
	public GameObject m_player ; 
	public GameObject m_partner;
	public Transform[] m_carStartPos;
	public Transform[] m_carEndPos;
	public Transform[] m_carPausePos;

	[HideInInspector] public static GameManager mInstance = null ; 

	private bool[] m_isStartCreateCar = {true , true , true , true };
	private float m_maxIntervelCreatCarTime = 3f ; 
	private float m_minIntervelCreateCarTime = 1f;
	private float m_trafficIntervelCreateCarTime = 0.5f;
	private enumGameCurrentStatus currentStatus { get; set; }

	[HideInInspector] public bool isTrafficRed { get; set; }
	[HideInInspector] public float playerDirect { get; set; }
	

	[HideInInspector] public enumArrowType currentArrowType { get; set; }
	[HideInInspector] public enumArrowDirection currentArrowDirect { get; set; }
	[HideInInspector] public enumDeadType deadType { get; set; }
	[HideInInspector] public bool isOffset { get; set; }

	[HideInInspector] public int currentScore { get; set; }


	private bool m_isCameraFinish = false;

	public static GameManager getInstance() {
		return GameManager.mInstance ; 
	}

	GameManager() {
		isTrafficRed = true ; 
		playerDirect = 1 ; 
		currentArrowType = enumArrowType.normal;
		currentArrowDirect = enumArrowDirection.left ;
		currentStatus = enumGameCurrentStatus.outside ; 
		currentScore = 0;
	}

	// Use this for initialization
	void Start() {
		StartCoroutine(gameMainLoop());

		doCameraAct();
	}

	void Awake()
	{
		Debug.Log("");
	}

	IEnumerator gameMainLoop() {
		yield return StartCoroutine(RoundStarting());
		yield return StartCoroutine(RoundPlaying());
		yield return StartCoroutine(RoundEnding());
	}

	private void handleRoundEnd() {
		switch (currentStatus)
		{
			case enumGameCurrentStatus.starting: 
			{
				LoadGameScene();
				break;
			}
			
			case enumGameCurrentStatus.outside:
			{

				break;
			}
			default:
				break;
		}
	}

	IEnumerator RoundStarting() {
		this.ResetGame();
		currentStatus = enumGameCurrentStatus.starting ; 

		this.createPlayer();
		this.CreateNewPartner(1, true);
		this.CreateNewPartner(-1, true);

		DispatchManager.getInstance().onPartnerCatched.Invoke( playerDirect );

		while(!m_isCameraFinish) {
			yield return null ; 
		}

		yield return new WaitForSeconds(2) ; 
	}

	IEnumerator RoundPlaying() {
		currentStatus = enumGameCurrentStatus.playing;
		DispatchManager.getInstance().onStartGame.Invoke();

		while (currentStatus != enumGameCurrentStatus.ending) {
			yield return null ; 
		}
	}

	IEnumerator RoundEnding() {
		if (deadType == enumDeadType.hit)
			yield return new WaitForSeconds(1.5f) ; 
			
		//create dead layer 
		GameObject warningUIObj = Instantiate(Resources.Load("Prefebs/GameOverLayer") as GameObject);  

		while (IsPlayerDead())
		{
			yield return null ; 
		}
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
			GameObject obj = Instantiate(RandomCar());
			CarControl car = obj.GetComponent<CarControl>();
			car.HandleInit(this.m_carStartPos[idx], this.m_carPausePos[idx] , this.m_carEndPos[idx]);
			randTime = Random.Range(m_minIntervelCreateCarTime, m_maxIntervelCreatCarTime);
		}
				
		// Debug.Log(" delay time is " + randTime ) ; 
		yield return new WaitForSeconds(randTime) ; 

		this.m_isStartCreateCar[idx] = true ; 
	}

	private GameObject RandomCar() {
		int randomIdx = Random.Range(0, m_cars.Length);
		//test code 
		// randomIdx = 1 ;
		return m_cars[randomIdx];
	}

	private void createPlayer() {
		GameObject obj = Instantiate(this.m_player);
		Debug.Log("~~~~~~~  createPlayer  ");
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
		currentScore = 0 ; 
	}

	public void handlePlayerDead(bool isTimeOut) {
		deadType = isTimeOut ? enumDeadType.timeout : enumDeadType.hit;

		currentStatus = enumGameCurrentStatus.ending ;

		if (!isTimeOut) {
			DispatchManager.getInstance().onHitCarDead.Invoke();
		}
		DispatchManager.getInstance().onMoveUIHide.Invoke();
		DispatchManager.getInstance().onGameOver.Invoke();
	}

	public void HandleDeadNextStatus(enumGameCurrentStatus status) {
		currentStatus = status ;
		this.handleRoundEnd();
	}



	public bool IsPlayerDead() { return currentStatus == enumGameCurrentStatus.ending ; }
	public bool IsPlaying() { return currentStatus == enumGameCurrentStatus.playing ; }

	public void PauseGame(bool isPause) {
		Time.timeScale = isPause ? 0 : 1;
	}

	public void LoadMenuScene() {
		currentStatus = enumGameCurrentStatus.outside ; 

		GameObject obj = Instantiate(Resources.Load("Prefebs/Cloud")) as GameObject;
		CloudMoving move = obj.GetComponent<CloudMoving>();
		move.ShowBegin(true);

		DOVirtual.DelayedCall(2.5f, ()=>{
			this.Clear();
			SceneManager.LoadScene("Menu");
		});
	}

	public void LoadGameScene() {
		GameObject obj = Instantiate(Resources.Load("Prefebs/Cloud")) as GameObject;
		CloudMoving move = obj.GetComponent<CloudMoving>();
		move.ShowBegin(true);

		DOVirtual.DelayedCall(2.5f, ()=>{
			this.Clear();
			SceneManager.LoadScene("Main");
		});
	}

	private void doCameraAct() {
		CameraCtr camera = Camera.main.GetComponent<CameraCtr>();
		if (camera) {
			camera.DoBeginAct(onCameraFinishCall);
		}
	}

	private void onCameraFinishCall() {
		DispatchManager.getInstance().onPlayReadyGo.Invoke();
		m_isCameraFinish = true ;
	}

	public void Clear() {
		gameObject.SetActive(false);
		Destroy(gameObject);
	}

}
