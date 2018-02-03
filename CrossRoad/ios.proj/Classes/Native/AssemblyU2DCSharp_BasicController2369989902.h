﻿#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// UnityEngine.Animator
struct Animator_t69676727;
// UnityEngine.AudioSource
struct AudioSource_t1135106623;
// UnityEngine.AudioClip[]
struct AudioClipU5BU5D_t2203355011;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// BasicController
struct  BasicController_t2369989902  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.Animator BasicController::m_animator
	Animator_t69676727 * ___m_animator_2;
	// UnityEngine.AudioSource BasicController::m_audioSource
	AudioSource_t1135106623 * ___m_audioSource_3;
	// UnityEngine.AudioClip[] BasicController::m_audioWalk
	AudioClipU5BU5D_t2203355011* ___m_audioWalk_4;
	// UnityEngine.AudioClip[] BasicController::m_audioDead
	AudioClipU5BU5D_t2203355011* ___m_audioDead_5;

public:
	inline static int32_t get_offset_of_m_animator_2() { return static_cast<int32_t>(offsetof(BasicController_t2369989902, ___m_animator_2)); }
	inline Animator_t69676727 * get_m_animator_2() const { return ___m_animator_2; }
	inline Animator_t69676727 ** get_address_of_m_animator_2() { return &___m_animator_2; }
	inline void set_m_animator_2(Animator_t69676727 * value)
	{
		___m_animator_2 = value;
		Il2CppCodeGenWriteBarrier(&___m_animator_2, value);
	}

	inline static int32_t get_offset_of_m_audioSource_3() { return static_cast<int32_t>(offsetof(BasicController_t2369989902, ___m_audioSource_3)); }
	inline AudioSource_t1135106623 * get_m_audioSource_3() const { return ___m_audioSource_3; }
	inline AudioSource_t1135106623 ** get_address_of_m_audioSource_3() { return &___m_audioSource_3; }
	inline void set_m_audioSource_3(AudioSource_t1135106623 * value)
	{
		___m_audioSource_3 = value;
		Il2CppCodeGenWriteBarrier(&___m_audioSource_3, value);
	}

	inline static int32_t get_offset_of_m_audioWalk_4() { return static_cast<int32_t>(offsetof(BasicController_t2369989902, ___m_audioWalk_4)); }
	inline AudioClipU5BU5D_t2203355011* get_m_audioWalk_4() const { return ___m_audioWalk_4; }
	inline AudioClipU5BU5D_t2203355011** get_address_of_m_audioWalk_4() { return &___m_audioWalk_4; }
	inline void set_m_audioWalk_4(AudioClipU5BU5D_t2203355011* value)
	{
		___m_audioWalk_4 = value;
		Il2CppCodeGenWriteBarrier(&___m_audioWalk_4, value);
	}

	inline static int32_t get_offset_of_m_audioDead_5() { return static_cast<int32_t>(offsetof(BasicController_t2369989902, ___m_audioDead_5)); }
	inline AudioClipU5BU5D_t2203355011* get_m_audioDead_5() const { return ___m_audioDead_5; }
	inline AudioClipU5BU5D_t2203355011** get_address_of_m_audioDead_5() { return &___m_audioDead_5; }
	inline void set_m_audioDead_5(AudioClipU5BU5D_t2203355011* value)
	{
		___m_audioDead_5 = value;
		Il2CppCodeGenWriteBarrier(&___m_audioDead_5, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
