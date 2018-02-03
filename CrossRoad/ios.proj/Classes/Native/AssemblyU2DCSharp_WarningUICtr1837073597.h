#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// UnityEngine.UI.Image
struct Image_t2042527209;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// WarningUICtr
struct  WarningUICtr_t1837073597  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.UI.Image WarningUICtr::m_img
	Image_t2042527209 * ___m_img_2;
	// System.Boolean WarningUICtr::m_isLeft
	bool ___m_isLeft_3;

public:
	inline static int32_t get_offset_of_m_img_2() { return static_cast<int32_t>(offsetof(WarningUICtr_t1837073597, ___m_img_2)); }
	inline Image_t2042527209 * get_m_img_2() const { return ___m_img_2; }
	inline Image_t2042527209 ** get_address_of_m_img_2() { return &___m_img_2; }
	inline void set_m_img_2(Image_t2042527209 * value)
	{
		___m_img_2 = value;
		Il2CppCodeGenWriteBarrier(&___m_img_2, value);
	}

	inline static int32_t get_offset_of_m_isLeft_3() { return static_cast<int32_t>(offsetof(WarningUICtr_t1837073597, ___m_isLeft_3)); }
	inline bool get_m_isLeft_3() const { return ___m_isLeft_3; }
	inline bool* get_address_of_m_isLeft_3() { return &___m_isLeft_3; }
	inline void set_m_isLeft_3(bool value)
	{
		___m_isLeft_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
