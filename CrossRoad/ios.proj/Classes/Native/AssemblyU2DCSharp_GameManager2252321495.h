#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "AssemblyU2DCSharp_enumGameCurrentStatus3259483858.h"
#include "AssemblyU2DCSharp_enumArrowType1171045074.h"
#include "AssemblyU2DCSharp_enumArrowDirection2592802301.h"
#include "AssemblyU2DCSharp_enumDeadType1588040869.h"

// UnityEngine.GameObject[]
struct GameObjectU5BU5D_t3057952154;
// UnityEngine.GameObject
struct GameObject_t1756533147;
// UnityEngine.Transform[]
struct TransformU5BU5D_t3764228911;
// GameManager
struct GameManager_t2252321495;
// System.Boolean[]
struct BooleanU5BU5D_t3568034315;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// GameManager
struct  GameManager_t2252321495  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.GameObject[] GameManager::m_cars
	GameObjectU5BU5D_t3057952154* ___m_cars_2;
	// UnityEngine.GameObject GameManager::m_player
	GameObject_t1756533147 * ___m_player_3;
	// UnityEngine.GameObject GameManager::m_partner
	GameObject_t1756533147 * ___m_partner_4;
	// UnityEngine.Transform[] GameManager::m_carStartPos
	TransformU5BU5D_t3764228911* ___m_carStartPos_5;
	// UnityEngine.Transform[] GameManager::m_carEndPos
	TransformU5BU5D_t3764228911* ___m_carEndPos_6;
	// UnityEngine.Transform[] GameManager::m_carPausePos
	TransformU5BU5D_t3764228911* ___m_carPausePos_7;
	// System.Boolean[] GameManager::m_isStartCreateCar
	BooleanU5BU5D_t3568034315* ___m_isStartCreateCar_9;
	// System.Single GameManager::m_maxIntervelCreatCarTime
	float ___m_maxIntervelCreatCarTime_10;
	// System.Single GameManager::m_minIntervelCreateCarTime
	float ___m_minIntervelCreateCarTime_11;
	// System.Single GameManager::m_trafficIntervelCreateCarTime
	float ___m_trafficIntervelCreateCarTime_12;
	// enumGameCurrentStatus GameManager::<currentStatus>k__BackingField
	int32_t ___U3CcurrentStatusU3Ek__BackingField_13;
	// System.Boolean GameManager::<isTrafficRed>k__BackingField
	bool ___U3CisTrafficRedU3Ek__BackingField_14;
	// System.Single GameManager::<playerDirect>k__BackingField
	float ___U3CplayerDirectU3Ek__BackingField_15;
	// enumArrowType GameManager::<currentArrowType>k__BackingField
	int32_t ___U3CcurrentArrowTypeU3Ek__BackingField_16;
	// enumArrowDirection GameManager::<currentArrowDirect>k__BackingField
	int32_t ___U3CcurrentArrowDirectU3Ek__BackingField_17;
	// enumDeadType GameManager::<deadType>k__BackingField
	int32_t ___U3CdeadTypeU3Ek__BackingField_18;
	// System.Boolean GameManager::<isOffset>k__BackingField
	bool ___U3CisOffsetU3Ek__BackingField_19;
	// System.Int32 GameManager::<currentScore>k__BackingField
	int32_t ___U3CcurrentScoreU3Ek__BackingField_20;
	// System.Boolean GameManager::m_isCameraFinish
	bool ___m_isCameraFinish_21;

