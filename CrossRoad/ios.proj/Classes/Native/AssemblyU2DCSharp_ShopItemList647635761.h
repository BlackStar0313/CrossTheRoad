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
// UnityEngine.Transform
struct Transform_t3275118058;
// StrDatashop[]
struct StrDatashopU5BU5D_t2052734670;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// ShopItemList
struct  ShopItemList_t647635761  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.GameObject ShopItemList::m_ItemCell
	GameObject_t1756533147 * ___m_ItemCell_2;
	// UnityEngine.Transform ShopItemList::m_content
	Transform_t3275118058 * ___m_content_3;
	// StrDatashop[] ShopItemList::m_ShopData
	StrDatashopU5BU5D_t2052734670* ___m_ShopData_4;

public:
	inline static int32_t get_offset_of_m_ItemCell_2() { return static_cast<int32_t>(offsetof(ShopItemList_t647635761, ___m_ItemCell_2)); }
	inline GameObject_t1756533147 * get_m_ItemCell_2() const { return ___m_ItemCell_2; }
	inline GameObject_t1756533147 ** get_address_of_m_ItemCell_2() { return &___m_ItemCell_2; }
	inline void set_m_ItemCell_2(GameObject_t1756533147 * value)
	{
		___m_ItemCell_2 = value;
		Il2CppCodeGenWriteBarrier(&___m_ItemCell_2, value);
	}

	inline static int32_t get_offset_of_m_content_3() { return static_cast<int32_t>(offsetof(ShopItemList_t647635761, ___m_content_3)); }
	inline Transform_t3275118058 * get_m_content_3() const { return ___m_content_3; }
	inline Transform_t3275118058 ** get_address_of_m_content_3() { return &___m_content_3; }
	inline void set_m_content_3(Transform_t3275118058 * value)
	{
		___m_content_3 = value;
		Il2CppCodeGenWriteBarrier(&___m_content_3, value);
	}

	inline static int32_t get_offset_of_m_ShopData_4() { return static_cast<int32_t>(offsetof(ShopItemList_t647635761, ___m_ShopData_4)); }
	inline StrDatashopU5BU5D_t2052734670* get_m_ShopData_4() const { return ___m_ShopData_4; }
	inline StrDatashopU5BU5D_t2052734670** get_address_of_m_ShopData_4() { return &___m_ShopData_4; }
	inline void set_m_ShopData_4(StrDatashopU5BU5D_t2052734670* value)
	{
		___m_ShopData_4 = value;
		Il2CppCodeGenWriteBarrier(&___m_ShopData_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
