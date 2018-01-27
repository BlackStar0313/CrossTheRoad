using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInstantManager : MonoBehaviour {

	// Use this for initialization
	void Awake(){
		this.initGameConfig();

		PlayerManager.getInstance().init();
		DataManager.getInstance().init();

		DontDestroyOnLoad(this);
	}
	
	private void initGameConfig() {
		Application.targetFrameRate = 60 ;
	}
}
