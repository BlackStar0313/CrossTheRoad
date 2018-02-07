using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItemRole : BasicShowRole {
	void Start()
	{

	}

	public void HandleInit(int roleIdx) {
		base.ShowRole(roleIdx);
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
