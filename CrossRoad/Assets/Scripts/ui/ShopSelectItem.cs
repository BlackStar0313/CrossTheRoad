using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ShopSelectItem : MonoBehaviour, IPointerClickHandler  {
	public GameObject m_shopItem; 

	public void OnPointerClick(PointerEventData eventData) {
        ShopItemCell cell = m_shopItem.GetComponent<ShopItemCell>();
		cell.onSelected();
	}
}
