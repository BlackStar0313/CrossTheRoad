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
// UnityEngine.GameObject
struct GameObject_t1756533147;
// MenuRole
struct MenuRole_t4079412605;
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
	// UnityEngine.UI.Button MenuUICtr::m_btnSetting
	Button_t2872111280 * ___m_btnSetting_4;
	// UnityEngine.UI.Text MenuUICtr::m_textBest
	Text_t356221433 * ___m_textBest_5;
	// UnityEngine.UI.Text MenuUICtr::m_textCurrent
	Text_t356221433 * ___m_textCurrent_6;
	// UnityEngine.GameObject MenuUICtr::m_groupScore
	GameObject_t1756533147 * ___m_groupScore_7;
	// MenuRole MenuUICtr::m_role
	MenuRole_t4079412605 * ___m_role_8;
	// System.Single MenuUICtr::m_fadeTime
	float ___m_fadeTime_9;

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

	inline static int32_t get_offset_of_m_btnSetting_4() { return static_cast<int32_t>(offsetof(MenuUICtr_t1803774228, ___m_btnSetting_4)); }
	inline Button_t2872111280 * get_m_btnSetting_4() const { return ___m_btnSetting_4; }
	inline Button_t2872111280 ** get_address_of_m_btnSetting_4() { return &___m_btnSetting_4; }
	inline void set_m_btnSetting_4(Button_t2872111280 * value)
	{
		___m_btnSetting_4 = value;
		Il2CppCodeGenWriteBarrier(&___m_btnSetting_4, value);
	}

	inline static int32_t get_offset_of_m_textBest_5() { return static_cast<int32_t>(offsetof(MenuUICtr_t1803774228, ___m_textBest_5)); }
	inline Text_t356221433 * get_m_textBest_5() const { return ___m_textBest_5; }
	inline Text_t356221433 ** get_address_of_m_textBest_5() { return &___m_textBest_5; }
	inline void set_m_textBest_5(Text_t356221433 * value)
	{
		___m_textBest_5 = value;
		Il2CppCodeGenWriteBarrier(&___m_textBest_5, value);
	}

	inline static int32_t get_offset_of_m_textCurrent_6() { return static_cast<int32_t>(offsetof(MenuUICtr_t1803774228, ___m_textCurrent_6)); }
	inline Text_t356221433 * get_m_textCurrent_6() const { return ___m_textCurrent_6; }
	inline Text_t356221433 ** get_address_of_m_textCurrent_6() { return &___m_textCurrent_6; }
	inline void set_m_textCurrent_6(Text_t356221433 * value)
	{
		___m_textCurrent_6 = value;
		Il2CppCodeGenWriteBarrier(&___m_textCurrent_6, value);
	}

	inline static int32_t get_offset_of_m_groupScore_7() { return static_cast<int32_t>(offsetof(MenuUICtr_t1803774228, ___m_groupScore_7)); }
	inline GameObject_t1756533147 * get_m_groupScore_7() const { return ___m_groupScore_7; }
	inline GameObject_t1756533147 ** get_address_of_m_groupScore_7() { return &___m_groupScore_7; }
	inline void set_m_groupScore_7(GameObject_t1756533147 * value)
	{
		___m_groupScore_7 = value;
		Il2CppCodeGenWriteBarrier(&___m_groupScore_7, value);
	}

	inline static int32_t get_offset_of_m_role_8() { return static_cast<int32_t>(offsetof(MenuUICtr_t1803774228, ___m_role_8)); }
	inline MenuRole_t4079412605 * get_m_role_8() const { return ___m_role_8; }
	inline MenuRole_t4079412605 ** get_address_of_m_role_8() { return &___m_role_8; }
	inline void set_m_role_8(MenuRole_t4079412605 * value)
	{
		___m_role_8 = value;
		Il2CppCodeGenWriteBarrier(&___m_role_8, value);
	}

	inline static int32_t get_offset_of_m_fadeTime_9() { return static_cast<int32_t>(offsetof(MenuUICtr_t1803774228, ___m_fadeTime_9)); }
	inline float get_m_fadeTime_9() const { return ___m_fadeTime_9; }
	inline float* get_address_of_m_fadeTime_9() { return &___m_fadeTime_9; }
	inline void set_m_fadeTime_9(float value)
	{
		___m_fadeTime_9 = value;
	}
};

struct MenuUICtr_t1803774228_StaticFields
{
public:
	// DG.Tweening.TweenCallback MenuUICtr::<>f__am$cache0
	TweenCallback_t3697142134 * ___U3CU3Ef__amU24cache0_10;

public:
	inline static int32_t get_offset_of_U3CU3Ef__amU24cache0_10() { return static_cast<int32_t>(offsetof(MenuUICtr_t1803774228_StaticFields, ___U3CU3Ef__amU24cache0_10)); }
	inline TweenCallback_t3697142134 * get_U3CU3Ef__amU24cache0_10() const { return ___U3CU3Ef__amU24cache0_10; }
	inline TweenCallback_t3697142134 ** get_address_of_U3CU3Ef__amU24cache0_10() { return &___U3CU3Ef__amU24cache0_10; }
	inline void set_U3CU3Ef__amU24cache0_10(TweenCallback_t3697142134 * value)
	{
		___U3CU3Ef__amU24cache0_10 = value;
		Il2CppCodeGenWriteBarrier(&___U3CU3Ef__amU24cache0_10, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
