using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_IOS || UNITY_ANDROID
using UnityEngine.Advertisements;
#endif
using DG.Tweening;

public class GameOverLayerCtr : MonoBehaviour {
	public Text m_textScore ;
	public Button m_btnContinue;
	public Button m_btnHome ; 
	public Button m_btnAds;
	public Text m_textTitle;
	public Transform m_groupAds;
	public Image m_imgHeart;
	public Image m_imgBest;


	private float m_titleTime = 0.8f;
	private float m_heartTime = 0.5f;
	private float m_bestTime = 0.7f;
	private float m_adsTime = 0.5f;
	private float m_btnDelayTime = 0.7f;
	private float m_btnTime = 0.5f;

	private float m_distTime = 0.2f;
	void Awake()
	{
		m_btnContinue.onClick.AddListener(delegate() { this.handleTouch(m_btnContinue); });
		m_btnHome.onClick.AddListener(delegate() { this.handleTouch(m_btnHome); });
		m_btnAds.onClick.AddListener(delegate() { this.handleTouch(m_btnAds); });

		bool isHighScore = false ;
		bool isShowAds = false ;

		if (GameManager.getInstance().currentScore > PlayerManager.getInstance().GetPlayerInfo().roundHighScore) {
			m_imgBest.gameObject.SetActive(true);
			isHighScore = true;
		}
		else {
			m_imgBest.gameObject.SetActive(false);
		}
		PlayerManager.getInstance().GetPlayerInfo().UpdateScore(GameManager.getInstance().currentScore);
		PlayerManager.getInstance().GetPlayerInfo().saveToLocal();

		m_textScore.text = "+" + GameManager.getInstance().currentScore.ToString() ; 
		m_textTitle.text = GameManager.getInstance().deadType == enumDeadType.timeout ? "TIME OUT" : "GAME OVER";


		if (GameManager.getInstance().currentScore > 0) {
			isShowAds = true ;
			// m_groupAds.position = new Vector3(m_textScore.transform.position.x + m_textScore.GetComponent<RectTransform>().sizeDelta.x , m_groupAds.position.y, m_groupAds.position.z);
		}
		else {
			m_groupAds.gameObject.SetActive(false);
		}


		//test code 
		isHighScore = true ; 
		m_imgBest.gameObject.SetActive(true);

		doAppearActTitle();
		doAppearHeart();
		doAppearScore();
		doAppearHighScore(isHighScore);
		doAppeartAds(isShowAds);
		doAppearBtn();

		SoundsManager.getInstance().playSounds(SoundsManager.clipNameGameOver);
	}

	void OnDestroy()
	{
		m_btnContinue.onClick.RemoveListener(delegate() { this.handleTouch(m_btnContinue); });
		m_btnHome.onClick.RemoveListener(delegate() { this.handleTouch(m_btnHome); });
		m_btnAds.onClick.RemoveListener(delegate() { this.handleTouch(m_btnAds); });
	}

	void doubleScore() {
		PlayerManager.getInstance().GetPlayerInfo().UpdateScore(GameManager.getInstance().currentScore);
		PlayerManager.getInstance().GetPlayerInfo().saveToLocal();
		m_textScore.text = "+" + (GameManager.getInstance().currentScore*2).ToString() ;

		m_groupAds.gameObject.SetActive(false); 
	}

	public void handleTouch(Button btn) {
		if (btn == m_btnContinue) {
			GameManager.getInstance().HandleDeadNextStatus(enumGameCurrentStatus.starting);

			gameObject.SetActive(false);
			Destroy(gameObject);

			SoundsManager.getInstance().playSounds(SoundsManager.clipNameClick);
		}
		else if (btn == m_btnHome) {
			GameManager.getInstance().LoadMenuScene();

			SoundsManager.getInstance().playSounds(SoundsManager.clipNameClick);
		}
		else if (btn == m_btnAds) {
			showAds();
			SoundsManager.getInstance().playSounds(SoundsManager.clipNameClick);
		}
	}

