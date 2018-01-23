using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverLayerCtr : MonoBehaviour {
	public Text m_textScore ;
	public Button m_btnContinue;
	public Button m_btnHome ; 

	void Awake()
	{
		m_textScore.text = "Player Score: " + PlayerManager.getInstance().score.ToString() ; 

		m_btnContinue.onClick.AddListener(delegate() { this.handleTouch(m_btnContinue); });
		m_btnHome.onClick.AddListener(delegate() { this.handleTouch(m_btnHome); });
	}

	public void handleTouch(Button btn) {
		if (btn == m_btnContinue) {
			GameManager.getInstance().HandleDeadNextStatus(enumGameCurrentStatus.starting);

			gameObject.SetActive(false);
			Destroy(gameObject);
		}
		else if (btn == m_btnHome) {
			// GameManager.getInstance().HandleDeadNextStatus(enumGameCurrentStatus.outside);
			Debug.Log("~~~~~~~~  next home ");
		}
	}

	
}
