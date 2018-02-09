using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class PauseLayerCtr : MonoBehaviour {
	public Button m_btnContinue;
	public Button m_btnHome;

	private bool m_isActDone = false ;

	void Awake()
	{
		m_btnContinue.onClick.AddListener(delegate() {this.handleTouch(m_btnContinue );} );
		m_btnHome.onClick.AddListener(delegate() {this.handleTouch(m_btnHome );} );

		Time.timeScale = 0;

		//时间静止了。。。
		// doAct();
	}

	private void handleTouch(Button btn) {
		// if (!m_isActDone) {
		// 	return ; 
		// }

		if (btn == m_btnContinue) {
			gameObject.SetActive(false);
			Destroy(gameObject);
			Time.timeScale = 1 ;
			SoundsManager.getInstance().playSounds(SoundsManager.clipNameClick);
		}
		else if (btn == m_btnHome) {
			Time.timeScale = 1 ;
			GameManager.getInstance().LoadMenuScene();
			SoundsManager.getInstance().playSounds(SoundsManager.clipNameClick);
		}
	}

	private void doAct() {
		float moveTime = 0.6f; 
		float endX = m_btnContinue.transform.position.x ; 
		m_btnContinue.transform.position = new Vector3(Screen.width/2, m_btnContinue.transform.position.y, 0 );
		m_btnContinue.transform.Rotate(new Vector3(0,0,90) );

		Sequence seq = DOTween.Sequence();
		seq.Append(m_btnContinue.transform.DORotate(new Vector3(0,0,0) , moveTime));
		seq.Join(m_btnContinue.transform.DOMoveY(endX , moveTime).SetEase(Ease.OutBack));
		

		float endX2 = m_btnHome.transform.position.x ; 
		m_btnHome.transform.position = new Vector3(Screen.width/2, m_btnHome.transform.position.y, 0 );
		m_btnHome.transform.Rotate(new Vector3(0,0,90) );

		Sequence seq1 = DOTween.Sequence();
		seq1.Append(m_btnHome.transform.DORotate(new Vector3(0,0,0) , moveTime));
		seq1.Join(m_btnHome.transform.DOMoveY(endX2 , moveTime).SetEase(Ease.OutBack));

		DOVirtual.DelayedCall(moveTime , ()=> { m_isActDone = true ; });
	}

}
