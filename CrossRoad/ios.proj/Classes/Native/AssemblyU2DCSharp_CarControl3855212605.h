#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "UnityEngine_UnityEngine_LayerMask3188175821.h"
#include "UnityEngine_UnityEngine_Vector32243707580.h"

// UnityEngine.AudioSource
struct AudioSource_t1135106623;
// UnityEngine.Transform
struct Transform_t3275118058;
// UnityEngine.Rigidbody
struct Rigidbody_t4233889191;
// UnityEngine.CapsuleCollider
struct CapsuleCollider_t720607407;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// CarControl
struct  CarControl_t3855212605  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.LayerMask CarControl::m_blockingLayer
	LayerMask_t3188175821  ___m_blockingLayer_2;
	// UnityEngine.AudioSource CarControl::m_audioSource
	AudioSource_t1135106623 * ___m_audioSource_3;
	// UnityEngine.Transform CarControl::<m_carStartPos>k__BackingField
	Transform_t3275118058 * ___U3Cm_carStartPosU3Ek__BackingField_4;
	// UnityEngine.Transform CarControl::<m_carEndPos>k__BackingField
	Transform_t3275118058 * ___U3Cm_carEndPosU3Ek__BackingField_5;
	// UnityEngine.Transform CarControl::<m_carPausePos>k__BackingField
	Transform_t3275118058 * ___U3Cm_carPausePosU3Ek__BackingField_6;
	// System.Single CarControl::m_moveSpeedRangeMax
	float ___m_moveSpeedRangeMax_7;
	// System.Single CarControl::m_moveSpeedRangeMin
	float ___m_moveSpeedRangeMin_8;
	// System.Single CarControl::m_moveSpeedAvg
	float ___m_moveSpeedAvg_9;
	// System.Single CarControl::m_moveSpeedCurrent
	float ___m_moveSpeedCurrent_10;
	// System.Single CarControl::m_acceleratedSpeedRangeMax
	float ___m_acceleratedSpeedRangeMax_11;
	// System.Single CarControl::m_acceleratedSpeedRangeMin
	float ___m_acceleratedSpeedRangeMin_12;
	// System.Single CarControl::m_acceleratedSpeedCurrent
	float ___m_acceleratedSpeedCurrent_13;
	// UnityEngine.Rigidbody CarControl::m_rigidBody
	Rigidbody_t4233889191 * ___m_rigidBody_14;
	// UnityEngine.CapsuleCollider CarControl::m_capsuleCollider
	CapsuleCollider_t720607407 * ___m_capsuleCollider_15;
	// System.Boolean CarControl::m_isMoving
	bool ___m_isMoving_16;
	// System.Single CarControl::m_RaycasthitDist
	float ___m_RaycasthitDist_17;
	// System.Single CarControl::m_puaseDist
	float ___m_puaseDist_18;
	// System.Boolean CarControl::m_isInit
	bool ___m_isInit_19;
	// UnityEngine.Vector3 CarControl::m_direction
	Vector3_t2243707580  ___m_direction_20;

