#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Object2689449295.h"

// DataManager
struct DataManager_t3377637773;
// LocalDataCollection
struct LocalDataCollection_t3807367741;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// DataManager
struct  DataManager_t3377637773  : public Il2CppObject
{
public:
	// LocalDataCollection DataManager::m_localAllData
	LocalDataCollection_t3807367741 * ___m_localAllData_1;

public:
	inline static int32_t get_offset_of_m_localAllData_1() { return static_cast<int32_t>(offsetof(DataManager_t3377637773, ___m_localAllData_1)); }
	inline LocalDataCollection_t3807367741 * get_m_localAllData_1() const { return ___m_localAllData_1; }
	inline LocalDataCollection_t3807367741 ** get_address_of_m_localAllData_1() { return &___m_localAllData_1; }
	inline void set_m_localAllData_1(LocalDataCollection_t3807367741 * value)
	{
		___m_localAllData_1 = value;
		Il2CppCodeGenWriteBarrier(&___m_localAllData_1, value);
	}
};

struct DataManager_t3377637773_StaticFields
{
public:
	// DataManager DataManager::mInstance
	DataManager_t3377637773 * ___mInstance_0;

public:
	inline static int32_t get_offset_of_mInstance_0() { return static_cast<int32_t>(offsetof(DataManager_t3377637773_StaticFields, ___mInstance_0)); }
	inline DataManager_t3377637773 * get_mInstance_0() const { return ___mInstance_0; }
	inline DataManager_t3377637773 ** get_address_of_mInstance_0() { return &___mInstance_0; }
	inline void set_mInstance_0(DataManager_t3377637773 * value)
	{
		___mInstance_0 = value;
		Il2CppCodeGenWriteBarrier(&___mInstance_0, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
