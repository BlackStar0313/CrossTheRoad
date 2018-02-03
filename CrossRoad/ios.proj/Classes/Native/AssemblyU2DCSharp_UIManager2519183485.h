#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// UnityEngine.GameObject
struct GameObject_t1756533147;
// UIManager
struct UIManager_t2519183485;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UIManager
struct  UIManager_t2519183485  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.GameObject UIManager::WarningUILayer
	GameObject_t1756533147 * ___WarningUILayer_2;

public:
	inline static int32_t get_offset_of_WarningUILayer_2() { return static_cast<int32_t>(offsetof(UIManager_t2519183485, ___WarningUILayer_2)); }
	inline GameObject_t1756533147 * get_WarningUILayer_2() const { return ___WarningUILayer_2; }
	inline GameObject_t1756533147 ** get_address_of_WarningUILayer_2() { return &___WarningUILayer_2; }
	inline void set_WarningUILayer_2(GameObject_t1756533147 * value)
	{
		___WarningUILayer_2 = value;
		Il2CppCodeGenWriteBarrier(&___WarningUILayer_2, value);
	}
};

struct UIManager_t2519183485_StaticFields
{
public:
	// UIManager UIManager::mInstance
	UIManager_t2519183485 * ___mInstance_3;

public:
	inline static int32_t get_offset_of_mInstance_3() { return static_cast<int32_t>(offsetof(UIManager_t2519183485_StaticFields, ___mInstance_3)); }
	inline UIManager_t2519183485 * get_mInstance_3() const { return ___mInstance_3; }
	inline UIManager_t2519183485 ** get_address_of_mInstance_3() { return &___mInstance_3; }
	inline void set_mInstance_3(UIManager_t2519183485 * value)
	{
		___mInstance_3 = value;
		Il2CppCodeGenWriteBarrier(&___mInstance_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
