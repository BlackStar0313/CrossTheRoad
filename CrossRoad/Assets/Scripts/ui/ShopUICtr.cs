using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopUICtr : MonoBehaviour {
	public Button m_btnHome ; 
	public Text m_textScore;

	private shader_transform_scene m_transScript = null ; 
	private bool m_isInTransform = false ; 

	void Start()
	{
		m_btnHome.onClick.AddListener(()=> handleTouch(m_btnHome));
		DispatchManager.getInstance().onRefreshShopShow.AddListener(refreshUIShow);

		refreshUIShow();
		SoundsManager.getInstance().playMusic(SoundsManager.clipNameShop);

		m_transScript = Camera.main.GetComponent<shader_transform_scene>();
		if (m_transScript) {
			m_transScript.DoChange(null , true, false);
		}
	}

	void OnDestroy()
	{
		m_btnHome.onClick.RemoveAllListeners();
		DispatchManager.getInstance().onRefreshShopShow.RemoveListener(refreshUIShow);
	}

	private void handleTouch(Button btn) {
		if (btn == m_btnHome) { 

			if (m_transScript) {
				m_isInTransform = true ;
				m_transScript.DoChange(transToMain , false, false);
			}

			SoundsManager.getInstance().playSounds(SoundsManager.clipNameClick);
		}
	}

	public void refreshUIShow() {
		m_textScore.text = PlayerManager.getInstance().GetPlayerInfo().score.ToString();
	}

	public void transToMain() {
		SceneManager.LoadScene("Menu");
		m_isInTransform = true ; 
	}
}
