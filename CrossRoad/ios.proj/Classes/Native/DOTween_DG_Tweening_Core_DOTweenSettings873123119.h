#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_ScriptableObject1975622470.h"
#include "DOTween_DG_Tweening_LogBehaviour3505725029.h"
#include "DOTween_DG_Tweening_AutoPlay2503223703.h"
#include "DOTween_DG_Tweening_UpdateType3357224513.h"
#include "DOTween_DG_Tweening_Ease2502520296.h"
#include "DOTween_DG_Tweening_LoopType2249218064.h"
#include "DOTween_DG_Tweening_Core_DOTweenSettings_SettingsLo514961325.h"

// System.String
struct String_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// DG.Tweening.Core.DOTweenSettings
struct  DOTweenSettings_t873123119  : public ScriptableObject_t1975622470
{
public:
	// System.Boolean DG.Tweening.Core.DOTweenSettings::useSafeMode
	bool ___useSafeMode_3;
	// System.Single DG.Tweening.Core.DOTweenSettings::timeScale
	float ___timeScale_4;
	// System.Boolean DG.Tweening.Core.DOTweenSettings::useSmoothDeltaTime
	bool ___useSmoothDeltaTime_5;
	// System.Single DG.Tweening.Core.DOTweenSettings::maxSmoothUnscaledTime
	float ___maxSmoothUnscaledTime_6;
	// System.Boolean DG.Tweening.Core.DOTweenSettings::showUnityEditorReport
	bool ___showUnityEditorReport_7;
	// DG.Tweening.LogBehaviour DG.Tweening.Core.DOTweenSettings::logBehaviour
	int32_t ___logBehaviour_8;
	// System.Boolean DG.Tweening.Core.DOTweenSettings::drawGizmos
	bool ___drawGizmos_9;
	// System.Boolean DG.Tweening.Core.DOTweenSettings::defaultRecyclable
	bool ___defaultRecyclable_10;
	// DG.Tweening.AutoPlay DG.Tweening.Core.DOTweenSettings::defaultAutoPlay
	int32_t ___defaultAutoPlay_11;
	// DG.Tweening.UpdateType DG.Tweening.Core.DOTweenSettings::defaultUpdateType
	int32_t ___defaultUpdateType_12;
	// System.Boolean DG.Tweening.Core.DOTweenSettings::defaultTimeScaleIndependent
	bool ___defaultTimeScaleIndependent_13;
	// DG.Tweening.Ease DG.Tweening.Core.DOTweenSettings::defaultEaseType
	int32_t ___defaultEaseType_14;
	// System.Single DG.Tweening.Core.DOTweenSettings::defaultEaseOvershootOrAmplitude
	float ___defaultEaseOvershootOrAmplitude_15;
	// System.Single DG.Tweening.Core.DOTweenSettings::defaultEasePeriod
	float ___defaultEasePeriod_16;
	// System.Boolean DG.Tweening.Core.DOTweenSettings::defaultAutoKill
	bool ___defaultAutoKill_17;
	// DG.Tweening.LoopType DG.Tweening.Core.DOTweenSettings::defaultLoopType
	int32_t ___defaultLoopType_18;
	// DG.Tweening.Core.DOTweenSettings/SettingsLocation DG.Tweening.Core.DOTweenSettings::storeSettingsLocation
	int32_t ___storeSettingsLocation_19;

public:
	inline static int32_t get_offset_of_useSafeMode_3() { return static_cast<int32_t>(offsetof(DOTweenSettings_t873123119, ___useSafeMode_3)); }
	inline bool get_useSafeMode_3() const { return ___useSafeMode_3; }
	inline bool* get_address_of_useSafeMode_3() { return &___useSafeMode_3; }
	inline void set_useSafeMode_3(bool value)
	{
		___useSafeMode_3 = value;
	}

	inline static int32_t get_offset_of_timeScale_4() { return static_cast<int32_t>(offsetof(DOTweenSettings_t873123119, ___timeScale_4)); }
	inline float get_timeScale_4() const { return ___timeScale_4; }
	inline float* get_address_of_timeScale_4() { return &___timeScale_4; }
	inline void set_timeScale_4(float value)
	{
		___timeScale_4 = value;
	}

