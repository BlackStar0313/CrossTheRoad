using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_IOS || UNITY_ANDROID
using UnityEngine.Advertisements;
#endif

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

		#if UNITY_IOS || UNITY_ANDROID
		if (Advertisement.isSupported) {
			Advertisement.Initialize(GameConstant.gameId  );
		}
		#endif
	}
}
