using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Events;

public class CameraCtr : MonoBehaviour {
	public Camera m_Camera;

	private float m_farFiledOfView = 85f;
	private float m_nearFiledOfView = 60f;
	private float m_actTime = 1.5f;
	private void Awake()
    {
        m_Camera = GetComponentInChildren<Camera>();
		m_Camera.fieldOfView = m_farFiledOfView;
    }

	public void DoBeginAct(UnityAction callback) {
		m_Camera.DOFieldOfView( m_nearFiledOfView,m_actTime).OnComplete(()=> {
			callback.Invoke();
		});
	}
}
