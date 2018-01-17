using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum enumArrowType {
	normal , 
	opposite 
}

public enum enumArrowDirection {
	left , 
	right 
}

public class MoveUICtr : MonoBehaviour {
	public GameObject m_arrowObj ;
	public GameObject m_parentObj;
	public Transform m_cameraPos;   
	
	private MoveArrow m_arrow ;

	// Use this for initialization
	void Awake()
	{
		this.gameObject.SetActive(false);
		DispatchManager.getInstance().onMoveUIActivity.AddListener(this.init);

		m_arrow = m_arrowObj.GetComponent<MoveArrow>();
	}

	void OnDestroy() {
		DispatchManager.getInstance().onMoveUIShow.RemoveListener(this.onShow);
		DispatchManager.getInstance().onMoveUIHide.RemoveListener(this.onHide);
    }
	
	void init(GameObject obj, int arrowType) {
		if (obj == m_parentObj) {
			this.gameObject.SetActive(true);
			this.onShow(arrowType);

			DispatchManager.getInstance().onMoveUIActivity.RemoveListener(this.init);

			DispatchManager.getInstance().onMoveUIShow.AddListener(this.onShow);
			DispatchManager.getInstance().onMoveUIHide.AddListener(this.onHide);
		}

	}

	public void onShow(int arrowType) {
		this.gameObject.SetActive(true);
		enumArrowDirection direct = Random.Range(0.0f , 1.0f) > 0.5 ? enumArrowDirection.left : enumArrowDirection.right ; 

		GameManager.getInstance().currentArrowDirect = direct ; 

		//TODO: 弄清楚旋转是怎么回事
		if (transform.localEulerAngles.y > 90 && GameManager.getInstance().playerDirect > 0) {
			Vector3 nowRotate = new Vector3(transform.localEulerAngles.x , transform.localEulerAngles.y , transform.localEulerAngles.z  ); 
			Vector3 distRotate = new Vector3(transform.localEulerAngles.x , 32 , transform.localEulerAngles.z );
			Quaternion roll = Quaternion.Euler(distRotate - nowRotate );
			transform.rotation *= roll ;
		}
		else if (transform.localEulerAngles.y < 90 && GameManager.getInstance().playerDirect < 0) {
			Vector3 nowRotate = new Vector3(transform.localEulerAngles.x , transform.localEulerAngles.y , transform.localEulerAngles.z  ); 
			Vector3 distRotate = new Vector3(transform.localEulerAngles.x , 210 - 32, transform.localEulerAngles.z );
			Quaternion roll = Quaternion.Euler(distRotate - nowRotate );
			// transform.rotation = transform.parent.rotation;

			// Quaternion roll = Quaternion.Euler(0,180,0 );
			transform.rotation *= roll;
		}

		// Vector3 relativePos = m_cameraPos.position - transform.position;
		// Quaternion roll = Quaternion.LookRotation(relativePos);
		// transform.rotation = roll;


		m_arrow.Show( direct , (enumArrowType)arrowType );
	}

	public void onHide() {
		this.gameObject.SetActive(false);
	}

}
