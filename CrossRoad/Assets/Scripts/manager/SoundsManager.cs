using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsManager : MonoBehaviour {
	[HideInInspector] public static string clipNameClick = "click";
	[HideInInspector] public static string clipNameClickNegtive = "click_negtive";
	[HideInInspector] public static string clipNameScroll = "scroll";
	[HideInInspector] public static string clipNameBuy = "buy";
	
	[HideInInspector] public static SoundsManager mInstance = null; 
	public AudioSource m_audio ;

	public AudioClip m_clipClick ; 
	public AudioClip m_clipNegtive ; 
	public AudioClip m_clipScroll;
	public AudioClip m_clipBuy;

	public static SoundsManager getInstance() {
		return SoundsManager.mInstance;
	}

	void Awake(){
		DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void playSounds(string clipName) {
		if (clipName == clipNameClick) {
			m_audio.clip = m_clipClick ;
			m_audio.Play();
		}
		else if (clipName == clipNameScroll) {
			m_audio.clip = m_clipScroll ;
			m_audio.Play();
		}
		else if (clipName == clipNameClickNegtive) {
			m_audio.clip = m_clipNegtive ;
			m_audio.Play();
		}
		else if (clipName == clipNameBuy) {
			m_audio.clip = m_clipBuy ;
			m_audio.Play();
		}
	}
}
