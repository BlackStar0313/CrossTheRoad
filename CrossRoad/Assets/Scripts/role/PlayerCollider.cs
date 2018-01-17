using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : BasicCollider {

	void Awake()
	{
		this.m_deadHeight = 0.6f;
	}
}
