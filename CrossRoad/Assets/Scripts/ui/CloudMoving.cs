using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


enum enumFrogActionType {
	none , 
	autoHide ,
	autoShow
}

public class CloudMoving : MonoBehaviour {
	public List<Image> m_cloudList;
	public Image m_cloudCenter ; 

	private List<Vector3> m_startPos = new List<Vector3>(); 
	private List<Vector3> m_endPos = new List<Vector3>();
	private float m_endScale = 2f ;
	private float m_actionTime = 2.5f;

	private float m_moveDist;
	private enumFrogActionType m_frogActType = enumFrogActionType.none ;

	void Start()
	{
		m_moveDist = Mathf.Max(Screen.width, Screen.height) ;

		for (int i = 0 ; i < m_cloudList.Count ; ++i) {
			Image img = m_cloudList[i];
			m_startPos.Add(new Vector3(img.transform.position.x ,img.transform.position.y , img.transform.position.z));

			//算出两点间的单位方向向量，再根据距离，算出最终需要移动的位置
			Vector2 center = new Vector2(Screen.width/2 , Screen.height/2);
			Vector2 directVec = (center - new Vector2(img.transform.position.x , img.transform.position.y)).normalized;
			Vector2 targetPos = center - m_moveDist * directVec ; 
			Vector3 newPos = new Vector3(targetPos.x , targetPos.y , img.transform.position.z);
			m_endPos.Add(newPos);
		}

		if (m_frogActType == enumFrogActionType.autoHide) {
			DoMoveOut();
		}
		else if (m_frogActType == enumFrogActionType.autoShow) {
			for (int i = 0 ; i < m_cloudList.Count ; ++i) {
				m_cloudList[i].transform.position = m_endPos[i];
			}
			DoMoveIn();
		}
	}

	public void HideBegin(bool isAuto) {
		m_cloudCenter.color = new Color(m_cloudCenter.color.r, m_cloudCenter.color.g , m_cloudCenter.color.b , 1 );

		if (isAuto) {
			m_frogActType = enumFrogActionType.autoHide ;
		}
	}

	public void ShowBegin(bool isAuto) {
		m_cloudCenter.color = new Color(m_cloudCenter.color.r, m_cloudCenter.color.g , m_cloudCenter.color.b , 0 );
		m_cloudCenter.transform.localScale *= m_endScale;
		
		if (isAuto) {
			m_frogActType = enumFrogActionType.autoShow ;
		}
	}

	public void DoMoveOut() {
		for (int i = 0 ; i < m_cloudList.Count ; ++i) {
			m_cloudList[i].transform.DOMove(m_endPos[i], m_actionTime);
			// m_cloudList[i].DOFade(0, m_actionTime);
		}

		m_cloudCenter.DOFade(0, m_actionTime);
		m_cloudCenter.transform.DOScale(m_endScale, m_actionTime);

		DOVirtual.DelayedCall(m_actionTime, ()=> Destroy(this.gameObject));
	}

	public void DoMoveIn() {
		for (int i = 0 ; i < m_cloudList.Count ; ++i) {
			m_cloudList[i].transform.DOMove(m_startPos[i], m_actionTime);
			// m_cloudList[i].DOFade(1, m_actionTime);
		}

		m_cloudCenter.DOFade(1, m_actionTime);
		m_cloudCenter.transform.DOScale(1, m_actionTime);
	}
}
