using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleSwtichModle : BasicShowRole {
	void Start()
	{
		base.ShowRole(PlayerManager.getInstance().GetPlayerInfo().currentRole);
	}
}
