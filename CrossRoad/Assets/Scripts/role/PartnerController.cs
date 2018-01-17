using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartnerController : BasicController {
    private PartnerMoving m_partnerMoving ; 
	private bool m_isActToMove = false ; 
	private enumArrowType m_arrowType ; 

    protected override void Awake()
	{
		base.Awake();
        m_partnerMoving = GetComponent<PartnerMoving>();
		DispatchManager.getInstance().onPartnerCatched.AddListener(OnCatched) ;


		m_arrowType = Random.Range(0.0f,1.0f) > 0.5 ? enumArrowType.normal : enumArrowType.opposite;
	}


    public void OnStartMove() {
		base.HandleStartMove();

		if (m_isActToMove) {
			DispatchManager.getInstance().onMoveUIHide.Invoke();
		}
	}

	public void OnStopMove() {
		base.HandleStopMove();
		if (m_isActToMove) {
			DispatchManager.getInstance().onMoveUIShow.Invoke((int)m_arrowType);
		}
	}


    public void OnPlayerCollidetion(Vector3 carPos, BasicCollider collider) {
		if (typeof(PartnerCollider) != collider.GetType()) {
			GameObject colliderObj = GameObject.FindGameObjectWithTag("partnerCollider");
			PartnerCollider coll  = colliderObj.GetComponent<PartnerCollider>() as PartnerCollider;
			if (coll) {
                coll.handleCarCollision(carPos, false);
            }
		}
	}

	public void OnReachEnd(float direct) {
		if (!m_partnerMoving.isPartnerDirect(direct)) {
			return ;
		}

		this.gameObject.SetActive(false);
		DestroyObject(this.gameObject);
		//TODO: add coin and play coin flying animation .

	}

	void OnDestroy() {
		this.removeEvent();
    }

    public void OnMove(float speed , float direct) {
        m_partnerMoving.OnMove(speed , direct);
    }



	private void OnCatched(float direct ) {
		if (m_partnerMoving.isPartnerDirect(direct) ) {
			m_isActToMove = true ; 

			DispatchManager.getInstance().onPartnerCatched.RemoveListener(this.OnCatched);

			DispatchManager.getInstance().onPartnerMove.AddListener(this.OnMove);
			DispatchManager.getInstance().onPartnerStop.AddListener(this.OnStopMove);
			DispatchManager.getInstance().onPartnerReached.AddListener(this.OnReachEnd);	
			DispatchManager.getInstance().onCollidePlayer.AddListener(this.OnPlayerCollidetion);	

			GameManager.getInstance().currentArrowType = this.m_arrowType;
			DispatchManager.getInstance().onMoveUIActivity.Invoke(this.gameObject , (int)this.m_arrowType);
		}
	}

	public void removeEvent() {
		DispatchManager.getInstance().onPartnerMove.RemoveListener(this.OnMove);
		DispatchManager.getInstance().onPartnerStop.RemoveListener(this.OnStopMove);
		DispatchManager.getInstance().onPartnerReached.RemoveListener(this.OnReachEnd);
		DispatchManager.getInstance().onCollidePlayer.RemoveListener(this.OnPlayerCollidetion);
	}
}