	inline static int32_t get_offset_of_useSmoothDeltaTime_5() { return static_cast<int32_t>(offsetof(DOTweenSettings_t873123119, ___useSmoothDeltaTime_5)); }
	inline bool get_useSmoothDeltaTime_5() const { return ___useSmoothDeltaTime_5; }
	inline bool* get_address_of_useSmoothDeltaTime_5() { return &___useSmoothDeltaTime_5; }
	inline void set_useSmoothDeltaTime_5(bool value)
	{
		___useSmoothDeltaTime_5 = value;
	}

	inline static int32_t get_offset_of_maxSmoothUnscaledTime_6() { return static_cast<int32_t>(offsetof(DOTweenSettings_t873123119, ___maxSmoothUnscaledTime_6)); }
	inline float get_maxSmoothUnscaledTime_6() const { return ___maxSmoothUnscaledTime_6; }
	inline float* get_address_of_maxSmoothUnscaledTime_6() { return &___maxSmoothUnscaledTime_6; }
	inline void set_maxSmoothUnscaledTime_6(float value)
	{
		___maxSmoothUnscaledTime_6 = value;
	}

	inline static int32_t get_offset_of_showUnityEditorReport_7() { return static_cast<int32_t>(offsetof(DOTweenSettings_t873123119, ___showUnityEditorReport_7)); }
	inline bool get_showUnityEditorReport_7() const { return ___showUnityEditorReport_7; }
	inline bool* get_address_of_showUnityEditorReport_7() { return &___showUnityEditorReport_7; }
	inline void set_showUnityEditorReport_7(bool value)
	{
		___showUnityEditorReport_7 = value;
	}

	inline static int32_t get_offset_of_logBehaviour_8() { return static_cast<int32_t>(offsetof(DOTweenSettings_t873123119, ___logBehaviour_8)); }
	inline int32_t get_logBehaviour_8() const { return ___logBehaviour_8; }
	inline int32_t* get_address_of_logBehaviour_8() { return &___logBehaviour_8; }
	inline void set_logBehaviour_8(int32_t value)
	{
		___logBehaviour_8 = value;
	}

	inline static int32_t get_offset_of_drawGizmos_9() { return static_cast<int32_t>(offsetof(DOTweenSettings_t873123119, ___drawGizmos_9)); }
	inline bool get_drawGizmos_9() const { return ___drawGizmos_9; }
	inline bool* get_address_of_drawGizmos_9() { return &___drawGizmos_9; }
	inline void set_drawGizmos_9(bool value)
	{
		___drawGizmos_9 = value;
	}

	inline static int32_t get_offset_of_defaultRecyclable_10() { return static_cast<int32_t>(offsetof(DOTweenSettings_t873123119, ___defaultRecyclable_10)); }
	inline bool get_defaultRecyclable_10() const { return ___defaultRecyclable_10; }
	inline bool* get_address_of_defaultRecyclable_10() { return &___defaultRecyclable_10; }
	inline void set_defaultRecyclable_10(bool value)
	{
		___defaultRecyclable_10 = value;
	}

	inline static int32_t get_offset_of_defaultAutoPlay_11() { return static_cast<int32_t>(offsetof(DOTweenSettings_t873123119, ___defaultAutoPlay_11)); }
	inline int32_t get_defaultAutoPlay_11() const { return ___defaultAutoPlay_11; }
	inline int32_t* get_address_of_defaultAutoPlay_11() { return &___defaultAutoPlay_11; }
	inline void set_defaultAutoPlay_11(int32_t value)
	{
		___defaultAutoPlay_11 = value;
	}

