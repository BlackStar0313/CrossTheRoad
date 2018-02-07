using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class MenuRole : BasicShowRole {
	private Animator m_animator ;
	private int c_randAniNum = 7 ;

	// Use this for initialization
	void Start () {
		m_animator = GetComponent<Animator>();

		base.ShowRole(PlayerManager.getInstance().GetPlayerInfo().currentRole);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void fadePlayer(bool isShow, float fadeTime) {
		if (isShow) {
			Vector3 endValue = this.transform.localScale;
			this.transform.localScale = new Vector3(0,0,0);
			this.transform.DOScale(endValue, fadeTime ).OnComplete(()=> doRandAct());
		}
		else {
			Vector3 endValue =  new Vector3(0,0,0) ;
			this.transform.DOScale(endValue, fadeTime );
		}
	}

	private void doRandAct() {
		int randIdx = Random.Range(1 , c_randAniNum);
		string name = "randAni"+randIdx.ToString();
		m_animator.SetTrigger(name);

		DOVirtual.DelayedCall(3f,()=> doRandAct());
	}
}
