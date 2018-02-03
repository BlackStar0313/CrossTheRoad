#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_ValueType3507792607.h"

// System.String
struct String_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// StrDatarole
struct  StrDatarole_t3653443763 
{
public:
	// System.Int32 StrDatarole::idx
	int32_t ___idx_0;
	// System.String StrDatarole::name
	String_t* ___name_1;
	// System.String StrDatarole::body_name
	String_t* ___body_name_2;
	// System.String StrDatarole::head_name
	String_t* ___head_name_3;
	// System.String StrDatarole::glass_name
	String_t* ___glass_name_4;

public:
	inline static int32_t get_offset_of_idx_0() { return static_cast<int32_t>(offsetof(StrDatarole_t3653443763, ___idx_0)); }
	inline int32_t get_idx_0() const { return ___idx_0; }
	inline int32_t* get_address_of_idx_0() { return &___idx_0; }
	inline void set_idx_0(int32_t value)
	{
		___idx_0 = value;
	}

	inline static int32_t get_offset_of_name_1() { return static_cast<int32_t>(offsetof(StrDatarole_t3653443763, ___name_1)); }
	inline String_t* get_name_1() const { return ___name_1; }
	inline String_t** get_address_of_name_1() { return &___name_1; }
	inline void set_name_1(String_t* value)
	{
		___name_1 = value;
		Il2CppCodeGenWriteBarrier(&___name_1, value);
	}

	inline static int32_t get_offset_of_body_name_2() { return static_cast<int32_t>(offsetof(StrDatarole_t3653443763, ___body_name_2)); }
	inline String_t* get_body_name_2() const { return ___body_name_2; }
	inline String_t** get_address_of_body_name_2() { return &___body_name_2; }
	inline void set_body_name_2(String_t* value)
	{
		___body_name_2 = value;
		Il2CppCodeGenWriteBarrier(&___body_name_2, value);
	}

	inline static int32_t get_offset_of_head_name_3() { return static_cast<int32_t>(offsetof(StrDatarole_t3653443763, ___head_name_3)); }
	inline String_t* get_head_name_3() const { return ___head_name_3; }
	inline String_t** get_address_of_head_name_3() { return &___head_name_3; }
	inline void set_head_name_3(String_t* value)
	{
		___head_name_3 = value;
		Il2CppCodeGenWriteBarrier(&___head_name_3, value);
	}

	inline static int32_t get_offset_of_glass_name_4() { return static_cast<int32_t>(offsetof(StrDatarole_t3653443763, ___glass_name_4)); }
	inline String_t* get_glass_name_4() const { return ___glass_name_4; }
	inline String_t** get_address_of_glass_name_4() { return &___glass_name_4; }
	inline void set_glass_name_4(String_t* value)
	{
		___glass_name_4 = value;
		Il2CppCodeGenWriteBarrier(&___glass_name_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of StrDatarole
struct StrDatarole_t3653443763_marshaled_pinvoke
{
	int32_t ___idx_0;
	char* ___name_1;
	char* ___body_name_2;
	char* ___head_name_3;
	char* ___glass_name_4;
};
// Native definition for COM marshalling of StrDatarole
struct StrDatarole_t3653443763_marshaled_com
{
	int32_t ___idx_0;
	Il2CppChar* ___name_1;
	Il2CppChar* ___body_name_2;
	Il2CppChar* ___head_name_3;
	Il2CppChar* ___glass_name_4;
};
