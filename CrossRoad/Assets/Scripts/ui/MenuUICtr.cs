using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUICtr : MonoBehaviour {
	public Button m_btnStart;
	public Button m_btnShop;

	void Awake()
	{
		m_btnStart.onClick.AddListener(() => handleTouch(m_btnStart));
		m_btnShop.onClick.AddListener(() => handleTouch(m_btnShop));
	}

	private void handleTouch(Button btn) {
		if (btn == m_btnStart) { 
			SceneManager.LoadScene("Main");
		}
		else if (btn == m_btnShop) {
			
		}
	}
}
