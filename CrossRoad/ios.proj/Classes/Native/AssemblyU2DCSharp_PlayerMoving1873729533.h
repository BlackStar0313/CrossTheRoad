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
// PlayerController
struct PlayerController_t4148409433;
// UnityEngine.Rigidbody
struct Rigidbody_t4233889191;
// UnityEngine.CharacterController
struct CharacterController_t4094781467;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// PlayerMoving
struct  PlayerMoving_t1873729533  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.Transform PlayerMoving::m_startPos
	Transform_t3275118058 * ___m_startPos_2;
	// UnityEngine.Transform PlayerMoving::m_endPos
	Transform_t3275118058 * ___m_endPos_3;
	// PlayerController PlayerMoving::m_controller
	PlayerController_t4148409433 * ___m_controller_4;
	// UnityEngine.Rigidbody PlayerMoving::m_rigidbody
	Rigidbody_t4233889191 * ___m_rigidbody_5;
	// UnityEngine.CharacterController PlayerMoving::m_character
	CharacterController_t4094781467 * ___m_character_6;
	// System.Boolean PlayerMoving::m_isMoving
	bool ___m_isMoving_7;
	// System.Single PlayerMoving::m_moveStep
	float ___m_moveStep_8;
	// System.Single PlayerMoving::m_moveSpeed
	float ___m_moveSpeed_9;
	// System.Single PlayerMoving::m_direction
	float ___m_direction_10;
	// System.Single PlayerMoving::m_deltaDist
	float ___m_deltaDist_11;
	// System.Boolean PlayerMoving::m_isNewRound
	bool ___m_isNewRound_12;

public:
	inline static int32_t get_offset_of_m_startPos_2() { return static_cast<int32_t>(offsetof(PlayerMoving_t1873729533, ___m_startPos_2)); }
	inline Transform_t3275118058 * get_m_startPos_2() const { return ___m_startPos_2; }
	inline Transform_t3275118058 ** get_address_of_m_startPos_2() { return &___m_startPos_2; }
	inline void set_m_startPos_2(Transform_t3275118058 * value)
	{
		___m_startPos_2 = value;
		Il2CppCodeGenWriteBarrier(&___m_startPos_2, value);
	}

	inline static int32_t get_offset_of_m_endPos_3() { return static_cast<int32_t>(offsetof(PlayerMoving_t1873729533, ___m_endPos_3)); }
	inline Transform_t3275118058 * get_m_endPos_3() const { return ___m_endPos_3; }
	inline Transform_t3275118058 ** get_address_of_m_endPos_3() { return &___m_endPos_3; }
	inline void set_m_endPos_3(Transform_t3275118058 * value)
	{
		___m_endPos_3 = value;
		Il2CppCodeGenWriteBarrier(&___m_endPos_3, value);
	}

	inline static int32_t get_offset_of_m_controller_4() { return static_cast<int32_t>(offsetof(PlayerMoving_t1873729533, ___m_controller_4)); }
	inline PlayerController_t4148409433 * get_m_controller_4() const { return ___m_controller_4; }
	inline PlayerController_t4148409433 ** get_address_of_m_controller_4() { return &___m_controller_4; }
	inline void set_m_controller_4(PlayerController_t4148409433 * value)
	{
		___m_controller_4 = value;
		Il2CppCodeGenWriteBarrier(&___m_controller_4, value);
	}

	inline static int32_t get_offset_of_m_rigidbody_5() { return static_cast<int32_t>(offsetof(PlayerMoving_t1873729533, ___m_rigidbody_5)); }
	inline Rigidbody_t4233889191 * get_m_rigidbody_5() const { return ___m_rigidbody_5; }
	inline Rigidbody_t4233889191 ** get_address_of_m_rigidbody_5() { return &___m_rigidbody_5; }
	inline void set_m_rigidbody_5(Rigidbody_t4233889191 * value)
	{
		___m_rigidbody_5 = value;
		Il2CppCodeGenWriteBarrier(&___m_rigidbody_5, value);
	}

	inline static int32_t get_offset_of_m_character_6() { return static_cast<int32_t>(offsetof(PlayerMoving_t1873729533, ___m_character_6)); }
	inline CharacterController_t4094781467 * get_m_character_6() const { return ___m_character_6; }
	inline CharacterController_t4094781467 ** get_address_of_m_character_6() { return &___m_character_6; }
	inline void set_m_character_6(CharacterController_t4094781467 * value)
	{
		___m_character_6 = value;
		Il2CppCodeGenWriteBarrier(&___m_character_6, value);
	}

	inline static int32_t get_offset_of_m_isMoving_7() { return static_cast<int32_t>(offsetof(PlayerMoving_t1873729533, ___m_isMoving_7)); }
	inline bool get_m_isMoving_7() const { return ___m_isMoving_7; }
	inline bool* get_address_of_m_isMoving_7() { return &___m_isMoving_7; }
	inline void set_m_isMoving_7(bool value)
	{
		___m_isMoving_7 = value;
	}

	inline static int32_t get_offset_of_m_moveStep_8() { return static_cast<int32_t>(offsetof(PlayerMoving_t1873729533, ___m_moveStep_8)); }
	inline float get_m_moveStep_8() const { return ___m_moveStep_8; }
	inline float* get_address_of_m_moveStep_8() { return &___m_moveStep_8; }
	inline void set_m_moveStep_8(float value)
	{
		___m_moveStep_8 = value;
	}

	inline static int32_t get_offset_of_m_moveSpeed_9() { return static_cast<int32_t>(offsetof(PlayerMoving_t1873729533, ___m_moveSpeed_9)); }
	inline float get_m_moveSpeed_9() const { return ___m_moveSpeed_9; }
	inline float* get_address_of_m_moveSpeed_9() { return &___m_moveSpeed_9; }
	inline void set_m_moveSpeed_9(float value)
	{
		___m_moveSpeed_9 = value;
	}

	inline static int32_t get_offset_of_m_direction_10() { return static_cast<int32_t>(offsetof(PlayerMoving_t1873729533, ___m_direction_10)); }
	inline float get_m_direction_10() const { return ___m_direction_10; }
	inline float* get_address_of_m_direction_10() { return &___m_direction_10; }
	inline void set_m_direction_10(float value)
	{
		___m_direction_10 = value;
	}

	inline static int32_t get_offset_of_m_deltaDist_11() { return static_cast<int32_t>(offsetof(PlayerMoving_t1873729533, ___m_deltaDist_11)); }
	inline float get_m_deltaDist_11() const { return ___m_deltaDist_11; }
	inline float* get_address_of_m_deltaDist_11() { return &___m_deltaDist_11; }
	inline void set_m_deltaDist_11(float value)
	{
		___m_deltaDist_11 = value;
	}

	inline static int32_t get_offset_of_m_isNewRound_12() { return static_cast<int32_t>(offsetof(PlayerMoving_t1873729533, ___m_isNewRound_12)); }
	inline bool get_m_isNewRound_12() const { return ___m_isNewRound_12; }
	inline bool* get_address_of_m_isNewRound_12() { return &___m_isNewRound_12; }
	inline void set_m_isNewRound_12(bool value)
	{
		___m_isNewRound_12 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
