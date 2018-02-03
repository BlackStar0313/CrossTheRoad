#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "AssemblyU2DCSharp_EnumTrafficLight4187058626.h"

// UnityEngine.Renderer
struct Renderer_t257310565;
// System.String
struct String_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// TrafficLightSingle
struct  TrafficLightSingle_t1802359307  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.Renderer TrafficLightSingle::m_myRenderer
	Renderer_t257310565 * ___m_myRenderer_2;
	// System.String TrafficLightSingle::m_texturName
	String_t* ___m_texturName_3;
	// EnumTrafficLight TrafficLightSingle::m_lightType
	int32_t ___m_lightType_4;

public:
	inline static int32_t get_offset_of_m_myRenderer_2() { return static_cast<int32_t>(offsetof(TrafficLightSingle_t1802359307, ___m_myRenderer_2)); }
	inline Renderer_t257310565 * get_m_myRenderer_2() const { return ___m_myRenderer_2; }
	inline Renderer_t257310565 ** get_address_of_m_myRenderer_2() { return &___m_myRenderer_2; }
	inline void set_m_myRenderer_2(Renderer_t257310565 * value)
	{
		___m_myRenderer_2 = value;
		Il2CppCodeGenWriteBarrier(&___m_myRenderer_2, value);
	}

	inline static int32_t get_offset_of_m_texturName_3() { return static_cast<int32_t>(offsetof(TrafficLightSingle_t1802359307, ___m_texturName_3)); }
	inline String_t* get_m_texturName_3() const { return ___m_texturName_3; }
	inline String_t** get_address_of_m_texturName_3() { return &___m_texturName_3; }
	inline void set_m_texturName_3(String_t* value)
	{
		___m_texturName_3 = value;
		Il2CppCodeGenWriteBarrier(&___m_texturName_3, value);
	}

	inline static int32_t get_offset_of_m_lightType_4() { return static_cast<int32_t>(offsetof(TrafficLightSingle_t1802359307, ___m_lightType_4)); }
	inline int32_t get_m_lightType_4() const { return ___m_lightType_4; }
	inline int32_t* get_address_of_m_lightType_4() { return &___m_lightType_4; }
	inline void set_m_lightType_4(int32_t value)
	{
		___m_lightType_4 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
