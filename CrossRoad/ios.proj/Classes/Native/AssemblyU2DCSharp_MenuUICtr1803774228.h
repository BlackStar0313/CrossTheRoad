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
// DG.Tweening.TweenCallback
struct TweenCallback_t3697142134;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// MenuUICtr
struct  MenuUICtr_t1803774228  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.UI.Button MenuUICtr::m_btnStart
	Button_t2872111280 * ___m_btnStart_2;
	// UnityEngine.UI.Button MenuUICtr::m_btnShop
	Button_t2872111280 * ___m_btnShop_3;
	// System.Single MenuUICtr::m_fadeTime
	float ___m_fadeTime_4;

public:
	inline static int32_t get_offset_of_m_btnStart_2() { return static_cast<int32_t>(offsetof(MenuUICtr_t1803774228, ___m_btnStart_2)); }
	inline Button_t2872111280 * get_m_btnStart_2() const { return ___m_btnStart_2; }
	inline Button_t2872111280 ** get_address_of_m_btnStart_2() { return &___m_btnStart_2; }
	inline void set_m_btnStart_2(Button_t2872111280 * value)
	{
		___m_btnStart_2 = value;
		Il2CppCodeGenWriteBarrier(&___m_btnStart_2, value);
	}

	inline static int32_t get_offset_of_m_btnShop_3() { return static_cast<int32_t>(offsetof(MenuUICtr_t1803774228, ___m_btnShop_3)); }
	inline Button_t2872111280 * get_m_btnShop_3() const { return ___m_btnShop_3; }
	inline Button_t2872111280 ** get_address_of_m_btnShop_3() { return &___m_btnShop_3; }
	inline void set_m_btnShop_3(Button_t2872111280 * value)
	{
		___m_btnShop_3 = value;
		Il2CppCodeGenWriteBarrier(&___m_btnShop_3, value);
	}

	inline static int32_t get_offset_of_m_fadeTime_4() { return static_cast<int32_t>(offsetof(MenuUICtr_t1803774228, ___m_fadeTime_4)); }
	inline float get_m_fadeTime_4() const { return ___m_fadeTime_4; }
	inline float* get_address_of_m_fadeTime_4() { return &___m_fadeTime_4; }
	inline void set_m_fadeTime_4(float value)
	{
		___m_fadeTime_4 = value;
	}
};

struct MenuUICtr_t1803774228_StaticFields
{
public:
	// DG.Tweening.TweenCallback MenuUICtr::<>f__am$cache0
	TweenCallback_t3697142134 * ___U3CU3Ef__amU24cache0_5;

public:
	inline static int32_t get_offset_of_U3CU3Ef__amU24cache0_5() { return static_cast<int32_t>(offsetof(MenuUICtr_t1803774228_StaticFields, ___U3CU3Ef__amU24cache0_5)); }
	inline TweenCallback_t3697142134 * get_U3CU3Ef__amU24cache0_5() const { return ___U3CU3Ef__amU24cache0_5; }
	inline TweenCallback_t3697142134 ** get_address_of_U3CU3Ef__amU24cache0_5() { return &___U3CU3Ef__amU24cache0_5; }
	inline void set_U3CU3Ef__amU24cache0_5(TweenCallback_t3697142134 * value)
	{
		___U3CU3Ef__amU24cache0_5 = value;
		Il2CppCodeGenWriteBarrier(&___U3CU3Ef__amU24cache0_5, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
