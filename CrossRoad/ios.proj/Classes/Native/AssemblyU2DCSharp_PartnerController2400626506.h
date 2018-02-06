#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "AssemblyU2DCSharp_BasicController2369989902.h"
#include "AssemblyU2DCSharp_enumArrowType1171045074.h"
#include "AssemblyU2DCSharp_EnumMovingDirect3127968538.h"

// PartnerMoving
struct PartnerMoving_t124062468;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// PartnerController
struct  PartnerController_t2400626506  : public BasicController_t2369989902
{
public:
	// PartnerMoving PartnerController::m_partnerMoving
	PartnerMoving_t124062468 * ___m_partnerMoving_7;
	// System.Boolean PartnerController::m_isActToMove
	bool ___m_isActToMove_8;
	// enumArrowType PartnerController::m_arrowType
	int32_t ___m_arrowType_9;
	// EnumMovingDirect PartnerController::<currentDirect>k__BackingField
	int32_t ___U3CcurrentDirectU3Ek__BackingField_10;

public:
	inline static int32_t get_offset_of_m_partnerMoving_7() { return static_cast<int32_t>(offsetof(PartnerController_t2400626506, ___m_partnerMoving_7)); }
	inline PartnerMoving_t124062468 * get_m_partnerMoving_7() const { return ___m_partnerMoving_7; }
	inline PartnerMoving_t124062468 ** get_address_of_m_partnerMoving_7() { return &___m_partnerMoving_7; }
	inline void set_m_partnerMoving_7(PartnerMoving_t124062468 * value)
	{
		___m_partnerMoving_7 = value;
		Il2CppCodeGenWriteBarrier(&___m_partnerMoving_7, value);
	}

	inline static int32_t get_offset_of_m_isActToMove_8() { return static_cast<int32_t>(offsetof(PartnerController_t2400626506, ___m_isActToMove_8)); }
	inline bool get_m_isActToMove_8() const { return ___m_isActToMove_8; }
	inline bool* get_address_of_m_isActToMove_8() { return &___m_isActToMove_8; }
	inline void set_m_isActToMove_8(bool value)
	{
		___m_isActToMove_8 = value;
	}

	inline static int32_t get_offset_of_m_arrowType_9() { return static_cast<int32_t>(offsetof(PartnerController_t2400626506, ___m_arrowType_9)); }
	inline int32_t get_m_arrowType_9() const { return ___m_arrowType_9; }
	inline int32_t* get_address_of_m_arrowType_9() { return &___m_arrowType_9; }
	inline void set_m_arrowType_9(int32_t value)
	{
		___m_arrowType_9 = value;
	}

	inline static int32_t get_offset_of_U3CcurrentDirectU3Ek__BackingField_10() { return static_cast<int32_t>(offsetof(PartnerController_t2400626506, ___U3CcurrentDirectU3Ek__BackingField_10)); }
	inline int32_t get_U3CcurrentDirectU3Ek__BackingField_10() const { return ___U3CcurrentDirectU3Ek__BackingField_10; }
	inline int32_t* get_address_of_U3CcurrentDirectU3Ek__BackingField_10() { return &___U3CcurrentDirectU3Ek__BackingField_10; }
	inline void set_U3CcurrentDirectU3Ek__BackingField_10(int32_t value)
	{
		___U3CcurrentDirectU3Ek__BackingField_10 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
