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
	public Image m_imgHeart;
	public Image m_imgBest;
	public Image m_imgBest_bg;
	public Image m_imgTitle;
	public GameObject m_groupScore;
	public Image m_imgBgBtn;
	public Image m_imgBgAds;
	public Image m_imgAdsDesc;
	public GameObject m_groupAds;

	public Sprite m_spGameOver;
	public Sprite m_spTimeOut;
	public Sprite m_spBgBest;


	private float m_titleTime = 0.8f;
	private float m_heartTime = 0.5f;
	private float m_bestTime = 0.7f;
	private float m_adsTime = 0.5f;
	private float m_btnDelayTime = 0.7f;
	private float m_btnTime = 0.5f;

	private float m_distTime = 0.4f;
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
		m_imgTitle.sprite = GameManager.getInstance().deadType == enumDeadType.timeout ? m_spTimeOut : m_spGameOver;


		if (GameManager.getInstance().currentScore > 0) {
			isShowAds = true ;
			// m_groupAds.position = new Vector3(m_textScore.transform.position.x + m_textScore.GetComponent<RectTransform>().sizeDelta.x , m_groupAds.position.y, m_groupAds.position.z);
		}
		else {
			m_groupAds.gameObject.SetActive(false);
		}


		//test code 
		// isHighScore = true ; 
		// m_imgBest.gameObject.SetActive(true);

		doAppearActTitle();
		doAppearScoreGroup();
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
		float endY = m_imgTitle.transform.position.y ; 
		m_imgTitle.transform.position += new Vector3(0 , (m_imgTitle.GetComponent<RectTransform>().sizeDelta.y/2 + endY) , 0) ;
		m_imgTitle.transform.DOMoveY(endY , m_titleTime).SetEase(Ease.OutBounce);
	}

	private void doAppearScoreGroup() {
		float endX = m_groupScore.transform.position.x ; 
		m_groupScore.transform.position -= new Vector3(Screen.width/16*11, 0 , 0 );
		DOVirtual.DelayedCall(m_titleTime-m_distTime , ()=>{ m_groupScore.transform.DOMoveX(endX , m_heartTime).SetEase(Ease.OutBack); });
	}

	private void doAppearHighScore(bool isShow) {
		if (!isShow) {
			return ;
		}

		m_imgBest.gameObject.SetActive(false);
		DOVirtual.DelayedCall(m_titleTime + m_heartTime - m_distTime , () => {
			m_imgBest_bg.sprite = m_spBgBest;
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
		float dist = m_imgBgAds.GetComponent<RectTransform>().sizeDelta.x /3*4;
		float endX = m_imgBgAds.transform.position.x ; 
		m_imgBgAds.transform.position += new Vector3(dist, 0 , 0 );
		DOVirtual.DelayedCall(m_titleTime + m_heartTime - m_distTime, ()=>{ 
			m_imgBgAds.transform.DOMoveX(endX , m_adsTime/2);
		});


		float endX1 = m_btnAds.transform.position.x ; 
		float endXDesc = m_imgAdsDesc.transform.position.x ;
		m_btnAds.transform.position += new Vector3(dist, 0 , 0 );
		m_imgAdsDesc.transform.position += new Vector3(dist, 0 , 0 );
		DOVirtual.DelayedCall(m_titleTime + m_heartTime , ()=>{ 
			m_btnAds.transform.Rotate(new Vector3(0,0,-180) );
			Sequence seq1 = DOTween.Sequence();
			seq1.Append(m_btnAds.transform.DORotate(new Vector3(0,0,0) , m_adsTime));
			seq1.Join(m_btnAds.transform.DOMoveX(endX1 , m_adsTime).SetEase(Ease.OutBack));

			m_imgAdsDesc.transform.DOMoveX(endXDesc , m_adsTime);
		});
	}

	private void doAppearBtn() {
		float dist = m_imgBgBtn.GetComponent<RectTransform>().sizeDelta.x/3*4;
		float endX = m_imgBgBtn.transform.position.x ; 
		m_imgBgBtn.transform.position -= new Vector3(dist, 0 , 0 );
		DOVirtual.DelayedCall(m_titleTime + m_heartTime - m_distTime, ()=>{ 
			m_imgBgBtn.transform.DOMoveX(endX , m_adsTime/2);
		});


		float endXHome = m_btnHome.transform.position.x ; 
		float endXBack = m_btnContinue.transform.position.x ;
		m_btnHome.transform.position -= new Vector3(dist, 0 , 0 );
		m_btnContinue.transform.position -= new Vector3(dist, 0 , 0 );
		DOVirtual.DelayedCall(m_titleTime + m_heartTime , ()=>{ 
			m_btnHome.transform.Rotate(new Vector3(0,0,-180) );
			Sequence seq1 = DOTween.Sequence();
			seq1.Append(m_btnHome.transform.DORotate(new Vector3(0,0,0) , m_adsTime));
			seq1.Join(m_btnHome.transform.DOMoveX(endXHome , m_adsTime).SetEase(Ease.OutBack));


			m_btnContinue.transform.Rotate(new Vector3(0,0,-180) );
			Sequence seq2 = DOTween.Sequence();
			seq2.Append(m_btnContinue.transform.DORotate(new Vector3(0,0,0) , m_adsTime));
			seq2.Join(m_btnContinue.transform.DOMoveX(endXBack , m_adsTime).SetEase(Ease.OutBack));
		});
	}
}
