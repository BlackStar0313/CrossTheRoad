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

		if (GameManager.getInstance() == null) {
			Instantiate(m_gameManager);
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
