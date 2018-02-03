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




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// test
struct  test_t2695682768  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.Transform test::to
	Transform_t3275118058 * ___to_2;
	// System.Single test::speed
	float ___speed_3;

public:
	inline static int32_t get_offset_of_to_2() { return static_cast<int32_t>(offsetof(test_t2695682768, ___to_2)); }
	inline Transform_t3275118058 * get_to_2() const { return ___to_2; }
	inline Transform_t3275118058 ** get_address_of_to_2() { return &___to_2; }
	inline void set_to_2(Transform_t3275118058 * value)
	{
		___to_2 = value;
		Il2CppCodeGenWriteBarrier(&___to_2, value);
	}

	inline static int32_t get_offset_of_speed_3() { return static_cast<int32_t>(offsetof(test_t2695682768, ___speed_3)); }
	inline float get_speed_3() const { return ___speed_3; }
	inline float* get_address_of_speed_3() { return &___speed_3; }
	inline void set_speed_3(float value)
	{
		___speed_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
