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

	private float m_decreaseTime = 6;
	private float m_addStep = 0.3f;
	private float m_randDist = 1.2f;

	private int m_showScore = 0;

	void Start()
	{
		m_textCoin.text = GameManager.getInstance().currentScore.ToString();
		m_Slider.value = 1 ;

		DispatchManager.getInstance().onMoveRight.AddListener(OnAddSlider);
		DispatchManager.getInstance().onAddCoin.AddListener(OnAddCoin);
		DispatchManager.getInstance().onAddHeart.AddListener(CreateHeart);

		m_pause.onClick.AddListener(delegate() { this.handleTouch(m_pause); });

		handleFrog();

	}

	void OnDestroy()
	{
		DispatchManager.getInstance().onMoveRight.RemoveListener(OnAddSlider);
		DispatchManager.getInstance().onAddCoin.RemoveListener(OnAddCoin);
		DispatchManager.getInstance().onAddHeart.RemoveListener(CreateHeart);
	}

	void Update()
	{
		//test code 
		return ;

		if (m_Slider.value <=0 || !GameManager.getInstance().IsPlaying()) {
			return ;
		}

		float curFrameStep = Time.deltaTime / m_decreaseTime;
		m_Slider.value = Mathf.Max(m_Slider.value - curFrameStep, 0) ;

		if (m_Slider.value <= 0) {
			GameManager.getInstance().handlePlayerDead(true);
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
		DOVirtual.DelayedCall(timeEnd, () => { this.m_textCoin.text = GameManager.getInstance().currentScore.ToString(); });
	}
}
