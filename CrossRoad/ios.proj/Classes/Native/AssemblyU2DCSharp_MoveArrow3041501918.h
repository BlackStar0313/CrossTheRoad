#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// UnityEngine.Sprite
struct Sprite_t309593783;
// UnityEngine.UI.Image
struct Image_t2042527209;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// MoveArrow
struct  MoveArrow_t3041501918  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.Sprite MoveArrow::m_spriteRed
	Sprite_t309593783 * ___m_spriteRed_2;
	// UnityEngine.Sprite MoveArrow::m_spriteGreen
	Sprite_t309593783 * ___m_spriteGreen_3;
	// UnityEngine.UI.Image MoveArrow::m_img
	Image_t2042527209 * ___m_img_4;

public:
	inline static int32_t get_offset_of_m_spriteRed_2() { return static_cast<int32_t>(offsetof(MoveArrow_t3041501918, ___m_spriteRed_2)); }
	inline Sprite_t309593783 * get_m_spriteRed_2() const { return ___m_spriteRed_2; }
	inline Sprite_t309593783 ** get_address_of_m_spriteRed_2() { return &___m_spriteRed_2; }
	inline void set_m_spriteRed_2(Sprite_t309593783 * value)
	{
		___m_spriteRed_2 = value;
		Il2CppCodeGenWriteBarrier(&___m_spriteRed_2, value);
	}

	inline static int32_t get_offset_of_m_spriteGreen_3() { return static_cast<int32_t>(offsetof(MoveArrow_t3041501918, ___m_spriteGreen_3)); }
	inline Sprite_t309593783 * get_m_spriteGreen_3() const { return ___m_spriteGreen_3; }
	inline Sprite_t309593783 ** get_address_of_m_spriteGreen_3() { return &___m_spriteGreen_3; }
	inline void set_m_spriteGreen_3(Sprite_t309593783 * value)
	{
		___m_spriteGreen_3 = value;
		Il2CppCodeGenWriteBarrier(&___m_spriteGreen_3, value);
	}

	inline static int32_t get_offset_of_m_img_4() { return static_cast<int32_t>(offsetof(MoveArrow_t3041501918, ___m_img_4)); }
	inline Image_t2042527209 * get_m_img_4() const { return ___m_img_4; }
	inline Image_t2042527209 ** get_address_of_m_img_4() { return &___m_img_4; }
	inline void set_m_img_4(Image_t2042527209 * value)
	{
		___m_img_4 = value;
		Il2CppCodeGenWriteBarrier(&___m_img_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
