using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class WarningUICtr : MonoBehaviour {
	public Image m_img ; 
	private bool m_isLeft = false ; 

	public void init(bool isLeft) {
		this.m_isLeft = isLeft ; 

		float posX = m_isLeft ? -Screen.width/2 : Screen.width/2;
		m_img.transform.position = new Vector3(posX,0,0);

		StartCoroutine(waitForDestory());
		this.doAction();
	}

	IEnumerator waitForDestory() {
		yield return new WaitForSeconds(0.4f); 

		this.OnDestroy();
	}

	void OnDestroy()
	{
		gameObject.SetActive(false);
		Destroy(gameObject);
	}

	void doAction() {
		m_img.color = new Color(m_img.color.r,m_img.color.g, m_img.color.b , 0);
		DOTween.ToAlpha(()=> m_img.color , x=> m_img.color = x , 0.8f , 0.1f ).SetLoops(4, LoopType.Yoyo);
	}
}
