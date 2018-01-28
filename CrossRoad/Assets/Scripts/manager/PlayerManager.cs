using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class PlayerInfo {
	public int score ;
	public int roundHighScore;
	public List<int> roles ; 
	public int currentRole;

	public void UpdateScore(int roundScore ) {
		score += roundScore ;
		if (roundScore >= roundHighScore ) {
			roundHighScore = roundScore;
		}
	}

	public PlayerInfo() {
		score = 0 ; 
		roundHighScore = 0 ;
		roles = new List<int>();		//默认有一个角色
		roles.Add(1);
		currentRole = 1 ; 
	}

	public PlayerInfo PaseJson(string jsonString) {
		return JsonUtility.FromJson<PlayerInfo>(jsonString);
	}

	public string ToJson() {
		return JsonUtility.ToJson(this);
	}

	public void saveToLocal() {
		PlayerPrefs.SetString("PlayerInfo", ToJson());

		Debug.Log("~~~~~~~~~~  saveToLocal " + ToJson());
	}

	public string GetJsonStringFromLocal() {
		if (!PlayerPrefs.HasKey("PlayerInfo")) {
			PlayerPrefs.SetString("PlayerInfo", ToJson());

			string js =  ToJson();
			Debug.Log("~~~~~~~~~~  GetJsonStringFromLocal " + ToJson());
		}
		return PlayerPrefs.GetString("PlayerInfo");
	}
}

public class PlayerManager {
	public static PlayerManager m_instance = null ; 

	public int addScoreSpeed { get { return m_addScoreSpeed; } set { m_addScoreSpeed = value; } }  
	private int m_addScoreSpeed = 4 ;

	private PlayerInfo m_playerInfo = null ; 

	public static PlayerManager getInstance() {
		if (PlayerManager.m_instance == null) {
			PlayerManager.m_instance = new PlayerManager();
		}
		return PlayerManager.m_instance;
	}

	public void init() {
		PlayerPrefs.DeleteAll();

		m_playerInfo = new PlayerInfo();
		string jsonData = m_playerInfo.GetJsonStringFromLocal();
		Debug.Log("~~~~~~~~~~  jsonData " + jsonData);
		m_playerInfo = m_playerInfo.PaseJson(jsonData);
	}

	public PlayerInfo GetPlayerInfo() { return m_playerInfo; }

	public bool isScoreEnough(int price) {
		return m_playerInfo.score >= price ;
	}

	public void BuyRole(int price , int roleIdx) {
		if (m_playerInfo.score >= price) {
			m_playerInfo.score -= price ; 
			m_playerInfo.roles.Add(roleIdx);
			m_playerInfo.saveToLocal();
		}
	}

	public bool isOwnedRole(int roleIdx) {
		for (int i = 0 ; i < m_playerInfo.roles.Count ; ++i) {
			if (roleIdx == m_playerInfo.roles[i]) {
				return true ;
			}
		}
		return false ; 
	}
}
