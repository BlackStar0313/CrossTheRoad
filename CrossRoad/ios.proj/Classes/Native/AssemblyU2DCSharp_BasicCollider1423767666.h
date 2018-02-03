#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "UnityEngine_UnityEngine_Vector32243707580.h"

// UnityEngine.GameObject
struct GameObject_t1756533147;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// BasicCollider
struct  BasicCollider_t1423767666  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.GameObject BasicCollider::m_parent
	GameObject_t1756533147 * ___m_parent_2;
	// System.Boolean BasicCollider::m_isCollide
	bool ___m_isCollide_3;
	// UnityEngine.Vector3 BasicCollider::m_direction
	Vector3_t2243707580  ___m_direction_4;
	// System.Single BasicCollider::m_speed
	float ___m_speed_5;
	// System.Single BasicCollider::m_drag
	float ___m_drag_6;
	// System.Single BasicCollider::m_deadHeight
	float ___m_deadHeight_7;

public:
	inline static int32_t get_offset_of_m_parent_2() { return static_cast<int32_t>(offsetof(BasicCollider_t1423767666, ___m_parent_2)); }
	inline GameObject_t1756533147 * get_m_parent_2() const { return ___m_parent_2; }
	inline GameObject_t1756533147 ** get_address_of_m_parent_2() { return &___m_parent_2; }
	inline void set_m_parent_2(GameObject_t1756533147 * value)
	{
		___m_parent_2 = value;
		Il2CppCodeGenWriteBarrier(&___m_parent_2, value);
	}

	inline static int32_t get_offset_of_m_isCollide_3() { return static_cast<int32_t>(offsetof(BasicCollider_t1423767666, ___m_isCollide_3)); }
	inline bool get_m_isCollide_3() const { return ___m_isCollide_3; }
	inline bool* get_address_of_m_isCollide_3() { return &___m_isCollide_3; }
	inline void set_m_isCollide_3(bool value)
	{
		___m_isCollide_3 = value;
	}

	inline static int32_t get_offset_of_m_direction_4() { return static_cast<int32_t>(offsetof(BasicCollider_t1423767666, ___m_direction_4)); }
	inline Vector3_t2243707580  get_m_direction_4() const { return ___m_direction_4; }
	inline Vector3_t2243707580 * get_address_of_m_direction_4() { return &___m_direction_4; }
	inline void set_m_direction_4(Vector3_t2243707580  value)
	{
		___m_direction_4 = value;
	}

	inline static int32_t get_offset_of_m_speed_5() { return static_cast<int32_t>(offsetof(BasicCollider_t1423767666, ___m_speed_5)); }
	inline float get_m_speed_5() const { return ___m_speed_5; }
	inline float* get_address_of_m_speed_5() { return &___m_speed_5; }
	inline void set_m_speed_5(float value)
	{
		___m_speed_5 = value;
	}

	inline static int32_t get_offset_of_m_drag_6() { return static_cast<int32_t>(offsetof(BasicCollider_t1423767666, ___m_drag_6)); }
	inline float get_m_drag_6() const { return ___m_drag_6; }
	inline float* get_address_of_m_drag_6() { return &___m_drag_6; }
	inline void set_m_drag_6(float value)
	{
		___m_drag_6 = value;
	}

	inline static int32_t get_offset_of_m_deadHeight_7() { return static_cast<int32_t>(offsetof(BasicCollider_t1423767666, ___m_deadHeight_7)); }
	inline float get_m_deadHeight_7() const { return ___m_deadHeight_7; }
	inline float* get_address_of_m_deadHeight_7() { return &___m_deadHeight_7; }
	inline void set_m_deadHeight_7(float value)
	{
		___m_deadHeight_7 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
