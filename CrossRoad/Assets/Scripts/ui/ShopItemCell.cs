using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopItemCell : MonoBehaviour {
	public GameObject m_itemPlayer ; 
	public Text m_textPrice ; 

	private int m_shopIdx; 
	

	public void Init(int shopIdx) {
		StrDatashop shopData = DataManager.getInstance().GetShopDataByIdx(shopIdx);

		m_textPrice.text = shopData.price.ToString();

		ShopItemRole roleCtr = m_itemPlayer.GetComponent<ShopItemRole>();
		roleCtr.HandleInit(shopData.role_idx);
	}
}
