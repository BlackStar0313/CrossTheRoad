#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// System.String
struct String_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// ShopItemRole
struct  ShopItemRole_t560175195  : public MonoBehaviour_t1158329972
{
public:
	// System.String ShopItemRole::m_currentBodyName
	String_t* ___m_currentBodyName_2;
	// System.String ShopItemRole::m_currentHeadName
	String_t* ___m_currentHeadName_3;
	// System.String ShopItemRole::m_prefix
	String_t* ___m_prefix_4;

public:
	inline static int32_t get_offset_of_m_currentBodyName_2() { return static_cast<int32_t>(offsetof(ShopItemRole_t560175195, ___m_currentBodyName_2)); }
	inline String_t* get_m_currentBodyName_2() const { return ___m_currentBodyName_2; }
	inline String_t** get_address_of_m_currentBodyName_2() { return &___m_currentBodyName_2; }
	inline void set_m_currentBodyName_2(String_t* value)
	{
		___m_currentBodyName_2 = value;
		Il2CppCodeGenWriteBarrier(&___m_currentBodyName_2, value);
	}

	inline static int32_t get_offset_of_m_currentHeadName_3() { return static_cast<int32_t>(offsetof(ShopItemRole_t560175195, ___m_currentHeadName_3)); }
	inline String_t* get_m_currentHeadName_3() const { return ___m_currentHeadName_3; }
	inline String_t** get_address_of_m_currentHeadName_3() { return &___m_currentHeadName_3; }
	inline void set_m_currentHeadName_3(String_t* value)
	{
		___m_currentHeadName_3 = value;
		Il2CppCodeGenWriteBarrier(&___m_currentHeadName_3, value);
	}

	inline static int32_t get_offset_of_m_prefix_4() { return static_cast<int32_t>(offsetof(ShopItemRole_t560175195, ___m_prefix_4)); }
	inline String_t* get_m_prefix_4() const { return ___m_prefix_4; }
	inline String_t** get_address_of_m_prefix_4() { return &___m_prefix_4; }
	inline void set_m_prefix_4(String_t* value)
	{
		___m_prefix_4 = value;
		Il2CppCodeGenWriteBarrier(&___m_prefix_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
