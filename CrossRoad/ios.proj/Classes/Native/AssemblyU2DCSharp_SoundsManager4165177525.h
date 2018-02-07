#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// System.String
struct String_t;
// SoundsManager
struct SoundsManager_t4165177525;
// UnityEngine.AudioSource
struct AudioSource_t1135106623;
// UnityEngine.AudioClip
struct AudioClip_t1932558630;
// UnityEngine.AudioClip[]
struct AudioClipU5BU5D_t2203355011;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// SoundsManager
struct  SoundsManager_t4165177525  : public MonoBehaviour_t1158329972
{
public:
	// System.String SoundsManager::c_localMusicName
	String_t* ___c_localMusicName_2;
	// System.String SoundsManager::c_localSoundsName
	String_t* ___c_localSoundsName_3;
	// UnityEngine.AudioSource SoundsManager::m_audio
	AudioSource_t1135106623 * ___m_audio_18;
	// UnityEngine.AudioSource SoundsManager::m_music
	AudioSource_t1135106623 * ___m_music_19;
	// UnityEngine.AudioClip SoundsManager::m_clipClick
	AudioClip_t1932558630 * ___m_clipClick_20;
	// UnityEngine.AudioClip SoundsManager::m_clipNegtive
	AudioClip_t1932558630 * ___m_clipNegtive_21;
	// UnityEngine.AudioClip SoundsManager::m_clipScroll
	AudioClip_t1932558630 * ___m_clipScroll_22;
	// UnityEngine.AudioClip SoundsManager::m_clipBuy
	AudioClip_t1932558630 * ___m_clipBuy_23;
	// UnityEngine.AudioClip SoundsManager::m_clipGetHeart
	AudioClip_t1932558630 * ___m_clipGetHeart_24;
	// UnityEngine.AudioClip SoundsManager::m_clipAddHeart
	AudioClip_t1932558630 * ___m_clipAddHeart_25;
	// UnityEngine.AudioClip SoundsManager::m_moveWrong
	AudioClip_t1932558630 * ___m_moveWrong_26;
	// UnityEngine.AudioClip[] SoundsManager::m_shopItemIdles
	AudioClipU5BU5D_t2203355011* ___m_shopItemIdles_27;
	// UnityEngine.AudioClip SoundsManager::m_clipMenu
	AudioClip_t1932558630 * ___m_clipMenu_28;
	// UnityEngine.AudioClip[] SoundsManager::m_clipGameBgs
	AudioClipU5BU5D_t2203355011* ___m_clipGameBgs_29;
	// UnityEngine.AudioClip SoundsManager::m_clipShop
	AudioClip_t1932558630 * ___m_clipShop_30;
	// UnityEngine.AudioClip SoundsManager::m_clipReadyGo
	AudioClip_t1932558630 * ___m_clipReadyGo_31;
	// UnityEngine.AudioClip[] SoundsManager::m_clipGameOver
	AudioClipU5BU5D_t2203355011* ___m_clipGameOver_32;
	// System.Boolean SoundsManager::<isSoundsOff>k__BackingField
	bool ___U3CisSoundsOffU3Ek__BackingField_33;
	// System.Boolean SoundsManager::<isMusicOff>k__BackingField
	bool ___U3CisMusicOffU3Ek__BackingField_34;

public:
	inline static int32_t get_offset_of_c_localMusicName_2() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525, ___c_localMusicName_2)); }
	inline String_t* get_c_localMusicName_2() const { return ___c_localMusicName_2; }
	inline String_t** get_address_of_c_localMusicName_2() { return &___c_localMusicName_2; }
	inline void set_c_localMusicName_2(String_t* value)
	{
		___c_localMusicName_2 = value;
		Il2CppCodeGenWriteBarrier(&___c_localMusicName_2, value);
	}

	inline static int32_t get_offset_of_c_localSoundsName_3() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525, ___c_localSoundsName_3)); }
	inline String_t* get_c_localSoundsName_3() const { return ___c_localSoundsName_3; }
	inline String_t** get_address_of_c_localSoundsName_3() { return &___c_localSoundsName_3; }
	inline void set_c_localSoundsName_3(String_t* value)
	{
		___c_localSoundsName_3 = value;
		Il2CppCodeGenWriteBarrier(&___c_localSoundsName_3, value);
	}

	inline static int32_t get_offset_of_m_audio_18() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525, ___m_audio_18)); }
	inline AudioSource_t1135106623 * get_m_audio_18() const { return ___m_audio_18; }
	inline AudioSource_t1135106623 ** get_address_of_m_audio_18() { return &___m_audio_18; }
	inline void set_m_audio_18(AudioSource_t1135106623 * value)
	{
		___m_audio_18 = value;
		Il2CppCodeGenWriteBarrier(&___m_audio_18, value);
	}

	inline static int32_t get_offset_of_m_music_19() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525, ___m_music_19)); }
	inline AudioSource_t1135106623 * get_m_music_19() const { return ___m_music_19; }
	inline AudioSource_t1135106623 ** get_address_of_m_music_19() { return &___m_music_19; }
	inline void set_m_music_19(AudioSource_t1135106623 * value)
	{
		___m_music_19 = value;
		Il2CppCodeGenWriteBarrier(&___m_music_19, value);
	}

	inline static int32_t get_offset_of_m_clipClick_20() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525, ___m_clipClick_20)); }
	inline AudioClip_t1932558630 * get_m_clipClick_20() const { return ___m_clipClick_20; }
	inline AudioClip_t1932558630 ** get_address_of_m_clipClick_20() { return &___m_clipClick_20; }
	inline void set_m_clipClick_20(AudioClip_t1932558630 * value)
	{
		___m_clipClick_20 = value;
		Il2CppCodeGenWriteBarrier(&___m_clipClick_20, value);
	}

	inline static int32_t get_offset_of_m_clipNegtive_21() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525, ___m_clipNegtive_21)); }
	inline AudioClip_t1932558630 * get_m_clipNegtive_21() const { return ___m_clipNegtive_21; }
	inline AudioClip_t1932558630 ** get_address_of_m_clipNegtive_21() { return &___m_clipNegtive_21; }
	inline void set_m_clipNegtive_21(AudioClip_t1932558630 * value)
	{
		___m_clipNegtive_21 = value;
		Il2CppCodeGenWriteBarrier(&___m_clipNegtive_21, value);
	}

	inline static int32_t get_offset_of_m_clipScroll_22() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525, ___m_clipScroll_22)); }
	inline AudioClip_t1932558630 * get_m_clipScroll_22() const { return ___m_clipScroll_22; }
	inline AudioClip_t1932558630 ** get_address_of_m_clipScroll_22() { return &___m_clipScroll_22; }
	inline void set_m_clipScroll_22(AudioClip_t1932558630 * value)
	{
		___m_clipScroll_22 = value;
		Il2CppCodeGenWriteBarrier(&___m_clipScroll_22, value);
	}

	inline static int32_t get_offset_of_m_clipBuy_23() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525, ___m_clipBuy_23)); }
	inline AudioClip_t1932558630 * get_m_clipBuy_23() const { return ___m_clipBuy_23; }
	inline AudioClip_t1932558630 ** get_address_of_m_clipBuy_23() { return &___m_clipBuy_23; }
	inline void set_m_clipBuy_23(AudioClip_t1932558630 * value)
	{
		___m_clipBuy_23 = value;
		Il2CppCodeGenWriteBarrier(&___m_clipBuy_23, value);
	}

	inline static int32_t get_offset_of_m_clipGetHeart_24() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525, ___m_clipGetHeart_24)); }
	inline AudioClip_t1932558630 * get_m_clipGetHeart_24() const { return ___m_clipGetHeart_24; }
	inline AudioClip_t1932558630 ** get_address_of_m_clipGetHeart_24() { return &___m_clipGetHeart_24; }
	inline void set_m_clipGetHeart_24(AudioClip_t1932558630 * value)
	{
		___m_clipGetHeart_24 = value;
		Il2CppCodeGenWriteBarrier(&___m_clipGetHeart_24, value);
	}

	inline static int32_t get_offset_of_m_clipAddHeart_25() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525, ___m_clipAddHeart_25)); }
	inline AudioClip_t1932558630 * get_m_clipAddHeart_25() const { return ___m_clipAddHeart_25; }
	inline AudioClip_t1932558630 ** get_address_of_m_clipAddHeart_25() { return &___m_clipAddHeart_25; }
	inline void set_m_clipAddHeart_25(AudioClip_t1932558630 * value)
	{
		___m_clipAddHeart_25 = value;
		Il2CppCodeGenWriteBarrier(&___m_clipAddHeart_25, value);
	}

	inline static int32_t get_offset_of_m_moveWrong_26() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525, ___m_moveWrong_26)); }
	inline AudioClip_t1932558630 * get_m_moveWrong_26() const { return ___m_moveWrong_26; }
	inline AudioClip_t1932558630 ** get_address_of_m_moveWrong_26() { return &___m_moveWrong_26; }
	inline void set_m_moveWrong_26(AudioClip_t1932558630 * value)
	{
		___m_moveWrong_26 = value;
		Il2CppCodeGenWriteBarrier(&___m_moveWrong_26, value);
	}

	inline static int32_t get_offset_of_m_shopItemIdles_27() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525, ___m_shopItemIdles_27)); }
	inline AudioClipU5BU5D_t2203355011* get_m_shopItemIdles_27() const { return ___m_shopItemIdles_27; }
	inline AudioClipU5BU5D_t2203355011** get_address_of_m_shopItemIdles_27() { return &___m_shopItemIdles_27; }
	inline void set_m_shopItemIdles_27(AudioClipU5BU5D_t2203355011* value)
	{
		___m_shopItemIdles_27 = value;
		Il2CppCodeGenWriteBarrier(&___m_shopItemIdles_27, value);
	}

	inline static int32_t get_offset_of_m_clipMenu_28() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525, ___m_clipMenu_28)); }
	inline AudioClip_t1932558630 * get_m_clipMenu_28() const { return ___m_clipMenu_28; }
	inline AudioClip_t1932558630 ** get_address_of_m_clipMenu_28() { return &___m_clipMenu_28; }
	inline void set_m_clipMenu_28(AudioClip_t1932558630 * value)
	{
		___m_clipMenu_28 = value;
		Il2CppCodeGenWriteBarrier(&___m_clipMenu_28, value);
	}

	inline static int32_t get_offset_of_m_clipGameBgs_29() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525, ___m_clipGameBgs_29)); }
	inline AudioClipU5BU5D_t2203355011* get_m_clipGameBgs_29() const { return ___m_clipGameBgs_29; }
	inline AudioClipU5BU5D_t2203355011** get_address_of_m_clipGameBgs_29() { return &___m_clipGameBgs_29; }
	inline void set_m_clipGameBgs_29(AudioClipU5BU5D_t2203355011* value)
	{
		___m_clipGameBgs_29 = value;
		Il2CppCodeGenWriteBarrier(&___m_clipGameBgs_29, value);
	}

	inline static int32_t get_offset_of_m_clipShop_30() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525, ___m_clipShop_30)); }
	inline AudioClip_t1932558630 * get_m_clipShop_30() const { return ___m_clipShop_30; }
	inline AudioClip_t1932558630 ** get_address_of_m_clipShop_30() { return &___m_clipShop_30; }
	inline void set_m_clipShop_30(AudioClip_t1932558630 * value)
	{
		___m_clipShop_30 = value;
		Il2CppCodeGenWriteBarrier(&___m_clipShop_30, value);
	}

	inline static int32_t get_offset_of_m_clipReadyGo_31() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525, ___m_clipReadyGo_31)); }
	inline AudioClip_t1932558630 * get_m_clipReadyGo_31() const { return ___m_clipReadyGo_31; }
	inline AudioClip_t1932558630 ** get_address_of_m_clipReadyGo_31() { return &___m_clipReadyGo_31; }
	inline void set_m_clipReadyGo_31(AudioClip_t1932558630 * value)
	{
		___m_clipReadyGo_31 = value;
		Il2CppCodeGenWriteBarrier(&___m_clipReadyGo_31, value);
	}

	inline static int32_t get_offset_of_m_clipGameOver_32() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525, ___m_clipGameOver_32)); }
	inline AudioClipU5BU5D_t2203355011* get_m_clipGameOver_32() const { return ___m_clipGameOver_32; }
	inline AudioClipU5BU5D_t2203355011** get_address_of_m_clipGameOver_32() { return &___m_clipGameOver_32; }
	inline void set_m_clipGameOver_32(AudioClipU5BU5D_t2203355011* value)
	{
		___m_clipGameOver_32 = value;
		Il2CppCodeGenWriteBarrier(&___m_clipGameOver_32, value);
	}

	inline static int32_t get_offset_of_U3CisSoundsOffU3Ek__BackingField_33() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525, ___U3CisSoundsOffU3Ek__BackingField_33)); }
	inline bool get_U3CisSoundsOffU3Ek__BackingField_33() const { return ___U3CisSoundsOffU3Ek__BackingField_33; }
	inline bool* get_address_of_U3CisSoundsOffU3Ek__BackingField_33() { return &___U3CisSoundsOffU3Ek__BackingField_33; }
	inline void set_U3CisSoundsOffU3Ek__BackingField_33(bool value)
	{
		___U3CisSoundsOffU3Ek__BackingField_33 = value;
	}

	inline static int32_t get_offset_of_U3CisMusicOffU3Ek__BackingField_34() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525, ___U3CisMusicOffU3Ek__BackingField_34)); }
	inline bool get_U3CisMusicOffU3Ek__BackingField_34() const { return ___U3CisMusicOffU3Ek__BackingField_34; }
	inline bool* get_address_of_U3CisMusicOffU3Ek__BackingField_34() { return &___U3CisMusicOffU3Ek__BackingField_34; }
	inline void set_U3CisMusicOffU3Ek__BackingField_34(bool value)
	{
		___U3CisMusicOffU3Ek__BackingField_34 = value;
	}
};

