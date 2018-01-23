using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager {
	public static PlayerManager m_instance = null ; 

	public int score { get; set; }

	public static PlayerManager getInstance() {
		if (PlayerManager.m_instance == null) {
			PlayerManager.m_instance = new PlayerManager();
		}
		return PlayerManager.m_instance;
	}

	public void init() {
		this.score = 0 ; 
	}
}
