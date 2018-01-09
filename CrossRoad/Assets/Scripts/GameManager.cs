using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	[HideInInspector] public static GameManager mInstance = null ; 

	public static GameManager getInstance() {
		return GameManager.mInstance ; 
	}


	// Use this for initialization
	void Awake () {
		if (GameManager.mInstance == null) {
			GameManager.mInstance = this;
		}
		else if (GameManager.mInstance != this) {
			Destroy(gameObject);
		}
		DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
