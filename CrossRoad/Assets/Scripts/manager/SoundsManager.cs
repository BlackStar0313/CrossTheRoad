using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsManager : MonoBehaviour {
	private string c_localMusicName = "music";
	private string c_localSoundsName = "sounds";

	[HideInInspector] public static string clipNameClick = "click";
	[HideInInspector] public static string clipNameClickNegtive = "click_negtive";
	[HideInInspector] public static string clipNameScroll = "scroll";
	[HideInInspector] public static string clipNameBuy = "buy";
	[HideInInspector] public static string clipNameGetHeart = "get_heart";
	[HideInInspector] public static string clipNameAddHeart = "add_heart";
	[HideInInspector] public static string clipNameMoveWrong = "move_wrong";
	[HideInInspector] public static string clipNameShopItemIdle = "shop_item_idle";
	[HideInInspector] public static string clipNameMenu = "bg_music";
	[HideInInspector] public static string clipNameGameBg = "game_bg";
	[HideInInspector] public static string clipNameShop = "game_shop";
	[HideInInspector] public static string clipNameReadyGo = "ready_go";
	[HideInInspector] public static string clipNameGameOver = "game_over";
	
	[HideInInspector] public static SoundsManager mInstance = null; 
	// public AudioSource m_audio ;
	public AudioSource m_music;

	public AudioClip m_clipClick ; 
	public AudioClip m_clipNegtive ; 
	public AudioClip m_clipScroll;
	public AudioClip m_clipBuy;
	public AudioClip m_clipGetHeart;
	public AudioClip m_clipAddHeart;
	public AudioClip m_moveWrong;
	public AudioClip[] m_shopItemIdles;
	public AudioClip m_clipMenu;
	public AudioClip[] m_clipGameBgs;
	public AudioClip m_clipShop;
	public AudioClip m_clipReadyGo;
	public AudioClip[] m_clipGameOver;

	public bool isSoundsOff {get; set;}
	public bool isMusicOff { get; set; }

	private GameObjectPool<AudioSource> m_objPool ;

	public static SoundsManager getInstance() {
		return SoundsManager.mInstance;
	}

	public void Init() {
		if (!PlayerPrefs.HasKey(c_localMusicName)) {
			PlayerPrefs.SetInt(c_localMusicName,1);
		}

		if (!PlayerPrefs.HasKey(c_localSoundsName)) {
			PlayerPrefs.SetInt(c_localSoundsName,1);
		}

		isSoundsOff = PlayerPrefs.GetInt(c_localSoundsName) == 1 ? false : true ; 
		isMusicOff = PlayerPrefs.GetInt(c_localMusicName) == 1 ? false : true ; 
	}

	void Awake(){
		DontDestroyOnLoad(this);

		m_objPool = new GameObjectPool<AudioSource>(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void playSounds(string clipName) {
		StartCoroutine(poolToPlaySounds(clipName));
	}

	IEnumerator poolToPlaySounds(string clipName) {
		AudioSource audio = m_objPool.get<AudioSource>();
		audio.loop = false ;
		singlePlaySounds(clipName, audio);
		yield return new WaitForSeconds(audio.clip.length);
		m_objPool.Recycle(audio);
	}

	private void singlePlaySounds(string clipName , AudioSource sourceAudio) {
		sourceAudio.volume = 1 ;
		if (clipName == clipNameClick) {
			sourceAudio.clip = m_clipClick ;
			sourceAudio.Play();
		}
		else if (clipName == clipNameScroll) {
			sourceAudio.clip = m_clipScroll ;
			sourceAudio.Play();
		}
		else if (clipName == clipNameClickNegtive) {
			sourceAudio.clip = m_clipNegtive ;
			sourceAudio.Play();
		}
		else if (clipName == clipNameBuy) {
			sourceAudio.clip = m_clipBuy ;
			sourceAudio.Play();
		}
		else if (clipName == clipNameGetHeart) {
			sourceAudio.clip = m_clipGetHeart ;
			sourceAudio.Play();
		}
		else if (clipName == clipNameAddHeart) {
			sourceAudio.clip = m_clipAddHeart ;
			sourceAudio.volume = 0.5f;
			sourceAudio.Play();
		}
		else if (clipName == clipNameMoveWrong) {
			sourceAudio.clip = m_moveWrong ;
			sourceAudio.Play();
		}
		else if (clipName == clipNameShopItemIdle) {
			int randIdx = Random.Range(0, m_shopItemIdles.Length);
			sourceAudio.clip = m_shopItemIdles[randIdx] ;
			sourceAudio.volume = 0.6f;
			sourceAudio.Play();
		}
		else if (clipName == clipNameReadyGo) {
			sourceAudio.clip = m_clipReadyGo ;
			sourceAudio.Play();
		}
		else if (clipName == clipNameGameOver) {
			int randIdx = Random.Range(0, m_clipGameOver.Length);
			sourceAudio.clip = m_clipGameOver[randIdx] ;
			sourceAudio.Play();
		}

		if (isSoundsOff) {
			sourceAudio.volume = 0;
		}
	}

	public void playMusic(string clipName) {
		m_music.volume = 1 ;
		if (clipName == clipNameMenu) {
			m_music.clip = m_clipMenu ;
			m_music.Play();
		}
		else if (clipName == clipNameGameBg) {
			int randIdx = Random.Range(0,m_clipGameBgs.Length);
			m_music.clip = m_clipGameBgs[randIdx] ;
			m_music.volume = 0.4f;
			m_music.Play();
		}
		else if (clipName == clipNameShop) {
			m_music.clip = m_clipShop ;
			m_music.Play();
		}

		if (isMusicOff) {
			m_music.volume = 0;
		}
	}

	public void musicOff(bool isOff) {
		PlayerPrefs.SetInt(c_localMusicName,isOff ? 0 : 1);
		isMusicOff = isOff;
		m_music.volume = isMusicOff ? 0 : 1;
	}

	public void soundsOff(bool isOff) {
		PlayerPrefs.SetInt(c_localSoundsName,isOff ? 0 : 1);
		isSoundsOff = isOff;

		List<AudioSource> usedList = m_objPool.GetAllUseObj();
		for (int i = 0 ; i < usedList.Count; ++i) {
			usedList[i].volume = isSoundsOff ? 0 : 1;
		}
	}
}
