using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class MenuUICtr : MonoBehaviour {
	public Button m_btnStart;
	public Button m_btnShop;
	public Button m_btnSetting;
	public Text m_textBest;
	public Text m_textCurrent;
	public GameObject m_groupScore;

	private float m_fadeTime = 1;

	void Start()
	{
		m_btnStart.onClick.AddListener(() => handleTouch(m_btnStart));
		m_btnShop.onClick.AddListener(() => handleTouch(m_btnShop));
		m_btnSetting.onClick.AddListener(() => handleTouch(m_btnSetting));

		fadeButton(1);

		m_textBest.text = PlayerManager.getInstance().GetPlayerInfo().roundHighScore.ToString();
		m_textCurrent.text = PlayerManager.getInstance().GetPlayerInfo().score.ToString();

		GameObject obj = Instantiate(Resources.Load("Prefebs/Cloud")) as GameObject;
		CloudMoving move = obj.GetComponent<CloudMoving>();
		move.HideBegin(false);

		SoundsManager.getInstance().playMusic(SoundsManager.clipNameMenu);
	}

	void OnDestroy()
	{
		m_btnStart.onClick.RemoveListener(() => handleTouch(m_btnStart));
		m_btnShop.onClick.RemoveListener(() => handleTouch(m_btnShop));
		m_btnSetting.onClick.RemoveListener(() => handleTouch(m_btnSetting));
	}

	private void handleTouch(Button btn) {
		if (btn == m_btnStart) { 
			fadeButton(0);
			DOVirtual.DelayedCall(m_fadeTime, ()=> SceneManager.LoadScene("Main"));
			SoundsManager.getInstance().playSounds(SoundsManager.clipNameClick);
		}
		else if (btn == m_btnShop) {
			// fadeButton(0);
			// DOVirtual.DelayedCall(m_fadeTime, ()=> SceneManager.LoadScene("Shop"));
			ShopManager.getInstance().init();
			SceneManager.LoadScene("Shop");
			SoundsManager.getInstance().playSounds(SoundsManager.clipNameClick);
		}
		else if (btn == m_btnSetting) {
			Instantiate(Resources.Load("Prefebs/SettingLayer")) ;
			SoundsManager.getInstance().playSounds(SoundsManager.clipNameClick);
		}
	}

	private void fadeButton(float alpha) {
		CanvasGroup group = m_btnShop.GetComponent<CanvasGroup>();
		group.alpha = 1 - alpha ;
		group.DOFade(alpha , m_fadeTime);

		CanvasGroup group1 = m_btnStart.GetComponent<CanvasGroup>();
		group1.alpha = 1 - alpha ;
		group1.DOFade(alpha , m_fadeTime);

		CanvasGroup group2 = m_btnSetting.GetComponent<CanvasGroup>();
		group2.alpha = 1 - alpha ;
		group2.DOFade(alpha , m_fadeTime);

		CanvasGroup group3 = m_groupScore.GetComponent<CanvasGroup>();
		group3.alpha = 1 - alpha ;
		group3.DOFade(alpha , m_fadeTime);
	}
}
