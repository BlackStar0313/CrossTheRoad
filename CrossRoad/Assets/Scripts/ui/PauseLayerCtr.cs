using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseLayerCtr : MonoBehaviour {
	public Button m_btnContinue;
	public Button m_btnHome;

	void Awake()
	{
		m_btnContinue.onClick.AddListener(delegate() {this.handleTouch(m_btnContinue );} );
		m_btnHome.onClick.AddListener(delegate() {this.handleTouch(m_btnHome );} );

		Time.timeScale = 0;
	}

	private void handleTouch(Button btn) {
		if (btn == m_btnContinue) {
			gameObject.SetActive(false);
			Destroy(gameObject);
			Time.timeScale = 1 ;
		}
		else if (btn == m_btnHome) {
			Time.timeScale = 1 ;
			GameManager.getInstance().LoadMenuScene();
		}
	}

}
