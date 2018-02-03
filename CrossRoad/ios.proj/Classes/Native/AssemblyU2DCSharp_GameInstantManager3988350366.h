#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// SoundsManager
struct SoundsManager_t4165177525;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// GameInstantManager
struct  GameInstantManager_t3988350366  : public MonoBehaviour_t1158329972
{
public:
	// SoundsManager GameInstantManager::m_soundsManager
	SoundsManager_t4165177525 * ___m_soundsManager_2;

public:
	inline static int32_t get_offset_of_m_soundsManager_2() { return static_cast<int32_t>(offsetof(GameInstantManager_t3988350366, ___m_soundsManager_2)); }
	inline SoundsManager_t4165177525 * get_m_soundsManager_2() const { return ___m_soundsManager_2; }
	inline SoundsManager_t4165177525 ** get_address_of_m_soundsManager_2() { return &___m_soundsManager_2; }
	inline void set_m_soundsManager_2(SoundsManager_t4165177525 * value)
	{
		___m_soundsManager_2 = value;
		Il2CppCodeGenWriteBarrier(&___m_soundsManager_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
