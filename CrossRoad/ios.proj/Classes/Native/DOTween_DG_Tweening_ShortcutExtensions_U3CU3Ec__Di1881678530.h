#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Object2689449295.h"

// UnityEngine.Transform
struct Transform_t3275118058;
// UnityEngine.Rigidbody
struct Rigidbody_t4233889191;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// DG.Tweening.ShortcutExtensions/<>c__DisplayClass38_0
struct  U3CU3Ec__DisplayClass38_0_t1881678530  : public Il2CppObject
{
public:
	// UnityEngine.Transform DG.Tweening.ShortcutExtensions/<>c__DisplayClass38_0::trans
	Transform_t3275118058 * ___trans_0;
	// UnityEngine.Rigidbody DG.Tweening.ShortcutExtensions/<>c__DisplayClass38_0::target
	Rigidbody_t4233889191 * ___target_1;

public:
	inline static int32_t get_offset_of_trans_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass38_0_t1881678530, ___trans_0)); }
	inline Transform_t3275118058 * get_trans_0() const { return ___trans_0; }
	inline Transform_t3275118058 ** get_address_of_trans_0() { return &___trans_0; }
	inline void set_trans_0(Transform_t3275118058 * value)
	{
		___trans_0 = value;
		Il2CppCodeGenWriteBarrier(&___trans_0, value);
	}

	inline static int32_t get_offset_of_target_1() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass38_0_t1881678530, ___target_1)); }
	inline Rigidbody_t4233889191 * get_target_1() const { return ___target_1; }
	inline Rigidbody_t4233889191 ** get_address_of_target_1() { return &___target_1; }
	inline void set_target_1(Rigidbody_t4233889191 * value)
	{
		___target_1 = value;
		Il2CppCodeGenWriteBarrier(&___target_1, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
