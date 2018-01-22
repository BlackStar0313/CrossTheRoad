using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WarningUICtr : MonoBehaviour {
	public Image m_img ; 
	private bool m_isLeft = false ; 

	public void init(bool isLeft) {
		this.m_isLeft = isLeft ; 

		float posX = m_isLeft ? -Screen.width/2 : Screen.width/2;
		m_img.transform.position = new Vector3(posX,0,0);

		StartCoroutine(waitForDestory());
	}

	IEnumerator waitForDestory() {
		yield return new WaitForSeconds(0.3f); 

		this.OnDestroy();
	}

	void OnDestroy()
	{
		gameObject.SetActive(false);
		Destroy(gameObject);
	}
}
