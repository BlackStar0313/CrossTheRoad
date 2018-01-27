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
		m_textScore.text = PlayerManager.getInstance().GetPlayerInfo().score.ToString();
	}

	void OnDestroy()
	{
		m_btnHome.onClick.RemoveAllListeners();
	}

	private void handleTouch(Button btn) {
		if (btn == m_btnHome) { 
			SceneManager.LoadScene("Menu");
		}
	}
}
