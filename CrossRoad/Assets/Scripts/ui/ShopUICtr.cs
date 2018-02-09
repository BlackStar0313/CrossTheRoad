using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopUICtr : MonoBehaviour {
	public Button m_btnHome ; 
	public Text m_textScore;

	void Start()
	{
		m_btnHome.onClick.AddListener(()=> handleTouch(m_btnHome));
		DispatchManager.getInstance().onRefreshShopShow.AddListener(refreshUIShow);

		refreshUIShow();
		SoundsManager.getInstance().playMusic(SoundsManager.clipNameShop);
	}

	void OnDestroy()
	{
		m_btnHome.onClick.RemoveAllListeners();
		DispatchManager.getInstance().onRefreshShopShow.RemoveListener(refreshUIShow);
	}

	private void handleTouch(Button btn) {
		if (btn == m_btnHome) { 
			SceneManager.LoadScene("Menu");
			SoundsManager.getInstance().playSounds(SoundsManager.clipNameClick);
		}
	}

	public void refreshUIShow() {
		m_textScore.text = "x" + PlayerManager.getInstance().GetPlayerInfo().score.ToString();
	}
}