public:
	inline static int32_t get_offset_of_m_cars_2() { return static_cast<int32_t>(offsetof(GameManager_t2252321495, ___m_cars_2)); }
	inline GameObjectU5BU5D_t3057952154* get_m_cars_2() const { return ___m_cars_2; }
	inline GameObjectU5BU5D_t3057952154** get_address_of_m_cars_2() { return &___m_cars_2; }
	inline void set_m_cars_2(GameObjectU5BU5D_t3057952154* value)
	{
		___m_cars_2 = value;
		Il2CppCodeGenWriteBarrier(&___m_cars_2, value);
	}

	inline static int32_t get_offset_of_m_player_3() { return static_cast<int32_t>(offsetof(GameManager_t2252321495, ___m_player_3)); }
	inline GameObject_t1756533147 * get_m_player_3() const { return ___m_player_3; }
	inline GameObject_t1756533147 ** get_address_of_m_player_3() { return &___m_player_3; }
	inline void set_m_player_3(GameObject_t1756533147 * value)
	{
		___m_player_3 = value;
		Il2CppCodeGenWriteBarrier(&___m_player_3, value);
	}

	inline static int32_t get_offset_of_m_partner_4() { return static_cast<int32_t>(offsetof(GameManager_t2252321495, ___m_partner_4)); }
	inline GameObject_t1756533147 * get_m_partner_4() const { return ___m_partner_4; }
	inline GameObject_t1756533147 ** get_address_of_m_partner_4() { return &___m_partner_4; }
	inline void set_m_partner_4(GameObject_t1756533147 * value)
	{
		___m_partner_4 = value;
		Il2CppCodeGenWriteBarrier(&___m_partner_4, value);
	}

	inline static int32_t get_offset_of_m_carStartPos_5() { return static_cast<int32_t>(offsetof(GameManager_t2252321495, ___m_carStartPos_5)); }
	inline TransformU5BU5D_t3764228911* get_m_carStartPos_5() const { return ___m_carStartPos_5; }
	inline TransformU5BU5D_t3764228911** get_address_of_m_carStartPos_5() { return &___m_carStartPos_5; }
	inline void set_m_carStartPos_5(TransformU5BU5D_t3764228911* value)
	{
		___m_carStartPos_5 = value;
		Il2CppCodeGenWriteBarrier(&___m_carStartPos_5, value);
	}

	inline static int32_t get_offset_of_m_carEndPos_6() { return static_cast<int32_t>(offsetof(GameManager_t2252321495, ___m_carEndPos_6)); }
	inline TransformU5BU5D_t3764228911* get_m_carEndPos_6() const { return ___m_carEndPos_6; }
	inline TransformU5BU5D_t3764228911** get_address_of_m_carEndPos_6() { return &___m_carEndPos_6; }
	inline void set_m_carEndPos_6(TransformU5BU5D_t3764228911* value)
	{
		___m_carEndPos_6 = value;
		Il2CppCodeGenWriteBarrier(&___m_carEndPos_6, value);
	}

	inline static int32_t get_offset_of_m_carPausePos_7() { return static_cast<int32_t>(offsetof(GameManager_t2252321495, ___m_carPausePos_7)); }
	inline TransformU5BU5D_t3764228911* get_m_carPausePos_7() const { return ___m_carPausePos_7; }
	inline TransformU5BU5D_t3764228911** get_address_of_m_carPausePos_7() { return &___m_carPausePos_7; }
	inline void set_m_carPausePos_7(TransformU5BU5D_t3764228911* value)
	{
		___m_carPausePos_7 = value;
		Il2CppCodeGenWriteBarrier(&___m_carPausePos_7, value);
	}

	inline static int32_t get_offset_of_m_isStartCreateCar_9() { return static_cast<int32_t>(offsetof(GameManager_t2252321495, ___m_isStartCreateCar_9)); }
	inline BooleanU5BU5D_t3568034315* get_m_isStartCreateCar_9() const { return ___m_isStartCreateCar_9; }
	inline BooleanU5BU5D_t3568034315** get_address_of_m_isStartCreateCar_9() { return &___m_isStartCreateCar_9; }
	inline void set_m_isStartCreateCar_9(BooleanU5BU5D_t3568034315* value)
	{
		___m_isStartCreateCar_9 = value;
		Il2CppCodeGenWriteBarrier(&___m_isStartCreateCar_9, value);
	}

	inline static int32_t get_offset_of_m_maxIntervelCreatCarTime_10() { return static_cast<int32_t>(offsetof(GameManager_t2252321495, ___m_maxIntervelCreatCarTime_10)); }
	inline float get_m_maxIntervelCreatCarTime_10() const { return ___m_maxIntervelCreatCarTime_10; }
	inline float* get_address_of_m_maxIntervelCreatCarTime_10() { return &___m_maxIntervelCreatCarTime_10; }
	inline void set_m_maxIntervelCreatCarTime_10(float value)
	{
		___m_maxIntervelCreatCarTime_10 = value;
	}

	inline static int32_t get_offset_of_m_minIntervelCreateCarTime_11() { return static_cast<int32_t>(offsetof(GameManager_t2252321495, ___m_minIntervelCreateCarTime_11)); }
	inline float get_m_minIntervelCreateCarTime_11() const { return ___m_minIntervelCreateCarTime_11; }
	inline float* get_address_of_m_minIntervelCreateCarTime_11() { return &___m_minIntervelCreateCarTime_11; }
	inline void set_m_minIntervelCreateCarTime_11(float value)
	{
		___m_minIntervelCreateCarTime_11 = value;
	}

	inline static int32_t get_offset_of_m_trafficIntervelCreateCarTime_12() { return static_cast<int32_t>(offsetof(GameManager_t2252321495, ___m_trafficIntervelCreateCarTime_12)); }
	inline float get_m_trafficIntervelCreateCarTime_12() const { return ___m_trafficIntervelCreateCarTime_12; }
	inline float* get_address_of_m_trafficIntervelCreateCarTime_12() { return &___m_trafficIntervelCreateCarTime_12; }
	inline void set_m_trafficIntervelCreateCarTime_12(float value)
	{
		___m_trafficIntervelCreateCarTime_12 = value;
	}

	inline static int32_t get_offset_of_U3CcurrentStatusU3Ek__BackingField_13() { return static_cast<int32_t>(offsetof(GameManager_t2252321495, ___U3CcurrentStatusU3Ek__BackingField_13)); }
	inline int32_t get_U3CcurrentStatusU3Ek__BackingField_13() const { return ___U3CcurrentStatusU3Ek__BackingField_13; }
	inline int32_t* get_address_of_U3CcurrentStatusU3Ek__BackingField_13() { return &___U3CcurrentStatusU3Ek__BackingField_13; }
	inline void set_U3CcurrentStatusU3Ek__BackingField_13(int32_t value)
	{
		___U3CcurrentStatusU3Ek__BackingField_13 = value;
	}

	inline static int32_t get_offset_of_U3CisTrafficRedU3Ek__BackingField_14() { return static_cast<int32_t>(offsetof(GameManager_t2252321495, ___U3CisTrafficRedU3Ek__BackingField_14)); }
	inline bool get_U3CisTrafficRedU3Ek__BackingField_14() const { return ___U3CisTrafficRedU3Ek__BackingField_14; }
	inline bool* get_address_of_U3CisTrafficRedU3Ek__BackingField_14() { return &___U3CisTrafficRedU3Ek__BackingField_14; }
	inline void set_U3CisTrafficRedU3Ek__BackingField_14(bool value)
	{
		___U3CisTrafficRedU3Ek__BackingField_14 = value;
	}

	inline static int32_t get_offset_of_U3CplayerDirectU3Ek__BackingField_15() { return static_cast<int32_t>(offsetof(GameManager_t2252321495, ___U3CplayerDirectU3Ek__BackingField_15)); }
	inline float get_U3CplayerDirectU3Ek__BackingField_15() const { return ___U3CplayerDirectU3Ek__BackingField_15; }
	inline float* get_address_of_U3CplayerDirectU3Ek__BackingField_15() { return &___U3CplayerDirectU3Ek__BackingField_15; }
	inline void set_U3CplayerDirectU3Ek__BackingField_15(float value)
	{
		___U3CplayerDirectU3Ek__BackingField_15 = value;
	}

	inline static int32_t get_offset_of_U3CcurrentArrowTypeU3Ek__BackingField_16() { return static_cast<int32_t>(offsetof(GameManager_t2252321495, ___U3CcurrentArrowTypeU3Ek__BackingField_16)); }
	inline int32_t get_U3CcurrentArrowTypeU3Ek__BackingField_16() const { return ___U3CcurrentArrowTypeU3Ek__BackingField_16; }
	inline int32_t* get_address_of_U3CcurrentArrowTypeU3Ek__BackingField_16() { return &___U3CcurrentArrowTypeU3Ek__BackingField_16; }
	inline void set_U3CcurrentArrowTypeU3Ek__BackingField_16(int32_t value)
	{
		___U3CcurrentArrowTypeU3Ek__BackingField_16 = value;
	}

	inline static int32_t get_offset_of_U3CcurrentArrowDirectU3Ek__BackingField_17() { return static_cast<int32_t>(offsetof(GameManager_t2252321495, ___U3CcurrentArrowDirectU3Ek__BackingField_17)); }
	inline int32_t get_U3CcurrentArrowDirectU3Ek__BackingField_17() const { return ___U3CcurrentArrowDirectU3Ek__BackingField_17; }
	inline int32_t* get_address_of_U3CcurrentArrowDirectU3Ek__BackingField_17() { return &___U3CcurrentArrowDirectU3Ek__BackingField_17; }
	inline void set_U3CcurrentArrowDirectU3Ek__BackingField_17(int32_t value)
	{
		___U3CcurrentArrowDirectU3Ek__BackingField_17 = value;
	}

	inline static int32_t get_offset_of_U3CdeadTypeU3Ek__BackingField_18() { return static_cast<int32_t>(offsetof(GameManager_t2252321495, ___U3CdeadTypeU3Ek__BackingField_18)); }
	inline int32_t get_U3CdeadTypeU3Ek__BackingField_18() const { return ___U3CdeadTypeU3Ek__BackingField_18; }
	inline int32_t* get_address_of_U3CdeadTypeU3Ek__BackingField_18() { return &___U3CdeadTypeU3Ek__BackingField_18; }
	inline void set_U3CdeadTypeU3Ek__BackingField_18(int32_t value)
	{
		___U3CdeadTypeU3Ek__BackingField_18 = value;
	}

	inline static int32_t get_offset_of_U3CisOffsetU3Ek__BackingField_19() { return static_cast<int32_t>(offsetof(GameManager_t2252321495, ___U3CisOffsetU3Ek__BackingField_19)); }
	inline bool get_U3CisOffsetU3Ek__BackingField_19() const { return ___U3CisOffsetU3Ek__BackingField_19; }
	inline bool* get_address_of_U3CisOffsetU3Ek__BackingField_19() { return &___U3CisOffsetU3Ek__BackingField_19; }
	inline void set_U3CisOffsetU3Ek__BackingField_19(bool value)
	{
		___U3CisOffsetU3Ek__BackingField_19 = value;
	}

	inline static int32_t get_offset_of_U3CcurrentScoreU3Ek__BackingField_20() { return static_cast<int32_t>(offsetof(GameManager_t2252321495, ___U3CcurrentScoreU3Ek__BackingField_20)); }
	inline int32_t get_U3CcurrentScoreU3Ek__BackingField_20() const { return ___U3CcurrentScoreU3Ek__BackingField_20; }
	inline int32_t* get_address_of_U3CcurrentScoreU3Ek__BackingField_20() { return &___U3CcurrentScoreU3Ek__BackingField_20; }
	inline void set_U3CcurrentScoreU3Ek__BackingField_20(int32_t value)
	{
		___U3CcurrentScoreU3Ek__BackingField_20 = value;
	}

	inline static int32_t get_offset_of_m_isCameraFinish_21() { return static_cast<int32_t>(offsetof(GameManager_t2252321495, ___m_isCameraFinish_21)); }
	inline bool get_m_isCameraFinish_21() const { return ___m_isCameraFinish_21; }
	inline bool* get_address_of_m_isCameraFinish_21() { return &___m_isCameraFinish_21; }
	inline void set_m_isCameraFinish_21(bool value)
	{
		___m_isCameraFinish_21 = value;
	}
};

struct GameManager_t2252321495_StaticFields
{
public:
	// GameManager GameManager::mInstance
	GameManager_t2252321495 * ___mInstance_8;

public:
	inline static int32_t get_offset_of_mInstance_8() { return static_cast<int32_t>(offsetof(GameManager_t2252321495_StaticFields, ___mInstance_8)); }
	inline GameManager_t2252321495 * get_mInstance_8() const { return ___mInstance_8; }
	inline GameManager_t2252321495 ** get_address_of_mInstance_8() { return &___mInstance_8; }
	inline void set_mInstance_8(GameManager_t2252321495 * value)
	{
		___mInstance_8 = value;
		Il2CppCodeGenWriteBarrier(&___mInstance_8, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
