using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicController : MonoBehaviour {

	public void HandleDead() {
		this.GetComponent<Animator>().SetTrigger("player_die");
	}
}
