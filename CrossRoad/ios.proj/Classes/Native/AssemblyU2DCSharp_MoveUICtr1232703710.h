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
// UnityEngine.Transform
struct Transform_t3275118058;
// MoveArrow
struct MoveArrow_t3041501918;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// MoveUICtr
struct  MoveUICtr_t1232703710  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.GameObject MoveUICtr::m_arrowObj
	GameObject_t1756533147 * ___m_arrowObj_2;
	// UnityEngine.GameObject MoveUICtr::m_parentObj
	GameObject_t1756533147 * ___m_parentObj_3;
	// UnityEngine.Transform MoveUICtr::m_cameraPos
	Transform_t3275118058 * ___m_cameraPos_4;
	// MoveArrow MoveUICtr::m_arrow
	MoveArrow_t3041501918 * ___m_arrow_5;

public:
	inline static int32_t get_offset_of_m_arrowObj_2() { return static_cast<int32_t>(offsetof(MoveUICtr_t1232703710, ___m_arrowObj_2)); }
	inline GameObject_t1756533147 * get_m_arrowObj_2() const { return ___m_arrowObj_2; }
	inline GameObject_t1756533147 ** get_address_of_m_arrowObj_2() { return &___m_arrowObj_2; }
	inline void set_m_arrowObj_2(GameObject_t1756533147 * value)
	{
		___m_arrowObj_2 = value;
		Il2CppCodeGenWriteBarrier(&___m_arrowObj_2, value);
	}

	inline static int32_t get_offset_of_m_parentObj_3() { return static_cast<int32_t>(offsetof(MoveUICtr_t1232703710, ___m_parentObj_3)); }
	inline GameObject_t1756533147 * get_m_parentObj_3() const { return ___m_parentObj_3; }
	inline GameObject_t1756533147 ** get_address_of_m_parentObj_3() { return &___m_parentObj_3; }
	inline void set_m_parentObj_3(GameObject_t1756533147 * value)
	{
		___m_parentObj_3 = value;
		Il2CppCodeGenWriteBarrier(&___m_parentObj_3, value);
	}

	inline static int32_t get_offset_of_m_cameraPos_4() { return static_cast<int32_t>(offsetof(MoveUICtr_t1232703710, ___m_cameraPos_4)); }
	inline Transform_t3275118058 * get_m_cameraPos_4() const { return ___m_cameraPos_4; }
	inline Transform_t3275118058 ** get_address_of_m_cameraPos_4() { return &___m_cameraPos_4; }
	inline void set_m_cameraPos_4(Transform_t3275118058 * value)
	{
		___m_cameraPos_4 = value;
		Il2CppCodeGenWriteBarrier(&___m_cameraPos_4, value);
	}

	inline static int32_t get_offset_of_m_arrow_5() { return static_cast<int32_t>(offsetof(MoveUICtr_t1232703710, ___m_arrow_5)); }
	inline MoveArrow_t3041501918 * get_m_arrow_5() const { return ___m_arrow_5; }
	inline MoveArrow_t3041501918 ** get_address_of_m_arrow_5() { return &___m_arrow_5; }
	inline void set_m_arrow_5(MoveArrow_t3041501918 * value)
	{
		___m_arrow_5 = value;
		Il2CppCodeGenWriteBarrier(&___m_arrow_5, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
