using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItemRole : MonoBehaviour {
	private string m_currentBodyName = "Body_33_punk_D";
	private string m_currentHeadName = "head_64_punk_C";
	private string m_prefix = "Bip001/Bip001 Pelvis/Bip001 Spine/Bip001 Neck/Bip001 Head/HEAD_CONTAINER/";


	void Start()
	{

	}

	public void HandleInit(int roleIdx) {
		GameObject bodyObj = gameObject.transform.Find(m_currentBodyName).gameObject;
		GameObject headObj = gameObject.transform.Find(m_prefix + m_currentHeadName).gameObject;


		StrDatarole roleData = DataManager.getInstance().GetRoleDataByIdx(roleIdx);
		try
		{
			//TODO: 先这么处理下
			if (m_currentBodyName != roleData.body_name) {
				bodyObj.SetActive(false);
			}
			if (m_currentHeadName != roleData.head_name) {
				headObj.SetActive(false);
			}

			GameObject bodyObj1 = gameObject.transform.Find(roleData.body_name).gameObject;
			GameObject headObj1 = gameObject.transform.Find(m_prefix + roleData.head_name).gameObject;
			bodyObj1.SetActive(true);
			headObj1.SetActive(true);
			

			if (roleData.glass_name != "") {
				Transform glassTrans = gameObject.transform.Find(m_prefix + roleData.glass_name);
				if (glassTrans != null) {
					glassTrans.gameObject.SetActive(true);
				}
			}
		}
		catch (System.Exception)
		{
			Debug.LogError("wrong data ");
			throw;
		}
	}

	public void handleAnimation(bool isIdle) {
		Animator ani = this.gameObject.GetComponent<Animator>();
		if (isIdle) {
			ani.SetTrigger("idle");
			Debug.Log("~~~~~  ani.SetTrigger  idle ");
		}
		else {
			int randIdx = Random.Range(1 , 4 );
			string name = "activity" + randIdx.ToString();
			ani.SetTrigger(name);
		}
	}
}
