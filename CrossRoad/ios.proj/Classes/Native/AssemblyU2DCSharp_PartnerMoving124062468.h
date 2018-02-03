#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// UnityEngine.Transform
struct Transform_t3275118058;
// PartnerController
struct PartnerController_t2400626506;
// UnityEngine.CharacterController
struct CharacterController_t4094781467;
// UnityEngine.Animator
struct Animator_t69676727;
// UnityEngine.Rigidbody
struct Rigidbody_t4233889191;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// PartnerMoving
struct  PartnerMoving_t124062468  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.Transform PartnerMoving::m_startBornPos
	Transform_t3275118058 * ___m_startBornPos_2;
	// UnityEngine.Transform PartnerMoving::m_startPos
	Transform_t3275118058 * ___m_startPos_3;
	// UnityEngine.Transform PartnerMoving::m_endBornPos
	Transform_t3275118058 * ___m_endBornPos_4;
	// UnityEngine.Transform PartnerMoving::m_endPos
	Transform_t3275118058 * ___m_endPos_5;
	// PartnerController PartnerMoving::m_controller
	PartnerController_t2400626506 * ___m_controller_6;
	// UnityEngine.CharacterController PartnerMoving::m_character
	CharacterController_t4094781467 * ___m_character_7;
	// UnityEngine.Animator PartnerMoving::m_animator
	Animator_t69676727 * ___m_animator_8;
	// UnityEngine.Rigidbody PartnerMoving::m_rigidBody
	Rigidbody_t4233889191 * ___m_rigidBody_9;
	// System.Boolean PartnerMoving::m_isStart
	bool ___m_isStart_10;
	// UnityEngine.Transform PartnerMoving::m_autoEndPos
	Transform_t3275118058 * ___m_autoEndPos_11;
	// System.Single PartnerMoving::m_autoMoveStep
	float ___m_autoMoveStep_12;

