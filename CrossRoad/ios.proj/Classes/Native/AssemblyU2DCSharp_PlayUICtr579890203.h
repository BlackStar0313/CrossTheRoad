#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// UnityEngine.UI.Text
struct Text_t356221433;
// UnityEngine.UI.Slider
struct Slider_t297367283;
// UnityEngine.UI.Button
struct Button_t2872111280;
// UnityEngine.UI.Image
struct Image_t2042527209;
// UnityEngine.GameObject
struct GameObject_t1756533147;
// UnityEngine.Camera
struct Camera_t189460977;
// UnityEngine.AudioSource
struct AudioSource_t1135106623;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// PlayUICtr
struct  PlayUICtr_t579890203  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.UI.Text PlayUICtr::m_textCoin
	Text_t356221433 * ___m_textCoin_2;
	// UnityEngine.UI.Slider PlayUICtr::m_Slider
	Slider_t297367283 * ___m_Slider_3;
	// UnityEngine.UI.Button PlayUICtr::m_pause
	Button_t2872111280 * ___m_pause_4;
	// UnityEngine.UI.Image PlayUICtr::m_heartImg
	Image_t2042527209 * ___m_heartImg_5;
	// UnityEngine.GameObject PlayUICtr::m_heart
	GameObject_t1756533147 * ___m_heart_6;
	// UnityEngine.Camera PlayUICtr::m_currentCamera
	Camera_t189460977 * ___m_currentCamera_7;
	// UnityEngine.Camera PlayUICtr::m_heartCamera
	Camera_t189460977 * ___m_heartCamera_8;
	// UnityEngine.UI.Image PlayUICtr::m_imgWarning
	Image_t2042527209 * ___m_imgWarning_9;
	// UnityEngine.AudioSource PlayUICtr::m_audioTimeout
	AudioSource_t1135106623 * ___m_audioTimeout_10;
	// System.Single PlayUICtr::m_decreaseTime
	float ___m_decreaseTime_11;
	// System.Single PlayUICtr::m_addStep
	float ___m_addStep_12;
	// System.Single PlayUICtr::m_randDist
	float ___m_randDist_13;
	// System.Int32 PlayUICtr::m_showScore
	int32_t ___m_showScore_14;
	// System.Single PlayUICtr::m_warningPercent
	float ___m_warningPercent_15;
	// System.Boolean PlayUICtr::m_isTimeout
	bool ___m_isTimeout_16;

