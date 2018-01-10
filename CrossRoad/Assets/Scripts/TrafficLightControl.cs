using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum EnumTrafficLight {
	red = 0, 
	yellow,
	green,
}

public class TrafficLightControl : MonoBehaviour {


	public GameObject[] m_trafficLight ;
	public float[] m_lightDelayTime = {2.0f , 3.0f , 5.0f} ;

	private TrafficLightSingle[] m_lightArr = new TrafficLightSingle[3];
	private EnumTrafficLight m_currentLight = 0 ;

	void Start()
	{
		for (int i = 0 ; i < 3 ; ++i) {
			m_lightArr[i] = m_trafficLight[i].GetComponent<TrafficLightSingle>();
			m_lightArr[i].SetLightType((EnumTrafficLight)i);
			m_lightArr[i].SetIsLight(false);
		}

		m_currentLight = EnumTrafficLight.red ;
		m_lightArr[(int)m_currentLight].SetIsLight(true);
		Invoke("trafficChange", m_lightDelayTime[(int)m_currentLight]);
	}

	private void trafficChange() {
		m_lightArr[(int)m_currentLight].SetIsLight(false);
		m_currentLight = (int)m_currentLight >= 2 ? EnumTrafficLight.red : ++m_currentLight;
		m_lightArr[(int)m_currentLight].SetIsLight(true);
		Invoke("trafficChange", m_lightDelayTime[(int)m_currentLight]);
	}

	void Update()
	{
		
	}
}
