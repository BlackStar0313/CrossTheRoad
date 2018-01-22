using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {
	public GameObject WarningUILayer ;
	[HideInInspector] public static UIManager mInstance = null ; 

	public static UIManager getInstance() {
		return UIManager.mInstance ; 
	}

	void Awake () {
		if (UIManager.mInstance == null) {
			UIManager.mInstance = this;
		}
		else if (UIManager.mInstance != this) {
			Destroy(gameObject);
		}
		DontDestroyOnLoad(gameObject);
	}
}