struct SoundsManager_t4165177525_StaticFields
{
public:
	// System.String SoundsManager::clipNameClick
	String_t* ___clipNameClick_4;
	// System.String SoundsManager::clipNameClickNegtive
	String_t* ___clipNameClickNegtive_5;
	// System.String SoundsManager::clipNameScroll
	String_t* ___clipNameScroll_6;
	// System.String SoundsManager::clipNameBuy
	String_t* ___clipNameBuy_7;
	// System.String SoundsManager::clipNameGetHeart
	String_t* ___clipNameGetHeart_8;
	// System.String SoundsManager::clipNameAddHeart
	String_t* ___clipNameAddHeart_9;
	// System.String SoundsManager::clipNameMoveWrong
	String_t* ___clipNameMoveWrong_10;
	// System.String SoundsManager::clipNameShopItemIdle
	String_t* ___clipNameShopItemIdle_11;
	// System.String SoundsManager::clipNameMenu
	String_t* ___clipNameMenu_12;
	// System.String SoundsManager::clipNameGameBg
	String_t* ___clipNameGameBg_13;
	// System.String SoundsManager::clipNameShop
	String_t* ___clipNameShop_14;
	// System.String SoundsManager::clipNameReadyGo
	String_t* ___clipNameReadyGo_15;
	// System.String SoundsManager::clipNameGameOver
	String_t* ___clipNameGameOver_16;
	// SoundsManager SoundsManager::mInstance
	SoundsManager_t4165177525 * ___mInstance_17;

public:
	inline static int32_t get_offset_of_clipNameClick_4() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525_StaticFields, ___clipNameClick_4)); }
	inline String_t* get_clipNameClick_4() const { return ___clipNameClick_4; }
	inline String_t** get_address_of_clipNameClick_4() { return &___clipNameClick_4; }
	inline void set_clipNameClick_4(String_t* value)
	{
		___clipNameClick_4 = value;
		Il2CppCodeGenWriteBarrier(&___clipNameClick_4, value);
	}

	inline static int32_t get_offset_of_clipNameClickNegtive_5() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525_StaticFields, ___clipNameClickNegtive_5)); }
	inline String_t* get_clipNameClickNegtive_5() const { return ___clipNameClickNegtive_5; }
	inline String_t** get_address_of_clipNameClickNegtive_5() { return &___clipNameClickNegtive_5; }
	inline void set_clipNameClickNegtive_5(String_t* value)
	{
		___clipNameClickNegtive_5 = value;
		Il2CppCodeGenWriteBarrier(&___clipNameClickNegtive_5, value);
	}

	inline static int32_t get_offset_of_clipNameScroll_6() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525_StaticFields, ___clipNameScroll_6)); }
	inline String_t* get_clipNameScroll_6() const { return ___clipNameScroll_6; }
	inline String_t** get_address_of_clipNameScroll_6() { return &___clipNameScroll_6; }
	inline void set_clipNameScroll_6(String_t* value)
	{
		___clipNameScroll_6 = value;
		Il2CppCodeGenWriteBarrier(&___clipNameScroll_6, value);
	}

	inline static int32_t get_offset_of_clipNameBuy_7() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525_StaticFields, ___clipNameBuy_7)); }
	inline String_t* get_clipNameBuy_7() const { return ___clipNameBuy_7; }
	inline String_t** get_address_of_clipNameBuy_7() { return &___clipNameBuy_7; }
	inline void set_clipNameBuy_7(String_t* value)
	{
		___clipNameBuy_7 = value;
		Il2CppCodeGenWriteBarrier(&___clipNameBuy_7, value);
	}

	inline static int32_t get_offset_of_clipNameGetHeart_8() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525_StaticFields, ___clipNameGetHeart_8)); }
	inline String_t* get_clipNameGetHeart_8() const { return ___clipNameGetHeart_8; }
	inline String_t** get_address_of_clipNameGetHeart_8() { return &___clipNameGetHeart_8; }
	inline void set_clipNameGetHeart_8(String_t* value)
	{
		___clipNameGetHeart_8 = value;
		Il2CppCodeGenWriteBarrier(&___clipNameGetHeart_8, value);
	}

	inline static int32_t get_offset_of_clipNameAddHeart_9() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525_StaticFields, ___clipNameAddHeart_9)); }
	inline String_t* get_clipNameAddHeart_9() const { return ___clipNameAddHeart_9; }
	inline String_t** get_address_of_clipNameAddHeart_9() { return &___clipNameAddHeart_9; }
	inline void set_clipNameAddHeart_9(String_t* value)
	{
		___clipNameAddHeart_9 = value;
		Il2CppCodeGenWriteBarrier(&___clipNameAddHeart_9, value);
	}

	inline static int32_t get_offset_of_clipNameMoveWrong_10() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525_StaticFields, ___clipNameMoveWrong_10)); }
	inline String_t* get_clipNameMoveWrong_10() const { return ___clipNameMoveWrong_10; }
	inline String_t** get_address_of_clipNameMoveWrong_10() { return &___clipNameMoveWrong_10; }
	inline void set_clipNameMoveWrong_10(String_t* value)
	{
		___clipNameMoveWrong_10 = value;
		Il2CppCodeGenWriteBarrier(&___clipNameMoveWrong_10, value);
	}

	inline static int32_t get_offset_of_clipNameShopItemIdle_11() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525_StaticFields, ___clipNameShopItemIdle_11)); }
	inline String_t* get_clipNameShopItemIdle_11() const { return ___clipNameShopItemIdle_11; }
	inline String_t** get_address_of_clipNameShopItemIdle_11() { return &___clipNameShopItemIdle_11; }
	inline void set_clipNameShopItemIdle_11(String_t* value)
	{
		___clipNameShopItemIdle_11 = value;
		Il2CppCodeGenWriteBarrier(&___clipNameShopItemIdle_11, value);
	}

	inline static int32_t get_offset_of_clipNameMenu_12() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525_StaticFields, ___clipNameMenu_12)); }
	inline String_t* get_clipNameMenu_12() const { return ___clipNameMenu_12; }
	inline String_t** get_address_of_clipNameMenu_12() { return &___clipNameMenu_12; }
	inline void set_clipNameMenu_12(String_t* value)
	{
		___clipNameMenu_12 = value;
		Il2CppCodeGenWriteBarrier(&___clipNameMenu_12, value);
	}

	inline static int32_t get_offset_of_clipNameGameBg_13() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525_StaticFields, ___clipNameGameBg_13)); }
	inline String_t* get_clipNameGameBg_13() const { return ___clipNameGameBg_13; }
	inline String_t** get_address_of_clipNameGameBg_13() { return &___clipNameGameBg_13; }
	inline void set_clipNameGameBg_13(String_t* value)
	{
		___clipNameGameBg_13 = value;
		Il2CppCodeGenWriteBarrier(&___clipNameGameBg_13, value);
	}

	inline static int32_t get_offset_of_clipNameShop_14() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525_StaticFields, ___clipNameShop_14)); }
	inline String_t* get_clipNameShop_14() const { return ___clipNameShop_14; }
	inline String_t** get_address_of_clipNameShop_14() { return &___clipNameShop_14; }
	inline void set_clipNameShop_14(String_t* value)
	{
		___clipNameShop_14 = value;
		Il2CppCodeGenWriteBarrier(&___clipNameShop_14, value);
	}

	inline static int32_t get_offset_of_clipNameReadyGo_15() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525_StaticFields, ___clipNameReadyGo_15)); }
	inline String_t* get_clipNameReadyGo_15() const { return ___clipNameReadyGo_15; }
	inline String_t** get_address_of_clipNameReadyGo_15() { return &___clipNameReadyGo_15; }
	inline void set_clipNameReadyGo_15(String_t* value)
	{
		___clipNameReadyGo_15 = value;
		Il2CppCodeGenWriteBarrier(&___clipNameReadyGo_15, value);
	}

	inline static int32_t get_offset_of_clipNameGameOver_16() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525_StaticFields, ___clipNameGameOver_16)); }
	inline String_t* get_clipNameGameOver_16() const { return ___clipNameGameOver_16; }
	inline String_t** get_address_of_clipNameGameOver_16() { return &___clipNameGameOver_16; }
	inline void set_clipNameGameOver_16(String_t* value)
	{
		___clipNameGameOver_16 = value;
		Il2CppCodeGenWriteBarrier(&___clipNameGameOver_16, value);
	}

	inline static int32_t get_offset_of_mInstance_17() { return static_cast<int32_t>(offsetof(SoundsManager_t4165177525_StaticFields, ___mInstance_17)); }
	inline SoundsManager_t4165177525 * get_mInstance_17() const { return ___mInstance_17; }
	inline SoundsManager_t4165177525 ** get_address_of_mInstance_17() { return &___mInstance_17; }
	inline void set_mInstance_17(SoundsManager_t4165177525 * value)
	{
		___mInstance_17 = value;
		Il2CppCodeGenWriteBarrier(&___mInstance_17, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
