using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : BasicController {
    private PlayerMoving m_playerMoving ; 

    protected override void Awake()
	{
		base.Awake();
        m_playerMoving = GetComponent<PlayerMoving>();
        DispatchManager.getInstance().onCollidePlayer.AddListener(this.OnPlayerCollidetion);
	}

    void OnDestroy() {
        DispatchManager.getInstance().onCollidePlayer.RemoveListener(this.OnPlayerCollidetion);
    }

    public void OnMoving(float speed ,float direction) {
        DispatchManager.getInstance().onPartnerMoveIng.Invoke(speed , direction);
	}

    public void OnStartMove() {
        base.HandleStartMove();
        DispatchManager.getInstance().onPartnerStartMove.Invoke();
    }

	public void OnStopMove() {
		base.HandleStopMove();
        DispatchManager.getInstance().onPartnerStop.Invoke();
	}

    public void onOneRoungEnd(float currentDirect) {
        DispatchManager.getInstance().onAddCoin.Invoke();
        DispatchManager.getInstance().onPartnerReached.Invoke(currentDirect*-1);
        DispatchManager.getInstance().onPartnerCatched.Invoke(currentDirect );
    }

    public void OnPlayerCollidetion(Vector3 carPos , BasicCollider collider) {
		if (typeof(PlayerCollider) != collider.GetType()) {
			GameObject colliderObj = GameObject.FindGameObjectWithTag("playerCollider");
            PlayerCollider coll  = colliderObj.GetComponent<PlayerCollider>() as PlayerCollider;
            if (coll) {
                coll.handleCarCollision(carPos, false);
            }
		}
	}

    public void OnMoveWrong(bool isLeft) {
        GameObject warningUIObj = Instantiate(Resources.Load("Prefebs/WarningLayer") as GameObject);        
        WarningUICtr ctr = warningUIObj.GetComponent<WarningUICtr>();
        ctr.init(isLeft);
    }

    public void OnMoveRight() {
        DispatchManager.getInstance().onMoveRight.Invoke();
    }
}
