#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Object2689449295.h"

// Datarole
struct Datarole_t1829991904;
// Datashop
struct Datashop_t3745658020;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// LocalDataCollection
struct  LocalDataCollection_t3807367741  : public Il2CppObject
{
public:
	// Datarole LocalDataCollection::role
	Datarole_t1829991904 * ___role_0;
	// Datashop LocalDataCollection::shop
	Datashop_t3745658020 * ___shop_1;

public:
	inline static int32_t get_offset_of_role_0() { return static_cast<int32_t>(offsetof(LocalDataCollection_t3807367741, ___role_0)); }
	inline Datarole_t1829991904 * get_role_0() const { return ___role_0; }
	inline Datarole_t1829991904 ** get_address_of_role_0() { return &___role_0; }
	inline void set_role_0(Datarole_t1829991904 * value)
	{
		___role_0 = value;
		Il2CppCodeGenWriteBarrier(&___role_0, value);
	}

	inline static int32_t get_offset_of_shop_1() { return static_cast<int32_t>(offsetof(LocalDataCollection_t3807367741, ___shop_1)); }
	inline Datashop_t3745658020 * get_shop_1() const { return ___shop_1; }
	inline Datashop_t3745658020 ** get_address_of_shop_1() { return &___shop_1; }
	inline void set_shop_1(Datashop_t3745658020 * value)
	{
		___shop_1 = value;
		Il2CppCodeGenWriteBarrier(&___shop_1, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
