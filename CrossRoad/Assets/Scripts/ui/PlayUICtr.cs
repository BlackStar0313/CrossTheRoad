using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class PlayUICtr : MonoBehaviour {
	public Text m_textCoin ;
	public Slider m_Slider ; 
	public Button m_pause ; 
	public Image m_heartImg;
	public GameObject m_heart;
	public Camera m_currentCamera;
	public Camera m_heartCamera;
	public Image m_imgWarning ;
	public AudioSource m_audioTimeout;
	public Image m_imgStatus;
	public Sprite m_spIdle;
	public Sprite[] m_spAngry;
	public Sprite m_spReady;
	public Sprite m_spGo;

	private float m_decreaseTime = 6;
	private float m_addStep = 0.25f;
	private float m_randDist = 1.2f;

	private int m_showScore = 0;
	private float m_warningPercent = 0.4f;

	private bool m_isTimeout = false ;

	private float m_switchStatusTime = 0.4f;
	private float m_countDownTime = 0 ;

	void Awake()
	{
		Debug.Log("");

		DispatchManager.getInstance().onMoveRight.AddListener(OnAddSlider);
		DispatchManager.getInstance().onAddCoin.AddListener(OnAddCoin);
		DispatchManager.getInstance().onAddHeart.AddListener(CreateHeart);
		DispatchManager.getInstance().onGameOver.AddListener(onGameOver);
		DispatchManager.getInstance().onPlayReadyGo.AddListener(onReadyGo);

		m_pause.onClick.AddListener(delegate() { this.handleTouch(m_pause); });
	}

	void Start()
	{
		m_textCoin.text = GameManager.getInstance().currentScore.ToString();
		m_Slider.value = 1 ;

		handleFrog();
		SoundsManager.getInstance().playMusic(SoundsManager.clipNameGameBg);
	}

	void OnDestroy()
	{
		DispatchManager.getInstance().onMoveRight.RemoveListener(OnAddSlider);
		DispatchManager.getInstance().onAddCoin.RemoveListener(OnAddCoin);
		DispatchManager.getInstance().onAddHeart.RemoveListener(CreateHeart);
		DispatchManager.getInstance().onGameOver.RemoveListener(onGameOver);
		DispatchManager.getInstance().onPlayReadyGo.RemoveListener(onReadyGo);
	}

	void Update()
	{
		//test code 
		// return ;
		
		if (m_isTimeout || !GameManager.getInstance().IsPlaying()) {
			return ;
		}

		float curFrameStep = Time.deltaTime / m_decreaseTime;
		float value = m_Slider.value - curFrameStep;
		m_Slider.value = Mathf.Max(value, 0) ;
		m_isTimeout = value <= 0 ? true : false;
		

		if (m_isTimeout) {
			m_imgWarning.gameObject.SetActive(false);

			GameManager.getInstance().handlePlayerDead(true);
		}
		else {
			shineWarning(m_Slider.value);
		}
	}

	void OnAddSlider() {
		m_Slider.value += m_addStep;
	}

	void OnAddCoin() {
		GameManager.getInstance().currentScore += PlayerManager.getInstance().addScoreSpeed;

		// this.m_textCoin.text = GameManager.getInstance().currentScore.ToString();
	}

	void handleTouch(Button btn) {
		SoundsManager.getInstance().playSounds(SoundsManager.clipNameClick);
		Instantiate(Resources.Load("Prefebs/PauseLayer")) ;
	}

	private void handleFrog() {
		GameObject obj = Instantiate(Resources.Load("Prefebs/Cloud")) as GameObject;
		CloudMoving move = obj.GetComponent<CloudMoving>();
		move.HideBegin(true);
	}

	private void CreateHeart(Vector3 startPos) {
		Vector3 heartCamera = Camera.main.WorldToScreenPoint(startPos);
		Vector3 localPos = m_heartCamera.ScreenToWorldPoint(heartCamera);
		
		Vector3 targetCameraCamera = m_currentCamera.WorldToScreenPoint(m_heartImg.transform.position);
		Vector3 targetPos = m_heartCamera.ScreenToWorldPoint(targetCameraCamera);


		SoundsManager.getInstance().playSounds(SoundsManager.clipNameGetHeart);
		//TODO： 先做一起到处理，之后增加挨个到的逻辑
		float timeCreate = 0.3f;
		float timeMove = 0.8f;
		float timeScale = 0.2f;
		for (int i = 0 ; i < PlayerManager.getInstance().addScoreSpeed ; ++i) {
			float randX = localPos.x + Random.Range(-m_randDist , m_randDist) ;
			float randY = localPos.y + Random.Range(-m_randDist , m_randDist) ;
			Vector3 waitPos = new Vector3(randX, randY , localPos.z);
			
			// world
			GameObject heart = Instantiate(m_heart , localPos , m_heart.transform.rotation);


			Vector3 baseScale = heart.transform.localScale;
			Vector3 addScale = new Vector3(0.4f , 0.4f , 0.4f);
			Sequence seq = DOTween.Sequence();
			seq.Append(heart.transform.DOMove(waitPos, timeCreate).SetEase(Ease.InBack));
			seq.Join(heart.transform.DOScale(baseScale + addScale  , timeCreate));
			seq.Append(heart.transform.DOMove(targetPos ,  timeMove ).SetEase(Ease.InCubic));
			seq.Join(heart.transform.DOScale(baseScale , timeMove));
			seq.AppendCallback(() => { 
				Sequence seqScale = DOTween.Sequence();
				seqScale.Append(m_heartImg.transform.DOScale(new Vector3(1.5f, 1.5f , 1.5f) , timeScale));
				seqScale.Append(m_heartImg.transform.DOScale(new Vector3(1f, 1f , 1f) , timeScale));


				heart.SetActive(false);
				DestroyObject(heart);

				// this.m_textCoin.text += 1;
			 });
		}
		
		float timeEnd = timeCreate + timeMove ;
		DOVirtual.DelayedCall(timeEnd, () => { 
			this.m_textCoin.text = GameManager.getInstance().currentScore.ToString(); 

			//TODO：这里先播一个声音
			SoundsManager.getInstance().playSounds(SoundsManager.clipNameAddHeart);
		});
	}

	private void shineWarning(float curPercent) {
		bool isShine = m_Slider.value <= m_warningPercent ? true : false;
		if (isShine) {
			if (m_imgWarning.gameObject.activeSelf == false) {
				m_imgWarning.gameObject.SetActive(true);
				
				m_imgWarning.color = new Color(m_imgWarning.color.r,m_imgWarning.color.g, m_imgWarning.color.b , 0.3f);
				Sequence seq = DOTween.Sequence();
				seq.Append(DOTween.ToAlpha(()=> m_imgWarning.color , x=> m_imgWarning.color = x , 1f , 0.3f ));
				seq.Append(DOTween.ToAlpha(()=> m_imgWarning.color , x=> m_imgWarning.color = x , 0.3f , 0.3f ));

				seq.SetLoops(-1);

				m_audioTimeout.Play();

				m_audioTimeout.volume = SoundsManager.getInstance().isSoundsOff ? 0 : 1;
			}

			doSwitchStatusAct(true);
		}
		else {
			if (m_imgWarning.gameObject.activeSelf == true) {
				m_imgWarning.gameObject.SetActive(false);
				m_audioTimeout.Stop();
			}
			doSwitchStatusAct(false);
		}
	}

	private void onGameOver() {
		m_audioTimeout.Stop();
		m_imgWarning.gameObject.SetActive(false);
	}

	private void doSwitchStatusAct(bool isLow) {
		if (isLow) {
			if (m_countDownTime <= 0) {
				if (m_imgStatus.sprite != m_spAngry[0]) {
					m_imgStatus.sprite = m_spAngry[0];
				}
				else if (m_imgStatus.sprite != m_spAngry[1]) {
					m_imgStatus.sprite = m_spAngry[1];
				}
				m_countDownTime = m_switchStatusTime;
			}
			m_countDownTime -= Time.deltaTime;
		}
		else {
			if (m_imgStatus.sprite != m_spIdle) {
				m_imgStatus.sprite = m_spIdle;
			}
			m_countDownTime = 0 ;
		}
	}

	private void onReadyGo() {
		float actTime = 1;
		GameObject obj = new GameObject();
		Image img = obj.AddComponent(typeof(Image)) as Image;
		img.sprite = m_spReady;

		obj.transform.parent = transform ;
		obj.transform.localRotation = Quaternion.identity;
		obj.transform.localPosition = new Vector3(0 , 0 , 0);

		img.GetComponent<RectTransform>().sizeDelta = new Vector2(m_spReady.rect.width , m_spReady.rect.height) ; 
		img.transform.localScale = new Vector3(2f,2f,2f);
		img.transform.DOScale(new Vector3(0.2f,0.2f,0.2f) , actTime).OnComplete(()=> {
			obj.SetActive(false);
			Destroy(obj);
		}) ;


		DOVirtual.DelayedCall(actTime , ()=> {
			GameObject obj2 = new GameObject();
			Image img2 = obj2.AddComponent(typeof(Image)) as Image;
			img2.sprite = m_spGo;

			obj2.transform.parent = transform ;
			obj2.transform.localRotation = Quaternion.identity;
			obj2.transform.localPosition = new Vector3(0 , 0 , 0);

			img2.GetComponent<RectTransform>().sizeDelta = new Vector2(m_spGo.rect.width , m_spGo.rect.height) ;
			img2.transform.localScale = new Vector3(2f,2f,2f);
			img2.transform.DOScale(new Vector3(0.2f,0.2f,0.2f) , actTime).OnComplete(()=> {
				obj2.SetActive(false);
				Destroy(obj2);
			}) ;
		});



		SoundsManager.getInstance().playSounds(SoundsManager.clipNameReadyGo);

	}
}