public:
	inline static int32_t get_offset_of_m_textCoin_2() { return static_cast<int32_t>(offsetof(PlayUICtr_t579890203, ___m_textCoin_2)); }
	inline Text_t356221433 * get_m_textCoin_2() const { return ___m_textCoin_2; }
	inline Text_t356221433 ** get_address_of_m_textCoin_2() { return &___m_textCoin_2; }
	inline void set_m_textCoin_2(Text_t356221433 * value)
	{
		___m_textCoin_2 = value;
		Il2CppCodeGenWriteBarrier(&___m_textCoin_2, value);
	}

	inline static int32_t get_offset_of_m_Slider_3() { return static_cast<int32_t>(offsetof(PlayUICtr_t579890203, ___m_Slider_3)); }
	inline Slider_t297367283 * get_m_Slider_3() const { return ___m_Slider_3; }
	inline Slider_t297367283 ** get_address_of_m_Slider_3() { return &___m_Slider_3; }
	inline void set_m_Slider_3(Slider_t297367283 * value)
	{
		___m_Slider_3 = value;
		Il2CppCodeGenWriteBarrier(&___m_Slider_3, value);
	}

	inline static int32_t get_offset_of_m_pause_4() { return static_cast<int32_t>(offsetof(PlayUICtr_t579890203, ___m_pause_4)); }
	inline Button_t2872111280 * get_m_pause_4() const { return ___m_pause_4; }
	inline Button_t2872111280 ** get_address_of_m_pause_4() { return &___m_pause_4; }
	inline void set_m_pause_4(Button_t2872111280 * value)
	{
		___m_pause_4 = value;
		Il2CppCodeGenWriteBarrier(&___m_pause_4, value);
	}

	inline static int32_t get_offset_of_m_heartImg_5() { return static_cast<int32_t>(offsetof(PlayUICtr_t579890203, ___m_heartImg_5)); }
	inline Image_t2042527209 * get_m_heartImg_5() const { return ___m_heartImg_5; }
	inline Image_t2042527209 ** get_address_of_m_heartImg_5() { return &___m_heartImg_5; }
	inline void set_m_heartImg_5(Image_t2042527209 * value)
	{
		___m_heartImg_5 = value;
		Il2CppCodeGenWriteBarrier(&___m_heartImg_5, value);
	}

	inline static int32_t get_offset_of_m_heart_6() { return static_cast<int32_t>(offsetof(PlayUICtr_t579890203, ___m_heart_6)); }
	inline GameObject_t1756533147 * get_m_heart_6() const { return ___m_heart_6; }
	inline GameObject_t1756533147 ** get_address_of_m_heart_6() { return &___m_heart_6; }
	inline void set_m_heart_6(GameObject_t1756533147 * value)
	{
		___m_heart_6 = value;
		Il2CppCodeGenWriteBarrier(&___m_heart_6, value);
	}

	inline static int32_t get_offset_of_m_currentCamera_7() { return static_cast<int32_t>(offsetof(PlayUICtr_t579890203, ___m_currentCamera_7)); }
	inline Camera_t189460977 * get_m_currentCamera_7() const { return ___m_currentCamera_7; }
	inline Camera_t189460977 ** get_address_of_m_currentCamera_7() { return &___m_currentCamera_7; }
	inline void set_m_currentCamera_7(Camera_t189460977 * value)
	{
		___m_currentCamera_7 = value;
		Il2CppCodeGenWriteBarrier(&___m_currentCamera_7, value);
	}

	inline static int32_t get_offset_of_m_heartCamera_8() { return static_cast<int32_t>(offsetof(PlayUICtr_t579890203, ___m_heartCamera_8)); }
	inline Camera_t189460977 * get_m_heartCamera_8() const { return ___m_heartCamera_8; }
	inline Camera_t189460977 ** get_address_of_m_heartCamera_8() { return &___m_heartCamera_8; }
	inline void set_m_heartCamera_8(Camera_t189460977 * value)
	{
		___m_heartCamera_8 = value;
		Il2CppCodeGenWriteBarrier(&___m_heartCamera_8, value);
	}

	inline static int32_t get_offset_of_m_imgWarning_9() { return static_cast<int32_t>(offsetof(PlayUICtr_t579890203, ___m_imgWarning_9)); }
	inline Image_t2042527209 * get_m_imgWarning_9() const { return ___m_imgWarning_9; }
	inline Image_t2042527209 ** get_address_of_m_imgWarning_9() { return &___m_imgWarning_9; }
	inline void set_m_imgWarning_9(Image_t2042527209 * value)
	{
		___m_imgWarning_9 = value;
		Il2CppCodeGenWriteBarrier(&___m_imgWarning_9, value);
	}

	inline static int32_t get_offset_of_m_audioTimeout_10() { return static_cast<int32_t>(offsetof(PlayUICtr_t579890203, ___m_audioTimeout_10)); }
	inline AudioSource_t1135106623 * get_m_audioTimeout_10() const { return ___m_audioTimeout_10; }
	inline AudioSource_t1135106623 ** get_address_of_m_audioTimeout_10() { return &___m_audioTimeout_10; }
	inline void set_m_audioTimeout_10(AudioSource_t1135106623 * value)
	{
		___m_audioTimeout_10 = value;
		Il2CppCodeGenWriteBarrier(&___m_audioTimeout_10, value);
	}

	inline static int32_t get_offset_of_m_decreaseTime_11() { return static_cast<int32_t>(offsetof(PlayUICtr_t579890203, ___m_decreaseTime_11)); }
	inline float get_m_decreaseTime_11() const { return ___m_decreaseTime_11; }
	inline float* get_address_of_m_decreaseTime_11() { return &___m_decreaseTime_11; }
	inline void set_m_decreaseTime_11(float value)
	{
		___m_decreaseTime_11 = value;
	}

	inline static int32_t get_offset_of_m_addStep_12() { return static_cast<int32_t>(offsetof(PlayUICtr_t579890203, ___m_addStep_12)); }
	inline float get_m_addStep_12() const { return ___m_addStep_12; }
	inline float* get_address_of_m_addStep_12() { return &___m_addStep_12; }
	inline void set_m_addStep_12(float value)
	{
		___m_addStep_12 = value;
	}

	inline static int32_t get_offset_of_m_randDist_13() { return static_cast<int32_t>(offsetof(PlayUICtr_t579890203, ___m_randDist_13)); }
	inline float get_m_randDist_13() const { return ___m_randDist_13; }
	inline float* get_address_of_m_randDist_13() { return &___m_randDist_13; }
	inline void set_m_randDist_13(float value)
	{
		___m_randDist_13 = value;
	}

	inline static int32_t get_offset_of_m_showScore_14() { return static_cast<int32_t>(offsetof(PlayUICtr_t579890203, ___m_showScore_14)); }
	inline int32_t get_m_showScore_14() const { return ___m_showScore_14; }
	inline int32_t* get_address_of_m_showScore_14() { return &___m_showScore_14; }
	inline void set_m_showScore_14(int32_t value)
	{
		___m_showScore_14 = value;
	}

	inline static int32_t get_offset_of_m_warningPercent_15() { return static_cast<int32_t>(offsetof(PlayUICtr_t579890203, ___m_warningPercent_15)); }
	inline float get_m_warningPercent_15() const { return ___m_warningPercent_15; }
	inline float* get_address_of_m_warningPercent_15() { return &___m_warningPercent_15; }
	inline void set_m_warningPercent_15(float value)
	{
		___m_warningPercent_15 = value;
	}

	inline static int32_t get_offset_of_m_isTimeout_16() { return static_cast<int32_t>(offsetof(PlayUICtr_t579890203, ___m_isTimeout_16)); }
	inline bool get_m_isTimeout_16() const { return ___m_isTimeout_16; }
	inline bool* get_address_of_m_isTimeout_16() { return &___m_isTimeout_16; }
	inline void set_m_isTimeout_16(bool value)
	{
		___m_isTimeout_16 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
