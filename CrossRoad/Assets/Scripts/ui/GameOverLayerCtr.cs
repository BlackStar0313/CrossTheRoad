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

	void Awake()
	{
		if (GameManager.getInstance().currentScore > PlayerManager.getInstance().GetPlayerInfo().roundHighScore) {
			m_imgBest.gameObject.SetActive(true);
		}
		else {
			m_imgBest.gameObject.SetActive(false);
		}
		PlayerManager.getInstance().GetPlayerInfo().UpdateScore(GameManager.getInstance().currentScore);
		PlayerManager.getInstance().GetPlayerInfo().saveToLocal();

		m_textScore.text = "+" + GameManager.getInstance().currentScore.ToString() ; 
		m_textTitle.text = GameManager.getInstance().deadType == enumDeadType.timeout ? "Time Out" : "Game Over";


		if (GameManager.getInstance().currentScore > 0) {
			// m_groupAds.position = new Vector3(m_textScore.transform.position.x + m_textScore.GetComponent<RectTransform>().sizeDelta.x , m_groupAds.position.y, m_groupAds.position.z);
		}
		else {
			m_groupAds.gameObject.SetActive(false);
		}

		m_btnContinue.onClick.AddListener(delegate() { this.handleTouch(m_btnContinue); });
		m_btnHome.onClick.AddListener(delegate() { this.handleTouch(m_btnHome); });
		m_btnAds.onClick.AddListener(delegate() { this.handleTouch(m_btnAds); });
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
}
