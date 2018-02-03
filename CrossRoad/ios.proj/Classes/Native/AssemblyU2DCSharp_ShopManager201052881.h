#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Object2689449295.h"

// ShopManager
struct ShopManager_t201052881;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// ShopManager
struct  ShopManager_t201052881  : public Il2CppObject
{
public:
	// System.Int32 ShopManager::<currentSelectedRoleIdx>k__BackingField
	int32_t ___U3CcurrentSelectedRoleIdxU3Ek__BackingField_1;

public:
	inline static int32_t get_offset_of_U3CcurrentSelectedRoleIdxU3Ek__BackingField_1() { return static_cast<int32_t>(offsetof(ShopManager_t201052881, ___U3CcurrentSelectedRoleIdxU3Ek__BackingField_1)); }
	inline int32_t get_U3CcurrentSelectedRoleIdxU3Ek__BackingField_1() const { return ___U3CcurrentSelectedRoleIdxU3Ek__BackingField_1; }
	inline int32_t* get_address_of_U3CcurrentSelectedRoleIdxU3Ek__BackingField_1() { return &___U3CcurrentSelectedRoleIdxU3Ek__BackingField_1; }
	inline void set_U3CcurrentSelectedRoleIdxU3Ek__BackingField_1(int32_t value)
	{
		___U3CcurrentSelectedRoleIdxU3Ek__BackingField_1 = value;
	}
};

struct ShopManager_t201052881_StaticFields
{
public:
	// ShopManager ShopManager::m_Instance
	ShopManager_t201052881 * ___m_Instance_0;

public:
	inline static int32_t get_offset_of_m_Instance_0() { return static_cast<int32_t>(offsetof(ShopManager_t201052881_StaticFields, ___m_Instance_0)); }
	inline ShopManager_t201052881 * get_m_Instance_0() const { return ___m_Instance_0; }
	inline ShopManager_t201052881 ** get_address_of_m_Instance_0() { return &___m_Instance_0; }
	inline void set_m_Instance_0(ShopManager_t201052881 * value)
	{
		___m_Instance_0 = value;
		Il2CppCodeGenWriteBarrier(&___m_Instance_0, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
