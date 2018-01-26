using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleSwtichModle : MonoBehaviour {
	private string m_currentBodyName = "Body_33_punk_D";
	private string m_currentHeadName = "head_64_punk_C";
	private string m_prefix = "Bip001/Bip001 Pelvis/Bip001 Spine/Bip001 Neck/Bip001 Head/HEAD_CONTAINER/";

	private string testBody1 = "Body_31_punk_B";
	private string testHead1 = "head_62_punk_A";

	void Start()
	{
		GameObject bodyObj = gameObject.transform.Find(m_currentBodyName).gameObject;
		GameObject headObj = gameObject.transform.Find(m_prefix + m_currentHeadName).gameObject;
		bodyObj.SetActive(false);
		headObj.SetActive(false);

		GameObject bodyObj1 = gameObject.transform.Find(testBody1).gameObject;
		GameObject headObj1 = gameObject.transform.Find(m_prefix + testHead1).gameObject;
		bodyObj1.SetActive(true);
		headObj1.SetActive(true);
		Debug.Log("");
	}
}
