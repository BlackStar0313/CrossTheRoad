using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour {

	public GameManager m_gameManager = null  ; 
	public UIManager m_UIManager = null  ; 

	// Use this for initialization
	void Awake()
	{
		this.initGameConfig();

		PlayerManager.getInstance().init();

		if (GameManager.mInstance == null) {
			GameManager obj = Instantiate(m_gameManager) as GameManager;
			GameManager.mInstance = obj;
		}

		if (UIManager.getInstance() == null) {
			Instantiate(m_UIManager);
		}
	} 

	private void initGameConfig() {
		Application.targetFrameRate = 60 ;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
