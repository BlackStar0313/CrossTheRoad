using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicController : MonoBehaviour {
	[HideInInspector] public Animator m_animator;

	public AudioSource m_audioMove ; 
	public AudioSource m_audioDie ; 

	public AudioClip[] m_audioWalk ; 
	public AudioClip[] m_audioDead ; 

	protected virtual void Awake()
	{
		m_animator = GetComponent<Animator>();
	} 

	void OnDestroy()
	{
	}


	public virtual void HandleDead() {
		m_animator.SetTrigger("player_die");
	}

	public virtual void HandleStartMove() {
		m_animator.SetTrigger("player_run");
		playMoveSounds();
	}

	public virtual void HandleStopMove() {
		m_animator.SetTrigger("player_idle");
		stopMoveSounds();
	}


	public void playMoveSounds() {
		int randIdx = Random.Range(0 , m_audioWalk.Length);
		m_audioMove.clip = m_audioWalk[randIdx];
		m_audioMove.pitch = 1f;
		m_audioMove.volume = 0.8f;
		m_audioMove.Play();
	}

	public void stopMoveSounds() {
		m_audioMove.Stop();
	}

	public void playDeadSounds() {
		int randIdx = Random.Range(0 , m_audioDead.Length);
		m_audioDie.clip = m_audioDead[randIdx];
		m_audioDie.pitch = 1f;
		m_audioDie.volume = 0.3f;
		m_audioDie.loop = false ;
		m_audioDie.Play();
	}
}
