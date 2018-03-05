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
	public MenuRole m_role;
	public GameObject m_groupLogo;
	public GameObject m_bg_left;
	public GameObject m_bg_right;

	private float m_fadeTime = 1;

	private shader_transform_scene m_transScript = null ; 
	private bool m_isInTransform = false ; 

	void Start()
	{
		m_btnStart.onClick.AddListener(() => handleTouch(m_btnStart));
		m_btnShop.onClick.AddListener(() => handleTouch(m_btnShop));
		m_btnSetting.onClick.AddListener(() => handleTouch(m_btnSetting));

		fadeButton(1);
		m_role.fadePlayer(true, m_fadeTime);

		m_textBest.text = PlayerManager.getInstance().GetPlayerInfo().roundHighScore.ToString();
		m_textCurrent.text =  PlayerManager.getInstance().GetPlayerInfo().score.ToString();

		GameObject obj = Instantiate(Resources.Load("Prefebs/Cloud")) as GameObject;
		CloudMoving move = obj.GetComponent<CloudMoving>();
		move.HideBegin(false);

		SoundsManager.getInstance().playMusic(SoundsManager.clipNameMenu);


		m_transScript = Camera.main.GetComponent<shader_transform_scene>();
		if (m_transScript ) {
			m_transScript.DoChange(null , true , GameInstantManager.getInstance().isTransFromGameScene);
			GameInstantManager.getInstance().isTransFromGameScene = false;
		}
	}

	void OnDestroy()
	{
		m_btnStart.onClick.RemoveListener(() => handleTouch(m_btnStart));
		m_btnShop.onClick.RemoveListener(() => handleTouch(m_btnShop));
		m_btnSetting.onClick.RemoveListener(() => handleTouch(m_btnSetting));
	}

	private void handleTouch(Button btn) {
		if (m_isInTransform) {
			return ; 
		}

		if (btn == m_btnStart) { 
			fadeButton(0);
			m_role.fadePlayer(false, m_fadeTime);
			DOVirtual.DelayedCall(m_fadeTime, ()=> SceneManager.LoadScene("Main"));
			SoundsManager.getInstance().playSounds(SoundsManager.clipNameClick);
		}
		else if (btn == m_btnShop) {
			// fadeButton(0);
			// DOVirtual.DelayedCall(m_fadeTime, ()=> SceneManager.LoadScene("Shop"));

			if (m_transScript) {
				m_isInTransform = true ;
				m_transScript.DoChange(transToShop , false, false);
			}


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

		CanvasGroup group4 = m_groupLogo.GetComponent<CanvasGroup>();
		group4.alpha = 1 - alpha ;
		group4.DOFade(alpha , m_fadeTime);

		CanvasGroup group5 = m_bg_left.GetComponent<CanvasGroup>();
		group5.alpha = 1 - alpha ;
		group5.DOFade(alpha , m_fadeTime);

		CanvasGroup group6 = m_bg_right.GetComponent<CanvasGroup>();
		group6.alpha = 1 - alpha ;
		group6.DOFade(alpha , m_fadeTime);
	}


	public void transToShop() {
		ShopManager.getInstance().init();
		SceneManager.LoadScene("Shop");
		m_isInTransform = true ; 
	}

}
