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




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// PauseLayerCtr
struct  PauseLayerCtr_t3643614606  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.UI.Button PauseLayerCtr::m_btnContinue
	Button_t2872111280 * ___m_btnContinue_2;
	// UnityEngine.UI.Button PauseLayerCtr::m_btnHome
	Button_t2872111280 * ___m_btnHome_3;

public:
	inline static int32_t get_offset_of_m_btnContinue_2() { return static_cast<int32_t>(offsetof(PauseLayerCtr_t3643614606, ___m_btnContinue_2)); }
	inline Button_t2872111280 * get_m_btnContinue_2() const { return ___m_btnContinue_2; }
	inline Button_t2872111280 ** get_address_of_m_btnContinue_2() { return &___m_btnContinue_2; }
	inline void set_m_btnContinue_2(Button_t2872111280 * value)
	{
		___m_btnContinue_2 = value;
		Il2CppCodeGenWriteBarrier(&___m_btnContinue_2, value);
	}

	inline static int32_t get_offset_of_m_btnHome_3() { return static_cast<int32_t>(offsetof(PauseLayerCtr_t3643614606, ___m_btnHome_3)); }
	inline Button_t2872111280 * get_m_btnHome_3() const { return ___m_btnHome_3; }
	inline Button_t2872111280 ** get_address_of_m_btnHome_3() { return &___m_btnHome_3; }
	inline void set_m_btnHome_3(Button_t2872111280 * value)
	{
		___m_btnHome_3 = value;
		Il2CppCodeGenWriteBarrier(&___m_btnHome_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
