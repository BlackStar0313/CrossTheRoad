using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraCtr : MonoBehaviour {
	public Camera m_Camera;

	private float m_farFiledOfView = 75f;
	private float m_nearFiledOfView = 60f;
	private float m_actTime = 2.5f;
	private void Awake()
    {
        m_Camera = GetComponentInChildren<Camera>();
		m_Camera.fieldOfView = m_farFiledOfView;
    }

	public void DoBeginAct() {
		m_Camera.DOFieldOfView( m_nearFiledOfView,m_actTime);
	}
}
