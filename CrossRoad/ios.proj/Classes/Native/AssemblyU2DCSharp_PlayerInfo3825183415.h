#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Object2689449295.h"

// System.Collections.Generic.List`1<System.Int32>
struct List_1_t1440998580;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// PlayerInfo
struct  PlayerInfo_t3825183415  : public Il2CppObject
{
public:
	// System.Int32 PlayerInfo::score
	int32_t ___score_0;
	// System.Int32 PlayerInfo::roundHighScore
	int32_t ___roundHighScore_1;
	// System.Collections.Generic.List`1<System.Int32> PlayerInfo::roles
	List_1_t1440998580 * ___roles_2;
	// System.Int32 PlayerInfo::currentRole
	int32_t ___currentRole_3;

public:
	inline static int32_t get_offset_of_score_0() { return static_cast<int32_t>(offsetof(PlayerInfo_t3825183415, ___score_0)); }
	inline int32_t get_score_0() const { return ___score_0; }
	inline int32_t* get_address_of_score_0() { return &___score_0; }
	inline void set_score_0(int32_t value)
	{
		___score_0 = value;
	}

	inline static int32_t get_offset_of_roundHighScore_1() { return static_cast<int32_t>(offsetof(PlayerInfo_t3825183415, ___roundHighScore_1)); }
	inline int32_t get_roundHighScore_1() const { return ___roundHighScore_1; }
	inline int32_t* get_address_of_roundHighScore_1() { return &___roundHighScore_1; }
	inline void set_roundHighScore_1(int32_t value)
	{
		___roundHighScore_1 = value;
	}

	inline static int32_t get_offset_of_roles_2() { return static_cast<int32_t>(offsetof(PlayerInfo_t3825183415, ___roles_2)); }
	inline List_1_t1440998580 * get_roles_2() const { return ___roles_2; }
	inline List_1_t1440998580 ** get_address_of_roles_2() { return &___roles_2; }
	inline void set_roles_2(List_1_t1440998580 * value)
	{
		___roles_2 = value;
		Il2CppCodeGenWriteBarrier(&___roles_2, value);
	}

	inline static int32_t get_offset_of_currentRole_3() { return static_cast<int32_t>(offsetof(PlayerInfo_t3825183415, ___currentRole_3)); }
	inline int32_t get_currentRole_3() const { return ___currentRole_3; }
	inline int32_t* get_address_of_currentRole_3() { return &___currentRole_3; }
	inline void set_currentRole_3(int32_t value)
	{
		___currentRole_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
