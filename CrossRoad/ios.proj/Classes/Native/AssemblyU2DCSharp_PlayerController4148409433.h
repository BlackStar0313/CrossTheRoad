#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "AssemblyU2DCSharp_BasicController2369989902.h"

// PlayerMoving
struct PlayerMoving_t1873729533;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// PlayerController
struct  PlayerController_t4148409433  : public BasicController_t2369989902
{
public:
	// PlayerMoving PlayerController::m_playerMoving
	PlayerMoving_t1873729533 * ___m_playerMoving_6;

public:
	inline static int32_t get_offset_of_m_playerMoving_6() { return static_cast<int32_t>(offsetof(PlayerController_t4148409433, ___m_playerMoving_6)); }
	inline PlayerMoving_t1873729533 * get_m_playerMoving_6() const { return ___m_playerMoving_6; }
	inline PlayerMoving_t1873729533 ** get_address_of_m_playerMoving_6() { return &___m_playerMoving_6; }
	inline void set_m_playerMoving_6(PlayerMoving_t1873729533 * value)
	{
		___m_playerMoving_6 = value;
		Il2CppCodeGenWriteBarrier(&___m_playerMoving_6, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
