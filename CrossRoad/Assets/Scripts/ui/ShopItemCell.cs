using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopItemCell : MonoBehaviour {
	enum enumShopItemCellBtnType {
		none ,
		showBuy ,
		showConfirm
	}

	public GameObject m_itemPlayer ; 
	public Text m_textPrice ; 
	public Image m_imgRect;
	public Button m_btnBuy;
	public Button m_btnConfirm;

	private int m_shopIdx; 
	private bool m_isSelected ;
	// private bool m_isSelected { get { return m_isSelected; } 
	// 	set { 
	// 		m_isSelected = value ; 
	// 		m_imgRect.enabled = m_isSelected ; 
	// 	} 
	// }

	public int GetShopIdx() { return m_shopIdx; }

	void Awake()
	{
		m_imgRect.gameObject.SetActive(false); 
		m_isSelected = false ; 

		m_btnBuy.onClick.AddListener(()=> handleTouch(m_btnBuy));
		m_btnConfirm.onClick.AddListener(()=> handleTouch(m_btnConfirm));

		DispatchManager.getInstance().onSelectShopItem.AddListener(this.onSelected);

	}

	void OnDestroy()
	{
		m_btnBuy.onClick.RemoveListener(()=> handleTouch(m_btnBuy));
		m_btnConfirm.onClick.RemoveListener(()=> handleTouch(m_btnConfirm));

		DispatchManager.getInstance().onSelectShopItem.RemoveListener(this.onSelected);
	}
	

	public void Init(int shopIdx) {
		m_shopIdx = shopIdx;
		StrDatashop shopData = DataManager.getInstance().GetShopDataByIdx(shopIdx);
		if (ShopManager.getInstance().currentSelectedRoleIdx == shopData.role_idx) {
			m_isSelected = true ; 
			m_imgRect.gameObject.SetActive(m_isSelected); 
		}

		//handle ui show .
		m_textPrice.text = shopData.price.ToString();
		refreshShow();

		//set role showing .
		ShopItemRole roleCtr = m_itemPlayer.GetComponent<ShopItemRole>();
		roleCtr.HandleInit(shopData.role_idx);
	}

	private void refreshShow() {
		HandleBtnStatus();

		//TODO: handle animator 

		ShopItemRole itemRole = m_itemPlayer.GetComponent<ShopItemRole>();
		if (m_isSelected) {
			itemRole.handleAnimation(false);
		}
		else {
			itemRole.handleAnimation(true);
		}
	}

	public void onSelected(int selectedShopIdx) {
		if (selectedShopIdx == m_shopIdx && m_isSelected ||
			selectedShopIdx != m_shopIdx && !m_isSelected ) {
			return ;
		}

		m_isSelected = !m_isSelected ; 
		m_imgRect.gameObject.SetActive(m_isSelected); 
		
		refreshShow();

		SoundsManager.getInstance().playSounds(SoundsManager.clipNameShopItemIdle);
	}

	private void HandleBtnStatus () {
		StrDatashop shopData = DataManager.getInstance().GetShopDataByIdx(m_shopIdx);
		bool isOwnedRole = PlayerManager.getInstance().isOwnedRole(shopData.role_idx );
		if (m_isSelected) {
			if (isOwnedRole) {
				handleBtnEnable(enumShopItemCellBtnType.showConfirm);
			}
			else {
				handleBtnEnable(enumShopItemCellBtnType.showBuy);
			}
		}
		else {
			if (isOwnedRole) {
				handleBtnEnable(enumShopItemCellBtnType.none);
			}
			else {
				handleBtnEnable(enumShopItemCellBtnType.showBuy);
			}
		}
	}

	private void handleBtnEnable(enumShopItemCellBtnType type) {
		m_btnBuy.gameObject.SetActive (type == enumShopItemCellBtnType.showBuy);
		m_btnConfirm.gameObject.SetActive (type == enumShopItemCellBtnType.showConfirm);
	}

	private void handleTouch(Button btn) {
		if (btn == m_btnBuy) { 
			StrDatashop shopData = DataManager.getInstance().GetShopDataByIdx(m_shopIdx);
			if (PlayerManager.getInstance().GetPlayerInfo().score >= shopData.price ) {
				PlayerManager.getInstance().BuyRole(shopData.price , shopData.role_idx);
				DispatchManager.getInstance().onRefreshShopShow.Invoke();

				this.refreshShow();

				SoundsManager.getInstance().playSounds(SoundsManager.clipNameBuy);
			}
			else {
				SoundsManager.getInstance().playSounds(SoundsManager.clipNameClickNegtive);
			}
		}
		else if (btn == m_btnConfirm) {
			StrDatashop shopData = DataManager.getInstance().GetShopDataByIdx(m_shopIdx);
			PlayerManager.getInstance().GetPlayerInfo().currentRole = shopData.role_idx;
			PlayerManager.getInstance().GetPlayerInfo().saveToLocal();
			SceneManager.LoadScene("Menu");

			SoundsManager.getInstance().playSounds(SoundsManager.clipNameClick);
		}
	}
}
