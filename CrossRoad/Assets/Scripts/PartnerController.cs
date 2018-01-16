using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartnerController : BasicController {
    private PartnerMoving m_partnerMoving ; 

    protected override void Awake()
	{
		base.Awake();
        m_partnerMoving = GetComponent<PartnerMoving>();
		DispatchManager.getInstance().onPartnerCatched.AddListener(OnCatched) ;
	}


    public void OnStartMove() {
		base.HandleStartMove();
	}

	public void OnStopMove() {
		base.HandleStopMove();
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

    public void OnStop() {
		base.HandleStopMove();
	}

	public void OnReachEnd(float direct) {
		if (!m_partnerMoving.isPartnerDirect(direct)) {
			return ;
		}

		this.gameObject.SetActive(false);
		DestroyObject(this.gameObject);
		//TODO: add coin and play coin flying animation .

		this.removeEvent();
	}

    public void OnMove(float speed , float direct) {
        m_partnerMoving.OnMove(speed , direct);
    }



	private void OnCatched(float direct ) {
		if (m_partnerMoving.isPartnerDirect(direct) ) {

			DispatchManager.getInstance().onPartnerCatched.RemoveListener(this.OnCatched);

			DispatchManager.getInstance().onPartnerMove.AddListener(this.OnMove);
			DispatchManager.getInstance().onPartnerStop.AddListener(this.OnStop);
			DispatchManager.getInstance().onPartnerReached.AddListener(this.OnReachEnd);	
			DispatchManager.getInstance().onCollidePlayer.AddListener(this.OnPlayerCollidetion);	
		}
	}

	public void removeEvent() {
		DispatchManager.getInstance().onPartnerMove.RemoveListener(this.OnMove);
		DispatchManager.getInstance().onPartnerStop.RemoveListener(this.OnStop);
		DispatchManager.getInstance().onPartnerReached.RemoveListener(this.OnReachEnd);
		DispatchManager.getInstance().onCollidePlayer.RemoveListener(this.OnPlayerCollidetion);
	}
}
