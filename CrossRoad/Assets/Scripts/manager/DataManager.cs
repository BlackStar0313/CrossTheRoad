﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;

public class DataManager {
	public static DataManager mInstance = null ; 
	private LocalDataCollection m_localAllData ;

	public static DataManager getInstance() {
		if (DataManager.mInstance == null) {
			DataManager.mInstance = new DataManager();
		}
		return DataManager.mInstance;
	}

	public void init () {
		parseJsonFromLocal();
	}

	public void parseJsonFromLocal() {
		string jsonPath = Application.dataPath + "/Resources/data.json";
		if (!File.Exists(jsonPath)) {
			return ;
		}

		StreamReader str = new StreamReader(jsonPath);
		if (str == null) {
			return ; 
		}

		string json = str.ReadToEnd();
		Debug.Log("~~~~~~~~  data json is " + json) ; 
		if (json.Length > 0) {
			m_localAllData = JsonUtility.FromJson<LocalDataCollection>(json);
			Debug.Log("~~~~~~~~  data json is " + json) ; 
		}
	}

	public StrDatarole[] GetRoleData() {
		return m_localAllData.role.data;
	}

	public StrDatarole? GetRoleDataByIdx(int idx) {
		for (int i = 0 ; i < m_localAllData.role.data.Length ; ++i) {
			if (m_localAllData.role.data[i].idx == idx) 
				return m_localAllData.role.data[i];
		}
		return null ; 
	}

	public StrDatashop[] GetShopData() {
		return m_localAllData.shop.data;
	}

	public StrDatashop? GetShopDataByIdx(int idx) {
		for (int i = 0 ; i < m_localAllData.shop.data.Length ; ++i) {
			if (m_localAllData.shop.data[i].idx == idx) 
				return m_localAllData.shop.data[i];
		}
		return null ; 
	}
}