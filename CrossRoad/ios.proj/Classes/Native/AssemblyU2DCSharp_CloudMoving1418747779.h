#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "AssemblyU2DCSharp_enumFrogActionType3773097731.h"

// System.Collections.Generic.List`1<UnityEngine.UI.Image>
struct List_1_t1411648341;
// UnityEngine.UI.Image
struct Image_t2042527209;
// System.Collections.Generic.List`1<UnityEngine.Vector3>
struct List_1_t1612828712;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// CloudMoving
struct  CloudMoving_t1418747779  : public MonoBehaviour_t1158329972
{
public:
	// System.Collections.Generic.List`1<UnityEngine.UI.Image> CloudMoving::m_cloudList
	List_1_t1411648341 * ___m_cloudList_2;
	// UnityEngine.UI.Image CloudMoving::m_cloudCenter
	Image_t2042527209 * ___m_cloudCenter_3;
	// System.Collections.Generic.List`1<UnityEngine.Vector3> CloudMoving::m_startPos
	List_1_t1612828712 * ___m_startPos_4;
	// System.Collections.Generic.List`1<UnityEngine.Vector3> CloudMoving::m_endPos
	List_1_t1612828712 * ___m_endPos_5;
	// System.Single CloudMoving::m_endScale
	float ___m_endScale_6;
	// System.Single CloudMoving::m_actionTime
	float ___m_actionTime_7;
	// System.Single CloudMoving::m_moveDist
	float ___m_moveDist_8;
	// enumFrogActionType CloudMoving::m_frogActType
	int32_t ___m_frogActType_9;

public:
	inline static int32_t get_offset_of_m_cloudList_2() { return static_cast<int32_t>(offsetof(CloudMoving_t1418747779, ___m_cloudList_2)); }
	inline List_1_t1411648341 * get_m_cloudList_2() const { return ___m_cloudList_2; }
	inline List_1_t1411648341 ** get_address_of_m_cloudList_2() { return &___m_cloudList_2; }
	inline void set_m_cloudList_2(List_1_t1411648341 * value)
	{
		___m_cloudList_2 = value;
		Il2CppCodeGenWriteBarrier(&___m_cloudList_2, value);
	}

	inline static int32_t get_offset_of_m_cloudCenter_3() { return static_cast<int32_t>(offsetof(CloudMoving_t1418747779, ___m_cloudCenter_3)); }
	inline Image_t2042527209 * get_m_cloudCenter_3() const { return ___m_cloudCenter_3; }
	inline Image_t2042527209 ** get_address_of_m_cloudCenter_3() { return &___m_cloudCenter_3; }
	inline void set_m_cloudCenter_3(Image_t2042527209 * value)
	{
		___m_cloudCenter_3 = value;
		Il2CppCodeGenWriteBarrier(&___m_cloudCenter_3, value);
	}

	inline static int32_t get_offset_of_m_startPos_4() { return static_cast<int32_t>(offsetof(CloudMoving_t1418747779, ___m_startPos_4)); }
	inline List_1_t1612828712 * get_m_startPos_4() const { return ___m_startPos_4; }
	inline List_1_t1612828712 ** get_address_of_m_startPos_4() { return &___m_startPos_4; }
	inline void set_m_startPos_4(List_1_t1612828712 * value)
	{
		___m_startPos_4 = value;
		Il2CppCodeGenWriteBarrier(&___m_startPos_4, value);
	}

	inline static int32_t get_offset_of_m_endPos_5() { return static_cast<int32_t>(offsetof(CloudMoving_t1418747779, ___m_endPos_5)); }
	inline List_1_t1612828712 * get_m_endPos_5() const { return ___m_endPos_5; }
	inline List_1_t1612828712 ** get_address_of_m_endPos_5() { return &___m_endPos_5; }
	inline void set_m_endPos_5(List_1_t1612828712 * value)
	{
		___m_endPos_5 = value;
		Il2CppCodeGenWriteBarrier(&___m_endPos_5, value);
	}

	inline static int32_t get_offset_of_m_endScale_6() { return static_cast<int32_t>(offsetof(CloudMoving_t1418747779, ___m_endScale_6)); }
	inline float get_m_endScale_6() const { return ___m_endScale_6; }
	inline float* get_address_of_m_endScale_6() { return &___m_endScale_6; }
	inline void set_m_endScale_6(float value)
	{
		___m_endScale_6 = value;
	}

	inline static int32_t get_offset_of_m_actionTime_7() { return static_cast<int32_t>(offsetof(CloudMoving_t1418747779, ___m_actionTime_7)); }
	inline float get_m_actionTime_7() const { return ___m_actionTime_7; }
	inline float* get_address_of_m_actionTime_7() { return &___m_actionTime_7; }
	inline void set_m_actionTime_7(float value)
	{
		___m_actionTime_7 = value;
	}

	inline static int32_t get_offset_of_m_moveDist_8() { return static_cast<int32_t>(offsetof(CloudMoving_t1418747779, ___m_moveDist_8)); }
	inline float get_m_moveDist_8() const { return ___m_moveDist_8; }
	inline float* get_address_of_m_moveDist_8() { return &___m_moveDist_8; }
	inline void set_m_moveDist_8(float value)
	{
		___m_moveDist_8 = value;
	}

	inline static int32_t get_offset_of_m_frogActType_9() { return static_cast<int32_t>(offsetof(CloudMoving_t1418747779, ___m_frogActType_9)); }
	inline int32_t get_m_frogActType_9() const { return ___m_frogActType_9; }
	inline int32_t* get_address_of_m_frogActType_9() { return &___m_frogActType_9; }
	inline void set_m_frogActType_9(int32_t value)
	{
		___m_frogActType_9 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
