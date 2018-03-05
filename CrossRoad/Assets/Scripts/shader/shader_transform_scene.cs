using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class shader_transform_scene : MonoBehaviour {

	private Material m_transMat;
	public float transTime = 0.3f ;   //淡入淡出时间
	private UnityAction m_transCallBack = null ; 		//淡入淡出后的回调
	private bool m_isStartChange = false ; 
	private bool m_isDisppear = true; 		//判断是淡入还是淡出

	void Start()
	{

	}

	public void DoChange(UnityAction callback , bool isDisppear , bool isImmidiate) {
		if (m_transMat == null) {
			m_transMat = new Material(Shader.Find("Unlit/Trans_scene_shader"));
			m_transMat.SetFloat("_ColorRange", 0);
		}

		m_transCallBack = callback ; 
		m_isDisppear = isDisppear ; 
		m_isStartChange = true ;

		if (m_isDisppear) {
			m_transMat.SetFloat("_ColorRange", 0);
		}
		else {
			m_transMat.SetFloat("_ColorRange", 1);
		}

		if (isImmidiate) {
			m_isStartChange = false ;
			m_transMat.SetFloat("_ColorRange", 1);
		}
	}

	void Update()
	{
		if (m_isStartChange) {
			changeColor();
		}
	}

	private void changeColor() {
		float dist = m_isDisppear ? -1 : 1 ; 
		float count = m_transMat.GetFloat("_ColorRange") - transTime*Time.deltaTime*dist;
		m_transMat.SetFloat("_ColorRange", count);

		if (m_transMat.GetFloat("_ColorRange") <= 0 && m_isDisppear == false ||
			m_transMat.GetFloat("_ColorRange") >=1 && m_isDisppear == true) {
			if (m_transCallBack!= null) {
				m_transCallBack.Invoke();
			}
			m_isStartChange = false;
		}
	}
	
	//https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnRenderImage.html
 	void OnRenderImage(RenderTexture src, RenderTexture dest) {
		 if (m_transMat == null) {
			 return ;
		 }
		//用Blit来完成对渲染纹理的处理
		//unity 会把当前渲染得到的图像存储在第一个参数的源渲染纹理中，通过函数中的一些列操作，再把目标渲染纹理，即第二个参数对应的渲染纹理显示在屏幕上。
		// Copy the source Render Texture to the destination,
    	// applying the material along the way.

		//https://docs.unity3d.com/ScriptReference/Graphics.Blit.html
		Graphics.Blit(src, dest , m_transMat);
	}
}
