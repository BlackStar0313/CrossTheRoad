using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayUICtr : MonoBehaviour {
	public Text m_textCoin ;
	public Slider m_Slider ; 

	private float m_decreaseTime = 6;
	private float m_addStep = 0.3f;

	void Awake()
	{
		m_textCoin.text = "0" ; 
		m_Slider.value = 1 ;

		DispatchManager.getInstance().onMoveRight.AddListener(OnAddSlider);
		DispatchManager.getInstance().onAddCoin.AddListener(OnAddCoin);
	}

	void OnDestroy()
	{
		DispatchManager.getInstance().onMoveRight.RemoveListener(OnAddSlider);
		DispatchManager.getInstance().onAddCoin.RemoveListener(OnAddCoin);
	}

	void Update()
	{
		if (m_Slider.value <=0 || !GameManager.getInstance().IsPlaying()) {
			return ;
		}

		float curFrameStep = Time.deltaTime / m_decreaseTime;
		m_Slider.value = Mathf.Max(m_Slider.value - curFrameStep, 0) ;

		if (m_Slider.value <= 0) {
			GameManager.getInstance().handlePlayerDead(true);
		}
	}

	void OnAddSlider() {
		m_Slider.value += m_addStep;
	}

	void OnAddCoin() {
		PlayerManager.getInstance().score += PlayerManager.getInstance().addScoreSpeed;
		//TODO: add animation and practice
		this.m_textCoin.text = PlayerManager.getInstance().score.ToString();
	}
}
