#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// UnityEngine.Camera
struct Camera_t189460977;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// CameraCtr
struct  CameraCtr_t2559963254  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.Camera CameraCtr::m_Camera
	Camera_t189460977 * ___m_Camera_2;
	// System.Single CameraCtr::m_farFiledOfView
	float ___m_farFiledOfView_3;
	// System.Single CameraCtr::m_nearFiledOfView
	float ___m_nearFiledOfView_4;
	// System.Single CameraCtr::m_actTime
	float ___m_actTime_5;

public:
	inline static int32_t get_offset_of_m_Camera_2() { return static_cast<int32_t>(offsetof(CameraCtr_t2559963254, ___m_Camera_2)); }
	inline Camera_t189460977 * get_m_Camera_2() const { return ___m_Camera_2; }
	inline Camera_t189460977 ** get_address_of_m_Camera_2() { return &___m_Camera_2; }
	inline void set_m_Camera_2(Camera_t189460977 * value)
	{
		___m_Camera_2 = value;
		Il2CppCodeGenWriteBarrier(&___m_Camera_2, value);
	}

	inline static int32_t get_offset_of_m_farFiledOfView_3() { return static_cast<int32_t>(offsetof(CameraCtr_t2559963254, ___m_farFiledOfView_3)); }
	inline float get_m_farFiledOfView_3() const { return ___m_farFiledOfView_3; }
	inline float* get_address_of_m_farFiledOfView_3() { return &___m_farFiledOfView_3; }
	inline void set_m_farFiledOfView_3(float value)
	{
		___m_farFiledOfView_3 = value;
	}

	inline static int32_t get_offset_of_m_nearFiledOfView_4() { return static_cast<int32_t>(offsetof(CameraCtr_t2559963254, ___m_nearFiledOfView_4)); }
	inline float get_m_nearFiledOfView_4() const { return ___m_nearFiledOfView_4; }
	inline float* get_address_of_m_nearFiledOfView_4() { return &___m_nearFiledOfView_4; }
	inline void set_m_nearFiledOfView_4(float value)
	{
		___m_nearFiledOfView_4 = value;
	}

	inline static int32_t get_offset_of_m_actTime_5() { return static_cast<int32_t>(offsetof(CameraCtr_t2559963254, ___m_actTime_5)); }
	inline float get_m_actTime_5() const { return ___m_actTime_5; }
	inline float* get_address_of_m_actTime_5() { return &___m_actTime_5; }
	inline void set_m_actTime_5(float value)
	{
		___m_actTime_5 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
