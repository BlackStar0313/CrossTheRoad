using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleSwtichModle : MonoBehaviour {
	private string m_currentBodyName = "Body_33_punk_D";
	private string m_currentHeadName = "head_64_punk_C";
	private string m_prefix = "Bip001/Bip001 Pelvis/Bip001 Spine/Bip001 Neck/Bip001 Head/HEAD_CONTAINER/";


	void Start()
	{
		GameObject bodyObj = gameObject.transform.Find(m_currentBodyName).gameObject;
		GameObject headObj = gameObject.transform.Find(m_prefix + m_currentHeadName).gameObject;
		bodyObj.SetActive(false);
		headObj.SetActive(false);

		StrDatarole? roleData = DataManager.getInstance().GetRoleDataByIdx(PlayerManager.getInstance().GetPlayerInfo().currentRole);
		if (!roleData.HasValue) {
			Debug.LogError("wrong data");
			return ; 
		}
		StrDatarole data = roleData.GetValueOrDefault();

		GameObject bodyObj1 = gameObject.transform.Find(data.body_name).gameObject;
		GameObject headObj1 = gameObject.transform.Find(m_prefix + data.head_name).gameObject;
		bodyObj1.SetActive(true);
		headObj1.SetActive(true);
		Debug.Log("");
	}
}
