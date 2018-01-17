using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightSingle : MonoBehaviour {

	private Renderer m_myRenderer;
	private string m_texturName = "_MainTex";
	private EnumTrafficLight m_lightType ;

	// Use this for initialization
	void Start () {
		m_myRenderer = this.GetComponent<Renderer>();
		m_myRenderer.material.SetTextureScale(m_texturName, new Vector2(1.0f/4.0f,1.0f/4.0f));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetIsLight(bool isLight) {
		Vector2 pos = new Vector2();
		if (m_lightType == EnumTrafficLight.red) {
			pos = isLight ? new Vector2(0,0.5f) : new Vector2(0,0);
		}
		else if (m_lightType == EnumTrafficLight.yellow) {
			pos = isLight ? new Vector2(0.5f,0.5f) : new Vector2(0,0);
		}
		else if (m_lightType == EnumTrafficLight.green) {
			pos = isLight ? new Vector2(0,0) : new Vector2(0,0.5f);
		}
		m_myRenderer.material.SetTextureOffset(m_texturName ,pos);
	}

	public void SetLightType(EnumTrafficLight type) { m_lightType = type; }
}
