#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// GameInstantManager
struct GameInstantManager_t3988350366;
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
	SoundsManager_t4165177525 * ___m_soundsManager_3;
	// System.Boolean GameInstantManager::m_isCreate
	bool ___m_isCreate_4;
	// System.Boolean GameInstantManager::isTransFromGameScene
	bool ___isTransFromGameScene_5;

public:
	inline static int32_t get_offset_of_m_soundsManager_3() { return static_cast<int32_t>(offsetof(GameInstantManager_t3988350366, ___m_soundsManager_3)); }
	inline SoundsManager_t4165177525 * get_m_soundsManager_3() const { return ___m_soundsManager_3; }
	inline SoundsManager_t4165177525 ** get_address_of_m_soundsManager_3() { return &___m_soundsManager_3; }
	inline void set_m_soundsManager_3(SoundsManager_t4165177525 * value)
	{
		___m_soundsManager_3 = value;
		Il2CppCodeGenWriteBarrier(&___m_soundsManager_3, value);
	}

	inline static int32_t get_offset_of_m_isCreate_4() { return static_cast<int32_t>(offsetof(GameInstantManager_t3988350366, ___m_isCreate_4)); }
	inline bool get_m_isCreate_4() const { return ___m_isCreate_4; }
	inline bool* get_address_of_m_isCreate_4() { return &___m_isCreate_4; }
	inline void set_m_isCreate_4(bool value)
	{
		___m_isCreate_4 = value;
	}

	inline static int32_t get_offset_of_isTransFromGameScene_5() { return static_cast<int32_t>(offsetof(GameInstantManager_t3988350366, ___isTransFromGameScene_5)); }
	inline bool get_isTransFromGameScene_5() const { return ___isTransFromGameScene_5; }
	inline bool* get_address_of_isTransFromGameScene_5() { return &___isTransFromGameScene_5; }
	inline void set_isTransFromGameScene_5(bool value)
	{
		___isTransFromGameScene_5 = value;
	}
};

struct GameInstantManager_t3988350366_StaticFields
{
public:
	// GameInstantManager GameInstantManager::mInstance
	GameInstantManager_t3988350366 * ___mInstance_2;

public:
	inline static int32_t get_offset_of_mInstance_2() { return static_cast<int32_t>(offsetof(GameInstantManager_t3988350366_StaticFields, ___mInstance_2)); }
	inline GameInstantManager_t3988350366 * get_mInstance_2() const { return ___mInstance_2; }
	inline GameInstantManager_t3988350366 ** get_address_of_mInstance_2() { return &___mInstance_2; }
	inline void set_mInstance_2(GameInstantManager_t3988350366 * value)
	{
		___mInstance_2 = value;
		Il2CppCodeGenWriteBarrier(&___mInstance_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
