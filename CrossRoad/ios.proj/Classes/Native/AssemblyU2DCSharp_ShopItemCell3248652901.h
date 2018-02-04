#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// UnityEngine.GameObject
struct GameObject_t1756533147;
// UnityEngine.UI.Text
struct Text_t356221433;
// UnityEngine.UI.Image
struct Image_t2042527209;
// UnityEngine.UI.Button
struct Button_t2872111280;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// ShopItemCell
struct  ShopItemCell_t3248652901  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.GameObject ShopItemCell::m_itemPlayer
	GameObject_t1756533147 * ___m_itemPlayer_2;
	// UnityEngine.UI.Text ShopItemCell::m_textPrice
	Text_t356221433 * ___m_textPrice_3;
	// UnityEngine.UI.Image ShopItemCell::m_imgRect
	Image_t2042527209 * ___m_imgRect_4;
	// UnityEngine.UI.Button ShopItemCell::m_btnBuy
	Button_t2872111280 * ___m_btnBuy_5;
	// UnityEngine.UI.Button ShopItemCell::m_btnConfirm
	Button_t2872111280 * ___m_btnConfirm_6;
	// UnityEngine.UI.Button ShopItemCell::m_btnAds
	Button_t2872111280 * ___m_btnAds_7;
	// System.Int32 ShopItemCell::m_shopIdx
	int32_t ___m_shopIdx_8;
	// System.Boolean ShopItemCell::m_isSelected
	bool ___m_isSelected_9;

public:
	inline static int32_t get_offset_of_m_itemPlayer_2() { return static_cast<int32_t>(offsetof(ShopItemCell_t3248652901, ___m_itemPlayer_2)); }
	inline GameObject_t1756533147 * get_m_itemPlayer_2() const { return ___m_itemPlayer_2; }
	inline GameObject_t1756533147 ** get_address_of_m_itemPlayer_2() { return &___m_itemPlayer_2; }
	inline void set_m_itemPlayer_2(GameObject_t1756533147 * value)
	{
		___m_itemPlayer_2 = value;
		Il2CppCodeGenWriteBarrier(&___m_itemPlayer_2, value);
	}

	inline static int32_t get_offset_of_m_textPrice_3() { return static_cast<int32_t>(offsetof(ShopItemCell_t3248652901, ___m_textPrice_3)); }
	inline Text_t356221433 * get_m_textPrice_3() const { return ___m_textPrice_3; }
	inline Text_t356221433 ** get_address_of_m_textPrice_3() { return &___m_textPrice_3; }
	inline void set_m_textPrice_3(Text_t356221433 * value)
	{
		___m_textPrice_3 = value;
		Il2CppCodeGenWriteBarrier(&___m_textPrice_3, value);
	}

	inline static int32_t get_offset_of_m_imgRect_4() { return static_cast<int32_t>(offsetof(ShopItemCell_t3248652901, ___m_imgRect_4)); }
	inline Image_t2042527209 * get_m_imgRect_4() const { return ___m_imgRect_4; }
	inline Image_t2042527209 ** get_address_of_m_imgRect_4() { return &___m_imgRect_4; }
	inline void set_m_imgRect_4(Image_t2042527209 * value)
	{
		___m_imgRect_4 = value;
		Il2CppCodeGenWriteBarrier(&___m_imgRect_4, value);
	}

	inline static int32_t get_offset_of_m_btnBuy_5() { return static_cast<int32_t>(offsetof(ShopItemCell_t3248652901, ___m_btnBuy_5)); }
	inline Button_t2872111280 * get_m_btnBuy_5() const { return ___m_btnBuy_5; }
	inline Button_t2872111280 ** get_address_of_m_btnBuy_5() { return &___m_btnBuy_5; }
	inline void set_m_btnBuy_5(Button_t2872111280 * value)
	{
		___m_btnBuy_5 = value;
		Il2CppCodeGenWriteBarrier(&___m_btnBuy_5, value);
	}

	inline static int32_t get_offset_of_m_btnConfirm_6() { return static_cast<int32_t>(offsetof(ShopItemCell_t3248652901, ___m_btnConfirm_6)); }
	inline Button_t2872111280 * get_m_btnConfirm_6() const { return ___m_btnConfirm_6; }
	inline Button_t2872111280 ** get_address_of_m_btnConfirm_6() { return &___m_btnConfirm_6; }
	inline void set_m_btnConfirm_6(Button_t2872111280 * value)
	{
		___m_btnConfirm_6 = value;
		Il2CppCodeGenWriteBarrier(&___m_btnConfirm_6, value);
	}

	inline static int32_t get_offset_of_m_btnAds_7() { return static_cast<int32_t>(offsetof(ShopItemCell_t3248652901, ___m_btnAds_7)); }
	inline Button_t2872111280 * get_m_btnAds_7() const { return ___m_btnAds_7; }
	inline Button_t2872111280 ** get_address_of_m_btnAds_7() { return &___m_btnAds_7; }
	inline void set_m_btnAds_7(Button_t2872111280 * value)
	{
		___m_btnAds_7 = value;
		Il2CppCodeGenWriteBarrier(&___m_btnAds_7, value);
	}

	inline static int32_t get_offset_of_m_shopIdx_8() { return static_cast<int32_t>(offsetof(ShopItemCell_t3248652901, ___m_shopIdx_8)); }
	inline int32_t get_m_shopIdx_8() const { return ___m_shopIdx_8; }
	inline int32_t* get_address_of_m_shopIdx_8() { return &___m_shopIdx_8; }
	inline void set_m_shopIdx_8(int32_t value)
	{
		___m_shopIdx_8 = value;
	}

	inline static int32_t get_offset_of_m_isSelected_9() { return static_cast<int32_t>(offsetof(ShopItemCell_t3248652901, ___m_isSelected_9)); }
	inline bool get_m_isSelected_9() const { return ___m_isSelected_9; }
	inline bool* get_address_of_m_isSelected_9() { return &___m_isSelected_9; }
	inline void set_m_isSelected_9(bool value)
	{
		___m_isSelected_9 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
