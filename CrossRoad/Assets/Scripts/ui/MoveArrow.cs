using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MoveArrow : MonoBehaviour {
	public Sprite m_spriteRed ;
	public Sprite m_spriteGreen ; 

	private Image m_img ; 

	void Awake()
	{
		m_img = GetComponent<Image>();
	}
	
	public void Show(enumArrowDirection direction , enumArrowType type ) {
		if (direction == enumArrowDirection.left) {
			Vector3 nowRotate = new Vector3(transform.localEulerAngles.x , transform.localEulerAngles.y , transform.localEulerAngles.z  ); 
			Vector3 distRotate = new Vector3(transform.localEulerAngles.x , 0 , transform.localEulerAngles.z );
			Quaternion roll = Quaternion.Euler(distRotate - nowRotate);
			transform.rotation *= roll ;
		}
		else {
			Vector3 nowRotate = new Vector3(transform.localEulerAngles.x , transform.localEulerAngles.y , transform.localEulerAngles.z  ); 
			Vector3 distRotate = new Vector3(transform.localEulerAngles.x , 180 , transform.localEulerAngles.z );
			Quaternion roll = Quaternion.Euler(distRotate - nowRotate);
			transform.rotation *= roll ;
		}

		if (type == enumArrowType.normal) {
			m_img.sprite = m_spriteGreen ; 
		}
		else {
			m_img.sprite = m_spriteRed;
		}
	}
}
