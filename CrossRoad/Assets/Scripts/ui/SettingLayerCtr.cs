using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;

public class SettingLayerCtr : MonoBehaviour {
	public Button m_btnMusic;
	public Button m_btnSounds;
	public GameObject m_groupBack;

	public Sprite m_spMusicOn;
	public Sprite m_spMusicOff;
	public Sprite m_spSoundsOn;
	public Sprite m_spSoundsOff;

	private bool m_isActDone = false ;

	void Start()
	{
		m_btnMusic.onClick.AddListener(()=> handleTouch(m_btnMusic));
		m_btnSounds.onClick.AddListener(()=> handleTouch(m_btnSounds));

		m_btnMusic.image.sprite = SoundsManager.getInstance().isMusicOff ? m_spMusicOff : m_spMusicOn;
		m_btnSounds.image.sprite = SoundsManager.getInstance().isSoundsOff ? m_spSoundsOff : m_spSoundsOn;

		doAct();
	}

	void OnDestroy()
	{
		m_btnMusic.onClick.RemoveListener(() => handleTouch(m_btnMusic));
		m_btnSounds.onClick.RemoveListener(() => handleTouch(m_btnSounds));
	}

	private void handleTouch(Button btn) {
		if (btn == m_btnMusic) { 
			SoundsManager.getInstance().musicOff (!SoundsManager.getInstance().isMusicOff ); 
			m_btnMusic.image.sprite = SoundsManager.getInstance().isMusicOff ? m_spMusicOff : m_spMusicOn;
		}
		else if (btn == m_btnSounds) {
			SoundsManager.getInstance().soundsOff (!SoundsManager.getInstance().isSoundsOff); 
			m_btnSounds.image.sprite = SoundsManager.getInstance().isSoundsOff ? m_spSoundsOff : m_spSoundsOn;
		}
	}

	void Update()
	{
		if (isBack() && m_isActDone) {
			this.gameObject.SetActive(false);
			Destroy(gameObject);
		}
	}

	private bool isBack() {
		if (Input.GetMouseButtonDown(0)) {
			PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
			eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x , Input.mousePosition.y);


			List<RaycastResult> result = new List<RaycastResult>();
			EventSystem.current.RaycastAll(eventDataCurrentPosition, result);

			if (result.Count > 0 ) {
				//只接受第一个的点击
				for (int i = 0 ; i < result.Count ; ++i) {
					if (result[i].gameObject.tag != "TouchUI") {
						return false ;
					}
					else {
						return true;
					}
				}
			}
		}

		return false ;
	}

	private void doAct() {
		float moveTime = 0.6f; 
		float endX = m_btnSounds.transform.position.x ; 
		m_btnSounds.transform.position = new Vector3(Screen.width/2, m_btnSounds.transform.position.y, 0 );
		m_btnSounds.transform.Rotate(new Vector3(0,0,90) );

		Sequence seq = DOTween.Sequence();
		seq.Append(m_btnSounds.transform.DORotate(new Vector3(0,0,0) , moveTime));
		seq.Join(m_btnSounds.transform.DOMoveX(endX , moveTime).SetEase(Ease.OutBack));
		

		float endX2 = m_btnMusic.transform.position.x ; 
		m_btnMusic.transform.position = new Vector3(Screen.width/2, m_btnMusic.transform.position.y, 0 );
		m_btnMusic.transform.Rotate(new Vector3(0,0,-90) );

		Sequence seq1 = DOTween.Sequence();
		seq1.Append(m_btnMusic.transform.DORotate(new Vector3(0,0,0) , moveTime));
		seq1.Join(m_btnMusic.transform.DOMoveX(endX2 , moveTime).SetEase(Ease.OutBack));

		DOVirtual.DelayedCall(moveTime , ()=> { m_isActDone = true ; });
	}
}