	private void showAds() {
#if UNITY_IOS || UNITY_ANDROID
		if (!Advertisement.IsReady(GameConstant.adsReward)) {
			return ;
		}

		ShowOptions options = new ShowOptions();
		options.resultCallback = handleShowCallBack;
		Advertisement.Show(GameConstant.adsReward, options);
#endif
	}

#if UNITY_IOS || UNITY_ANDROID
	private void handleShowCallBack(ShowResult result) {
		if (result == ShowResult.Failed) {
			Debug.Log("~~~~  filed to show ");
		}
		else if (result == ShowResult.Skipped) {
			Debug.Log("~~~~  skipped  to show ");
		}
		else if (result == ShowResult.Finished) {
			doubleScore();
			doAddScoreAction();
			SoundsManager.getInstance().playSounds(SoundsManager.clipNameAddHeart);

			Debug.Log("~~~~ success to show ads ");
		}
	}
#endif

	private void doAddScoreAction() {
		float timeScale = 0.2f;
		Sequence seqScale = DOTween.Sequence();
		seqScale.Append(m_imgHeart.transform.DOScale(new Vector3(1.5f, 1.5f , 1.5f) , timeScale));
		seqScale.Append(m_imgHeart.transform.DOScale(new Vector3(1f, 1f , 1f) , timeScale));

		//TODO: add roll score 
	}

	private void doAppearActTitle() {
		float endY = m_textTitle.transform.position.y ; 
		m_textTitle.transform.position += new Vector3(0 , (50 + endY) , 0) ;
		m_textTitle.transform.DOMoveY(endY , m_titleTime).SetEase(Ease.OutBounce);
	}

	private void doAppearHeart() {
		float endX = m_imgHeart.transform.position.x ; 
		m_imgHeart.transform.position -= new Vector3(Screen.width/16*11, 0 , 0 );
		DOVirtual.DelayedCall(m_titleTime-m_distTime , ()=>{ m_imgHeart.transform.DOMoveX(endX , m_heartTime).SetEase(Ease.OutBack); });
	}

	private void doAppearScore() {
		float endX = m_textScore.transform.position.x ; 
		m_textScore.transform.position -= new Vector3(Screen.width/16*11, 0 , 0 );
		DOVirtual.DelayedCall(m_titleTime-m_distTime , ()=>{ m_textScore.transform.DOMoveX(endX , m_heartTime).SetEase(Ease.OutBack); });
	}

	private void doAppearHighScore(bool isShow) {
		if (!isShow) {
			return ;
		}

		m_imgBest.gameObject.SetActive(false);
		DOVirtual.DelayedCall(m_titleTime + m_heartTime - m_distTime , () => {
			m_imgBest.gameObject.SetActive(true);
			Vector3 rotateValue = new Vector3(10,0,10);
			Sequence seqScale = DOTween.Sequence();
			seqScale.Append(m_imgBest.transform.DOScale(new Vector3(1.5f, 1.5f , 1.5f) , m_bestTime/2));
			seqScale.Join(m_imgBest.transform.DORotate(m_imgBest.transform.eulerAngles + rotateValue , m_bestTime/2));
			seqScale.Append(m_imgBest.transform.DOScale(new Vector3(1f, 1f , 1f) , m_bestTime/2));
			seqScale.Join(m_imgBest.transform.DORotate(m_imgBest.transform.eulerAngles - rotateValue , m_bestTime/2));
		} ) ; 
	}

	private void doAppeartAds(bool isShow) {
		if (!isShow) {
			return ;
		}

		float endX = m_groupAds.transform.position.x ; 
		m_groupAds.transform.position += new Vector3(Screen.width/2, 0 , 0 );
		DOVirtual.DelayedCall(m_titleTime + m_heartTime - m_distTime, ()=>{ m_groupAds.transform.DOMoveX(endX , m_adsTime).SetEase(Ease.OutBack); });
	}

	private void doAppearBtn() {
		CanvasGroup group = m_btnContinue.GetComponent<CanvasGroup>();
		group.alpha = 0 ;
		DOVirtual.DelayedCall(m_titleTime + m_heartTime + m_btnDelayTime , ()=>{group.DOFade(1 , m_btnTime);} );
		

		CanvasGroup group1 = m_btnHome.GetComponent<CanvasGroup>();
		group1.alpha = 0 ;
		DOVirtual.DelayedCall(m_titleTime + m_heartTime + m_btnDelayTime , ()=>{group1.DOFade(1 , m_btnTime);} );
	}
}
