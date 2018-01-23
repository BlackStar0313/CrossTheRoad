using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager {
	public static PlayerManager m_instance = null ; 

	public int score { get; set; }



	public int addScoreSpeed { get { return m_addScoreSpeed; } set { m_addScoreSpeed = value; } }  
	private int m_addScoreSpeed = 4 ;


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
