using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class GameInstantManager : MonoBehaviour {
	public SoundsManager m_soundsManager ; 

	// Use this for initialization
	void Awake(){
		this.initGameConfig();

		PlayerManager.getInstance().init();
		DataManager.getInstance().init();
		ShopManager.getInstance().init();

		if (SoundsManager.mInstance == null) {
			SoundsManager.mInstance = Instantiate(m_soundsManager);
		}

		DontDestroyOnLoad(this);
	}
	
	private void initGameConfig() {
		Application.targetFrameRate = 60 ;

		if (Advertisement.isSupported) {
			Advertisement.Initialize(GameConstant.gameId  );
		}
	}
}
