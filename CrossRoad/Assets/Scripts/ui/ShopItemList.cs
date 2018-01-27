using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopItemList : MonoBehaviour {
	public GameObject m_ItemCell ; 
	public Transform m_content ;
	// public ScrollRect m_scrollRect;
	// Use this for initialization

	private StrDatashop[] m_ShopData ;
	void Start () {
		m_ShopData = DataManager.getInstance().GetShopData();
		this.init();
	}

	public void init () {
		for (int i = 0 ; i < m_ShopData.Length; ++i) {
			StrDatashop dataShop = m_ShopData[i] ;

			GameObject item = Instantiate(m_ItemCell);
			ShopItemCell cell = item.GetComponent<ShopItemCell>();
			cell.Init(dataShop.idx);

			item.transform.SetParent(m_content);
			item.transform.localScale = m_ItemCell.transform.localScale;
			item.transform.localPosition = m_ItemCell.transform.localPosition;
			item.transform.localRotation = m_ItemCell.transform.localRotation;
		}
	}
}