public:
	inline static int32_t get_offset_of_m_startBornPos_2() { return static_cast<int32_t>(offsetof(PartnerMoving_t124062468, ___m_startBornPos_2)); }
	inline Transform_t3275118058 * get_m_startBornPos_2() const { return ___m_startBornPos_2; }
	inline Transform_t3275118058 ** get_address_of_m_startBornPos_2() { return &___m_startBornPos_2; }
	inline void set_m_startBornPos_2(Transform_t3275118058 * value)
	{
		___m_startBornPos_2 = value;
		Il2CppCodeGenWriteBarrier(&___m_startBornPos_2, value);
	}

	inline static int32_t get_offset_of_m_startPos_3() { return static_cast<int32_t>(offsetof(PartnerMoving_t124062468, ___m_startPos_3)); }
	inline Transform_t3275118058 * get_m_startPos_3() const { return ___m_startPos_3; }
	inline Transform_t3275118058 ** get_address_of_m_startPos_3() { return &___m_startPos_3; }
	inline void set_m_startPos_3(Transform_t3275118058 * value)
	{
		___m_startPos_3 = value;
		Il2CppCodeGenWriteBarrier(&___m_startPos_3, value);
	}

	inline static int32_t get_offset_of_m_endBornPos_4() { return static_cast<int32_t>(offsetof(PartnerMoving_t124062468, ___m_endBornPos_4)); }
	inline Transform_t3275118058 * get_m_endBornPos_4() const { return ___m_endBornPos_4; }
	inline Transform_t3275118058 ** get_address_of_m_endBornPos_4() { return &___m_endBornPos_4; }
	inline void set_m_endBornPos_4(Transform_t3275118058 * value)
	{
		___m_endBornPos_4 = value;
		Il2CppCodeGenWriteBarrier(&___m_endBornPos_4, value);
	}

	inline static int32_t get_offset_of_m_endPos_5() { return static_cast<int32_t>(offsetof(PartnerMoving_t124062468, ___m_endPos_5)); }
	inline Transform_t3275118058 * get_m_endPos_5() const { return ___m_endPos_5; }
	inline Transform_t3275118058 ** get_address_of_m_endPos_5() { return &___m_endPos_5; }
	inline void set_m_endPos_5(Transform_t3275118058 * value)
	{
		___m_endPos_5 = value;
		Il2CppCodeGenWriteBarrier(&___m_endPos_5, value);
	}

	inline static int32_t get_offset_of_m_controller_6() { return static_cast<int32_t>(offsetof(PartnerMoving_t124062468, ___m_controller_6)); }
	inline PartnerController_t2400626506 * get_m_controller_6() const { return ___m_controller_6; }
	inline PartnerController_t2400626506 ** get_address_of_m_controller_6() { return &___m_controller_6; }
	inline void set_m_controller_6(PartnerController_t2400626506 * value)
	{
		___m_controller_6 = value;
		Il2CppCodeGenWriteBarrier(&___m_controller_6, value);
	}

	inline static int32_t get_offset_of_m_character_7() { return static_cast<int32_t>(offsetof(PartnerMoving_t124062468, ___m_character_7)); }
	inline CharacterController_t4094781467 * get_m_character_7() const { return ___m_character_7; }
	inline CharacterController_t4094781467 ** get_address_of_m_character_7() { return &___m_character_7; }
	inline void set_m_character_7(CharacterController_t4094781467 * value)
	{
		___m_character_7 = value;
		Il2CppCodeGenWriteBarrier(&___m_character_7, value);
	}

	inline static int32_t get_offset_of_m_animator_8() { return static_cast<int32_t>(offsetof(PartnerMoving_t124062468, ___m_animator_8)); }
	inline Animator_t69676727 * get_m_animator_8() const { return ___m_animator_8; }
	inline Animator_t69676727 ** get_address_of_m_animator_8() { return &___m_animator_8; }
	inline void set_m_animator_8(Animator_t69676727 * value)
	{
		___m_animator_8 = value;
		Il2CppCodeGenWriteBarrier(&___m_animator_8, value);
	}

	inline static int32_t get_offset_of_m_rigidBody_9() { return static_cast<int32_t>(offsetof(PartnerMoving_t124062468, ___m_rigidBody_9)); }
	inline Rigidbody_t4233889191 * get_m_rigidBody_9() const { return ___m_rigidBody_9; }
	inline Rigidbody_t4233889191 ** get_address_of_m_rigidBody_9() { return &___m_rigidBody_9; }
	inline void set_m_rigidBody_9(Rigidbody_t4233889191 * value)
	{
		___m_rigidBody_9 = value;
		Il2CppCodeGenWriteBarrier(&___m_rigidBody_9, value);
	}

	inline static int32_t get_offset_of_m_isStart_10() { return static_cast<int32_t>(offsetof(PartnerMoving_t124062468, ___m_isStart_10)); }
	inline bool get_m_isStart_10() const { return ___m_isStart_10; }
	inline bool* get_address_of_m_isStart_10() { return &___m_isStart_10; }
	inline void set_m_isStart_10(bool value)
	{
		___m_isStart_10 = value;
	}

	inline static int32_t get_offset_of_m_autoEndPos_11() { return static_cast<int32_t>(offsetof(PartnerMoving_t124062468, ___m_autoEndPos_11)); }
	inline Transform_t3275118058 * get_m_autoEndPos_11() const { return ___m_autoEndPos_11; }
	inline Transform_t3275118058 ** get_address_of_m_autoEndPos_11() { return &___m_autoEndPos_11; }
	inline void set_m_autoEndPos_11(Transform_t3275118058 * value)
	{
		___m_autoEndPos_11 = value;
		Il2CppCodeGenWriteBarrier(&___m_autoEndPos_11, value);
	}

	inline static int32_t get_offset_of_m_autoMoveStep_12() { return static_cast<int32_t>(offsetof(PartnerMoving_t124062468, ___m_autoMoveStep_12)); }
	inline float get_m_autoMoveStep_12() const { return ___m_autoMoveStep_12; }
	inline float* get_address_of_m_autoMoveStep_12() { return &___m_autoMoveStep_12; }
	inline void set_m_autoMoveStep_12(float value)
	{
		___m_autoMoveStep_12 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
