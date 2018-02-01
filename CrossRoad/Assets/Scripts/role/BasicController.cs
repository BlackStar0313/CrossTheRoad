using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicController : MonoBehaviour {
	[HideInInspector] public Animator m_animator;

	public AudioSource m_audioSource ; 

	public AudioClip[] m_audioWalk ; 
	public AudioClip[] m_audioDead ; 

	protected virtual void Awake()
	{
		m_animator = GetComponent<Animator>();
		m_audioSource = GetComponent<AudioSource>();		
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
		m_audioSource.clip = m_audioWalk[randIdx];
		m_audioSource.pitch = 1f;
		m_audioSource.volume = 0.8f;
		m_audioSource.Play();
	}

	public void stopMoveSounds() {
		m_audioSource.Stop();
	}

	public void playDeadSounds() {
		int randIdx = Random.Range(0 , m_audioDead.Length);
		m_audioSource.clip = m_audioDead[randIdx];
		m_audioSource.pitch = 1f;
		m_audioSource.volume = 0.3f;
		m_audioSource.loop = false ;
		m_audioSource.Play();
	}
}