	inline static int32_t get_offset_of_defaultUpdateType_12() { return static_cast<int32_t>(offsetof(DOTweenSettings_t873123119, ___defaultUpdateType_12)); }
	inline int32_t get_defaultUpdateType_12() const { return ___defaultUpdateType_12; }
	inline int32_t* get_address_of_defaultUpdateType_12() { return &___defaultUpdateType_12; }
	inline void set_defaultUpdateType_12(int32_t value)
	{
		___defaultUpdateType_12 = value;
	}

	inline static int32_t get_offset_of_defaultTimeScaleIndependent_13() { return static_cast<int32_t>(offsetof(DOTweenSettings_t873123119, ___defaultTimeScaleIndependent_13)); }
	inline bool get_defaultTimeScaleIndependent_13() const { return ___defaultTimeScaleIndependent_13; }
	inline bool* get_address_of_defaultTimeScaleIndependent_13() { return &___defaultTimeScaleIndependent_13; }
	inline void set_defaultTimeScaleIndependent_13(bool value)
	{
		___defaultTimeScaleIndependent_13 = value;
	}

	inline static int32_t get_offset_of_defaultEaseType_14() { return static_cast<int32_t>(offsetof(DOTweenSettings_t873123119, ___defaultEaseType_14)); }
	inline int32_t get_defaultEaseType_14() const { return ___defaultEaseType_14; }
	inline int32_t* get_address_of_defaultEaseType_14() { return &___defaultEaseType_14; }
	inline void set_defaultEaseType_14(int32_t value)
	{
		___defaultEaseType_14 = value;
	}

	inline static int32_t get_offset_of_defaultEaseOvershootOrAmplitude_15() { return static_cast<int32_t>(offsetof(DOTweenSettings_t873123119, ___defaultEaseOvershootOrAmplitude_15)); }
	inline float get_defaultEaseOvershootOrAmplitude_15() const { return ___defaultEaseOvershootOrAmplitude_15; }
	inline float* get_address_of_defaultEaseOvershootOrAmplitude_15() { return &___defaultEaseOvershootOrAmplitude_15; }
	inline void set_defaultEaseOvershootOrAmplitude_15(float value)
	{
		___defaultEaseOvershootOrAmplitude_15 = value;
	}

	inline static int32_t get_offset_of_defaultEasePeriod_16() { return static_cast<int32_t>(offsetof(DOTweenSettings_t873123119, ___defaultEasePeriod_16)); }
	inline float get_defaultEasePeriod_16() const { return ___defaultEasePeriod_16; }
	inline float* get_address_of_defaultEasePeriod_16() { return &___defaultEasePeriod_16; }
	inline void set_defaultEasePeriod_16(float value)
	{
		___defaultEasePeriod_16 = value;
	}

	inline static int32_t get_offset_of_defaultAutoKill_17() { return static_cast<int32_t>(offsetof(DOTweenSettings_t873123119, ___defaultAutoKill_17)); }
	inline bool get_defaultAutoKill_17() const { return ___defaultAutoKill_17; }
	inline bool* get_address_of_defaultAutoKill_17() { return &___defaultAutoKill_17; }
	inline void set_defaultAutoKill_17(bool value)
	{
		___defaultAutoKill_17 = value;
	}

	inline static int32_t get_offset_of_defaultLoopType_18() { return static_cast<int32_t>(offsetof(DOTweenSettings_t873123119, ___defaultLoopType_18)); }
	inline int32_t get_defaultLoopType_18() const { return ___defaultLoopType_18; }
	inline int32_t* get_address_of_defaultLoopType_18() { return &___defaultLoopType_18; }
	inline void set_defaultLoopType_18(int32_t value)
	{
		___defaultLoopType_18 = value;
	}

	inline static int32_t get_offset_of_storeSettingsLocation_19() { return static_cast<int32_t>(offsetof(DOTweenSettings_t873123119, ___storeSettingsLocation_19)); }
	inline int32_t get_storeSettingsLocation_19() const { return ___storeSettingsLocation_19; }
	inline int32_t* get_address_of_storeSettingsLocation_19() { return &___storeSettingsLocation_19; }
	inline void set_storeSettingsLocation_19(int32_t value)
	{
		___storeSettingsLocation_19 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
