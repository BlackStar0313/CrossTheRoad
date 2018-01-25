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
			// this.gameObject.SetActive(true);
			this.initRotation();
			this.onShow(arrowType);

			DispatchManager.getInstance().onMoveUIActivity.RemoveListener(this.init);

			DispatchManager.getInstance().onMoveUIShow.AddListener(this.onShow);
			DispatchManager.getInstance().onMoveUIHide.AddListener(this.onHide);
		}

	}

	public void onShow(int arrowType) {
		if (!GameManager.getInstance().IsPlaying()) {
			return ; 
		}

		this.gameObject.SetActive(true);
		enumArrowDirection direct = Random.Range(0.0f , 1.0f) > 0.5 ? enumArrowDirection.left : enumArrowDirection.right ; 

		GameManager.getInstance().currentArrowDirect = direct ; 

		m_arrow.Show( direct , (enumArrowType)arrowType );
	}

	public void onHide() {
		this.gameObject.SetActive(false);
	}

	private void initRotation () {
		PartnerController controller = m_parentObj.GetComponent<PartnerController>() as PartnerController;
		Quaternion add = controller.currentDirect == EnumMovingDirect.normal ? Quaternion.Euler(61 , -134 , 4) : Quaternion.Euler(62.5f , -48 , 6.2f);

		//根据camera 找到面向的rotation作为基准，在便宜一个位置
		Vector3 cameraPos = Camera.main.transform.localPosition;
		Quaternion relative = Quaternion.LookRotation(transform.position ,  cameraPos);
		transform.rotation = relative * add ; 

		// 58 -6 9
		//-3 127 -10


		//61 -197 7
		//-1.5 -149 0.8
	}

}
