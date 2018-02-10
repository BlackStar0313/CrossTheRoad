using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnter : MonoBehaviour {
	public GameInstantManager m_gameManager;
	void Awake()
	{
		if (GameInstantManager.mInstance == null) {
			GameInstantManager obj = Instantiate(m_gameManager) as GameInstantManager;
			GameInstantManager.mInstance = obj;
		}
	}
}
