#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// UnityEngine.UI.Button
struct Button_t2872111280;
// UnityEngine.UI.Text
struct Text_t356221433;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// ShopUICtr
struct  ShopUICtr_t2388324231  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.UI.Button ShopUICtr::m_btnHome
	Button_t2872111280 * ___m_btnHome_2;
	// UnityEngine.UI.Text ShopUICtr::m_textScore
	Text_t356221433 * ___m_textScore_3;

public:
	inline static int32_t get_offset_of_m_btnHome_2() { return static_cast<int32_t>(offsetof(ShopUICtr_t2388324231, ___m_btnHome_2)); }
	inline Button_t2872111280 * get_m_btnHome_2() const { return ___m_btnHome_2; }
	inline Button_t2872111280 ** get_address_of_m_btnHome_2() { return &___m_btnHome_2; }
	inline void set_m_btnHome_2(Button_t2872111280 * value)
	{
		___m_btnHome_2 = value;
		Il2CppCodeGenWriteBarrier(&___m_btnHome_2, value);
	}

	inline static int32_t get_offset_of_m_textScore_3() { return static_cast<int32_t>(offsetof(ShopUICtr_t2388324231, ___m_textScore_3)); }
	inline Text_t356221433 * get_m_textScore_3() const { return ___m_textScore_3; }
	inline Text_t356221433 ** get_address_of_m_textScore_3() { return &___m_textScore_3; }
	inline void set_m_textScore_3(Text_t356221433 * value)
	{
		___m_textScore_3 = value;
		Il2CppCodeGenWriteBarrier(&___m_textScore_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
