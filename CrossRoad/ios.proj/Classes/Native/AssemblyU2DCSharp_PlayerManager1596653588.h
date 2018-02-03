#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Object2689449295.h"

// PlayerManager
struct PlayerManager_t1596653588;
// PlayerInfo
struct PlayerInfo_t3825183415;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// PlayerManager
struct  PlayerManager_t1596653588  : public Il2CppObject
{
public:
	// System.Int32 PlayerManager::m_addScoreSpeed
	int32_t ___m_addScoreSpeed_1;
	// PlayerInfo PlayerManager::m_playerInfo
	PlayerInfo_t3825183415 * ___m_playerInfo_2;

public:
	inline static int32_t get_offset_of_m_addScoreSpeed_1() { return static_cast<int32_t>(offsetof(PlayerManager_t1596653588, ___m_addScoreSpeed_1)); }
	inline int32_t get_m_addScoreSpeed_1() const { return ___m_addScoreSpeed_1; }
	inline int32_t* get_address_of_m_addScoreSpeed_1() { return &___m_addScoreSpeed_1; }
	inline void set_m_addScoreSpeed_1(int32_t value)
	{
		___m_addScoreSpeed_1 = value;
	}

	inline static int32_t get_offset_of_m_playerInfo_2() { return static_cast<int32_t>(offsetof(PlayerManager_t1596653588, ___m_playerInfo_2)); }
	inline PlayerInfo_t3825183415 * get_m_playerInfo_2() const { return ___m_playerInfo_2; }
	inline PlayerInfo_t3825183415 ** get_address_of_m_playerInfo_2() { return &___m_playerInfo_2; }
	inline void set_m_playerInfo_2(PlayerInfo_t3825183415 * value)
	{
		___m_playerInfo_2 = value;
		Il2CppCodeGenWriteBarrier(&___m_playerInfo_2, value);
	}
};

struct PlayerManager_t1596653588_StaticFields
{
public:
	// PlayerManager PlayerManager::m_instance
	PlayerManager_t1596653588 * ___m_instance_0;

public:
	inline static int32_t get_offset_of_m_instance_0() { return static_cast<int32_t>(offsetof(PlayerManager_t1596653588_StaticFields, ___m_instance_0)); }
	inline PlayerManager_t1596653588 * get_m_instance_0() const { return ___m_instance_0; }
	inline PlayerManager_t1596653588 ** get_address_of_m_instance_0() { return &___m_instance_0; }
	inline void set_m_instance_0(PlayerManager_t1596653588 * value)
	{
		___m_instance_0 = value;
		Il2CppCodeGenWriteBarrier(&___m_instance_0, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
