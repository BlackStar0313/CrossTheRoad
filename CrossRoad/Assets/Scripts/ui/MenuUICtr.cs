using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class MenuUICtr : MonoBehaviour {
	public Button m_btnStart;
	public Button m_btnShop;

	private float m_fadeTime = 2;

	void Start()
	{
		m_btnStart.onClick.AddListener(() => handleTouch(m_btnStart));
		m_btnShop.onClick.AddListener(() => handleTouch(m_btnShop));

		fadeButton(1);

		GameObject obj = Instantiate(Resources.Load("Prefebs/Cloud")) as GameObject;
		CloudMoving move = obj.GetComponent<CloudMoving>();
		move.HideBegin(false);

		SoundsManager.getInstance().playMusic(SoundsManager.clipNameMenu);
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
	}

	private void fadeButton(float alpha) {
		CanvasGroup group = m_btnShop.GetComponent<CanvasGroup>();
		group.alpha = 1 - alpha ;
		group.DOFade(alpha , m_fadeTime);

		CanvasGroup group1 = m_btnStart.GetComponent<CanvasGroup>();
		group1.alpha = 1 - alpha ;
		group1.DOFade(alpha , m_fadeTime);
	}
}
