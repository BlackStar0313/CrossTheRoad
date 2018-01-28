using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager  {
	public static ShopManager m_Instance = null ; 
	
	public int currentSelectedRoleIdx { get; set; }


	public static ShopManager getInstance() {
		if (ShopManager.m_Instance == null) {
			ShopManager.m_Instance = new ShopManager();
		}
		return ShopManager.m_Instance ;
	}

	public void init() {
		currentSelectedRoleIdx = PlayerManager.getInstance().GetPlayerInfo().currentRole;
	}
}
