using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour {

	public GameManager m_gameManager = null  ; 

	// Use this for initialization
	void Awake()
	{
		this.initGameConfig();

		if (GameManager.getInstance() == null) {
			Instantiate(m_gameManager);
		}
	} 

	private void initGameConfig() {
		Application.targetFrameRate = 60 ;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
