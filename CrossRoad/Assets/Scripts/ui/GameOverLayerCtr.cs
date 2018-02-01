using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverLayerCtr : MonoBehaviour {
	public Text m_textScore ;
	public Button m_btnContinue;
	public Button m_btnHome ; 
	public Text m_textTitle;

	void Awake()
	{
		PlayerManager.getInstance().GetPlayerInfo().UpdateScore(GameManager.getInstance().currentScore);
		PlayerManager.getInstance().GetPlayerInfo().saveToLocal();

		m_textScore.text = "Player Score: " + GameManager.getInstance().currentScore.ToString() ; 
		m_textTitle.text = GameManager.getInstance().deadType == enumDeadType.timeout ? "Time Out" : "Game Over";

		m_btnContinue.onClick.AddListener(delegate() { this.handleTouch(m_btnContinue); });
		m_btnHome.onClick.AddListener(delegate() { this.handleTouch(m_btnHome); });
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
	}

	
}