public:
	inline static int32_t get_offset_of_m_blockingLayer_2() { return static_cast<int32_t>(offsetof(CarControl_t3855212605, ___m_blockingLayer_2)); }
	inline LayerMask_t3188175821  get_m_blockingLayer_2() const { return ___m_blockingLayer_2; }
	inline LayerMask_t3188175821 * get_address_of_m_blockingLayer_2() { return &___m_blockingLayer_2; }
	inline void set_m_blockingLayer_2(LayerMask_t3188175821  value)
	{
		___m_blockingLayer_2 = value;
	}

	inline static int32_t get_offset_of_m_audioSource_3() { return static_cast<int32_t>(offsetof(CarControl_t3855212605, ___m_audioSource_3)); }
	inline AudioSource_t1135106623 * get_m_audioSource_3() const { return ___m_audioSource_3; }
	inline AudioSource_t1135106623 ** get_address_of_m_audioSource_3() { return &___m_audioSource_3; }
	inline void set_m_audioSource_3(AudioSource_t1135106623 * value)
	{
		___m_audioSource_3 = value;
		Il2CppCodeGenWriteBarrier(&___m_audioSource_3, value);
	}

	inline static int32_t get_offset_of_U3Cm_carStartPosU3Ek__BackingField_4() { return static_cast<int32_t>(offsetof(CarControl_t3855212605, ___U3Cm_carStartPosU3Ek__BackingField_4)); }
	inline Transform_t3275118058 * get_U3Cm_carStartPosU3Ek__BackingField_4() const { return ___U3Cm_carStartPosU3Ek__BackingField_4; }
	inline Transform_t3275118058 ** get_address_of_U3Cm_carStartPosU3Ek__BackingField_4() { return &___U3Cm_carStartPosU3Ek__BackingField_4; }
	inline void set_U3Cm_carStartPosU3Ek__BackingField_4(Transform_t3275118058 * value)
	{
		___U3Cm_carStartPosU3Ek__BackingField_4 = value;
		Il2CppCodeGenWriteBarrier(&___U3Cm_carStartPosU3Ek__BackingField_4, value);
	}

	inline static int32_t get_offset_of_U3Cm_carEndPosU3Ek__BackingField_5() { return static_cast<int32_t>(offsetof(CarControl_t3855212605, ___U3Cm_carEndPosU3Ek__BackingField_5)); }
	inline Transform_t3275118058 * get_U3Cm_carEndPosU3Ek__BackingField_5() const { return ___U3Cm_carEndPosU3Ek__BackingField_5; }
	inline Transform_t3275118058 ** get_address_of_U3Cm_carEndPosU3Ek__BackingField_5() { return &___U3Cm_carEndPosU3Ek__BackingField_5; }
	inline void set_U3Cm_carEndPosU3Ek__BackingField_5(Transform_t3275118058 * value)
	{
		___U3Cm_carEndPosU3Ek__BackingField_5 = value;
		Il2CppCodeGenWriteBarrier(&___U3Cm_carEndPosU3Ek__BackingField_5, value);
	}

	inline static int32_t get_offset_of_U3Cm_carPausePosU3Ek__BackingField_6() { return static_cast<int32_t>(offsetof(CarControl_t3855212605, ___U3Cm_carPausePosU3Ek__BackingField_6)); }
	inline Transform_t3275118058 * get_U3Cm_carPausePosU3Ek__BackingField_6() const { return ___U3Cm_carPausePosU3Ek__BackingField_6; }
	inline Transform_t3275118058 ** get_address_of_U3Cm_carPausePosU3Ek__BackingField_6() { return &___U3Cm_carPausePosU3Ek__BackingField_6; }
	inline void set_U3Cm_carPausePosU3Ek__BackingField_6(Transform_t3275118058 * value)
	{
		___U3Cm_carPausePosU3Ek__BackingField_6 = value;
		Il2CppCodeGenWriteBarrier(&___U3Cm_carPausePosU3Ek__BackingField_6, value);
	}

	inline static int32_t get_offset_of_m_moveSpeedRangeMax_7() { return static_cast<int32_t>(offsetof(CarControl_t3855212605, ___m_moveSpeedRangeMax_7)); }
	inline float get_m_moveSpeedRangeMax_7() const { return ___m_moveSpeedRangeMax_7; }
	inline float* get_address_of_m_moveSpeedRangeMax_7() { return &___m_moveSpeedRangeMax_7; }
	inline void set_m_moveSpeedRangeMax_7(float value)
	{
		___m_moveSpeedRangeMax_7 = value;
	}

	inline static int32_t get_offset_of_m_moveSpeedRangeMin_8() { return static_cast<int32_t>(offsetof(CarControl_t3855212605, ___m_moveSpeedRangeMin_8)); }
	inline float get_m_moveSpeedRangeMin_8() const { return ___m_moveSpeedRangeMin_8; }
	inline float* get_address_of_m_moveSpeedRangeMin_8() { return &___m_moveSpeedRangeMin_8; }
	inline void set_m_moveSpeedRangeMin_8(float value)
	{
		___m_moveSpeedRangeMin_8 = value;
	}

	inline static int32_t get_offset_of_m_moveSpeedAvg_9() { return static_cast<int32_t>(offsetof(CarControl_t3855212605, ___m_moveSpeedAvg_9)); }
	inline float get_m_moveSpeedAvg_9() const { return ___m_moveSpeedAvg_9; }
	inline float* get_address_of_m_moveSpeedAvg_9() { return &___m_moveSpeedAvg_9; }
	inline void set_m_moveSpeedAvg_9(float value)
	{
		___m_moveSpeedAvg_9 = value;
	}

	inline static int32_t get_offset_of_m_moveSpeedCurrent_10() { return static_cast<int32_t>(offsetof(CarControl_t3855212605, ___m_moveSpeedCurrent_10)); }
	inline float get_m_moveSpeedCurrent_10() const { return ___m_moveSpeedCurrent_10; }
	inline float* get_address_of_m_moveSpeedCurrent_10() { return &___m_moveSpeedCurrent_10; }
	inline void set_m_moveSpeedCurrent_10(float value)
	{
		___m_moveSpeedCurrent_10 = value;
	}

	inline static int32_t get_offset_of_m_acceleratedSpeedRangeMax_11() { return static_cast<int32_t>(offsetof(CarControl_t3855212605, ___m_acceleratedSpeedRangeMax_11)); }
	inline float get_m_acceleratedSpeedRangeMax_11() const { return ___m_acceleratedSpeedRangeMax_11; }
	inline float* get_address_of_m_acceleratedSpeedRangeMax_11() { return &___m_acceleratedSpeedRangeMax_11; }
	inline void set_m_acceleratedSpeedRangeMax_11(float value)
	{
		___m_acceleratedSpeedRangeMax_11 = value;
	}

	inline static int32_t get_offset_of_m_acceleratedSpeedRangeMin_12() { return static_cast<int32_t>(offsetof(CarControl_t3855212605, ___m_acceleratedSpeedRangeMin_12)); }
	inline float get_m_acceleratedSpeedRangeMin_12() const { return ___m_acceleratedSpeedRangeMin_12; }
	inline float* get_address_of_m_acceleratedSpeedRangeMin_12() { return &___m_acceleratedSpeedRangeMin_12; }
	inline void set_m_acceleratedSpeedRangeMin_12(float value)
	{
		___m_acceleratedSpeedRangeMin_12 = value;
	}

	inline static int32_t get_offset_of_m_acceleratedSpeedCurrent_13() { return static_cast<int32_t>(offsetof(CarControl_t3855212605, ___m_acceleratedSpeedCurrent_13)); }
	inline float get_m_acceleratedSpeedCurrent_13() const { return ___m_acceleratedSpeedCurrent_13; }
	inline float* get_address_of_m_acceleratedSpeedCurrent_13() { return &___m_acceleratedSpeedCurrent_13; }
	inline void set_m_acceleratedSpeedCurrent_13(float value)
	{
		___m_acceleratedSpeedCurrent_13 = value;
	}

	inline static int32_t get_offset_of_m_rigidBody_14() { return static_cast<int32_t>(offsetof(CarControl_t3855212605, ___m_rigidBody_14)); }
	inline Rigidbody_t4233889191 * get_m_rigidBody_14() const { return ___m_rigidBody_14; }
	inline Rigidbody_t4233889191 ** get_address_of_m_rigidBody_14() { return &___m_rigidBody_14; }
	inline void set_m_rigidBody_14(Rigidbody_t4233889191 * value)
	{
		___m_rigidBody_14 = value;
		Il2CppCodeGenWriteBarrier(&___m_rigidBody_14, value);
	}

	inline static int32_t get_offset_of_m_capsuleCollider_15() { return static_cast<int32_t>(offsetof(CarControl_t3855212605, ___m_capsuleCollider_15)); }
	inline CapsuleCollider_t720607407 * get_m_capsuleCollider_15() const { return ___m_capsuleCollider_15; }
	inline CapsuleCollider_t720607407 ** get_address_of_m_capsuleCollider_15() { return &___m_capsuleCollider_15; }
	inline void set_m_capsuleCollider_15(CapsuleCollider_t720607407 * value)
	{
		___m_capsuleCollider_15 = value;
		Il2CppCodeGenWriteBarrier(&___m_capsuleCollider_15, value);
	}

	inline static int32_t get_offset_of_m_isMoving_16() { return static_cast<int32_t>(offsetof(CarControl_t3855212605, ___m_isMoving_16)); }
	inline bool get_m_isMoving_16() const { return ___m_isMoving_16; }
	inline bool* get_address_of_m_isMoving_16() { return &___m_isMoving_16; }
	inline void set_m_isMoving_16(bool value)
	{
		___m_isMoving_16 = value;
	}

	inline static int32_t get_offset_of_m_RaycasthitDist_17() { return static_cast<int32_t>(offsetof(CarControl_t3855212605, ___m_RaycasthitDist_17)); }
	inline float get_m_RaycasthitDist_17() const { return ___m_RaycasthitDist_17; }
	inline float* get_address_of_m_RaycasthitDist_17() { return &___m_RaycasthitDist_17; }
	inline void set_m_RaycasthitDist_17(float value)
	{
		___m_RaycasthitDist_17 = value;
	}

	inline static int32_t get_offset_of_m_puaseDist_18() { return static_cast<int32_t>(offsetof(CarControl_t3855212605, ___m_puaseDist_18)); }
	inline float get_m_puaseDist_18() const { return ___m_puaseDist_18; }
	inline float* get_address_of_m_puaseDist_18() { return &___m_puaseDist_18; }
	inline void set_m_puaseDist_18(float value)
	{
		___m_puaseDist_18 = value;
	}

	inline static int32_t get_offset_of_m_isInit_19() { return static_cast<int32_t>(offsetof(CarControl_t3855212605, ___m_isInit_19)); }
	inline bool get_m_isInit_19() const { return ___m_isInit_19; }
	inline bool* get_address_of_m_isInit_19() { return &___m_isInit_19; }
	inline void set_m_isInit_19(bool value)
	{
		___m_isInit_19 = value;
	}

	inline static int32_t get_offset_of_m_direction_20() { return static_cast<int32_t>(offsetof(CarControl_t3855212605, ___m_direction_20)); }
	inline Vector3_t2243707580  get_m_direction_20() const { return ___m_direction_20; }
	inline Vector3_t2243707580 * get_address_of_m_direction_20() { return &___m_direction_20; }
	inline void set_m_direction_20(Vector3_t2243707580  value)
	{
		___m_direction_20 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
