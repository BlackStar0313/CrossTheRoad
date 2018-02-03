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

// UnityEngine.GameObject[]
struct GameObjectU5BU5D_t3057952154;
// System.Single[]
struct SingleU5BU5D_t577127397;
// TrafficLightSingle[]
struct TrafficLightSingleU5BU5D_t3097208170;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// TrafficLightControl
struct  TrafficLightControl_t3565843632  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.GameObject[] TrafficLightControl::m_trafficLight
	GameObjectU5BU5D_t3057952154* ___m_trafficLight_2;
	// System.Single[] TrafficLightControl::m_lightDelayTime
	SingleU5BU5D_t577127397* ___m_lightDelayTime_3;
	// TrafficLightSingle[] TrafficLightControl::m_lightArr
	TrafficLightSingleU5BU5D_t3097208170* ___m_lightArr_4;
	// EnumTrafficLight TrafficLightControl::m_currentLight
	int32_t ___m_currentLight_5;

public:
	inline static int32_t get_offset_of_m_trafficLight_2() { return static_cast<int32_t>(offsetof(TrafficLightControl_t3565843632, ___m_trafficLight_2)); }
	inline GameObjectU5BU5D_t3057952154* get_m_trafficLight_2() const { return ___m_trafficLight_2; }
	inline GameObjectU5BU5D_t3057952154** get_address_of_m_trafficLight_2() { return &___m_trafficLight_2; }
	inline void set_m_trafficLight_2(GameObjectU5BU5D_t3057952154* value)
	{
		___m_trafficLight_2 = value;
		Il2CppCodeGenWriteBarrier(&___m_trafficLight_2, value);
	}

	inline static int32_t get_offset_of_m_lightDelayTime_3() { return static_cast<int32_t>(offsetof(TrafficLightControl_t3565843632, ___m_lightDelayTime_3)); }
	inline SingleU5BU5D_t577127397* get_m_lightDelayTime_3() const { return ___m_lightDelayTime_3; }
	inline SingleU5BU5D_t577127397** get_address_of_m_lightDelayTime_3() { return &___m_lightDelayTime_3; }
	inline void set_m_lightDelayTime_3(SingleU5BU5D_t577127397* value)
	{
		___m_lightDelayTime_3 = value;
		Il2CppCodeGenWriteBarrier(&___m_lightDelayTime_3, value);
	}

	inline static int32_t get_offset_of_m_lightArr_4() { return static_cast<int32_t>(offsetof(TrafficLightControl_t3565843632, ___m_lightArr_4)); }
	inline TrafficLightSingleU5BU5D_t3097208170* get_m_lightArr_4() const { return ___m_lightArr_4; }
	inline TrafficLightSingleU5BU5D_t3097208170** get_address_of_m_lightArr_4() { return &___m_lightArr_4; }
	inline void set_m_lightArr_4(TrafficLightSingleU5BU5D_t3097208170* value)
	{
		___m_lightArr_4 = value;
		Il2CppCodeGenWriteBarrier(&___m_lightArr_4, value);
	}

	inline static int32_t get_offset_of_m_currentLight_5() { return static_cast<int32_t>(offsetof(TrafficLightControl_t3565843632, ___m_currentLight_5)); }
	inline int32_t get_m_currentLight_5() const { return ___m_currentLight_5; }
	inline int32_t* get_address_of_m_currentLight_5() { return &___m_currentLight_5; }
	inline void set_m_currentLight_5(int32_t value)
	{
		___m_currentLight_5 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
