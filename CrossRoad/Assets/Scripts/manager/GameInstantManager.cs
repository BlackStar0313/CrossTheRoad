using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_IOS || UNITY_ANDROID
using UnityEngine.Advertisements;
#endif

public class GameInstantManager : MonoBehaviour {
	public static GameInstantManager mInstance = null;
	public SoundsManager m_soundsManager ; 
	public bool m_isCreate = false ; 


	public static GameInstantManager getInstance() {
		return GameInstantManager.mInstance;
	}

	// Use this for initialization
	void Awake(){
		if (m_isCreate) {
			return ;
		}

		this.initGameConfig();

		PlayerManager.getInstance().init();
		DataManager.getInstance().init();
		ShopManager.getInstance().init();

		if (SoundsManager.mInstance == null) {
			SoundsManager.mInstance = Instantiate(m_soundsManager);
			SoundsManager.mInstance.Init();
		}

		DontDestroyOnLoad(this);

		m_isCreate = true ;
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
