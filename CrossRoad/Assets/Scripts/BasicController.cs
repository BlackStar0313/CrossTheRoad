using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicController : MonoBehaviour {
	[HideInInspector] public Animator m_animator;

	protected virtual void Awake()
	{
		m_animator = GetComponent<Animator>();
	} 


	public virtual void HandleDead() {
		m_animator.SetTrigger("player_die");
	}

	public virtual void HandleStartMove() {
		m_animator.SetTrigger("player_run");
	}

	public virtual void HandleStopMove() {
		m_animator.SetTrigger("player_idle");
	}
}
