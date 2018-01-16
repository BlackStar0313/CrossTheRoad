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

    public void OnStartMove(float speed ,float direction) {
		base.HandleStartMove();
        DispatchManager.getInstance().onPartnerMove.Invoke(speed , direction);
	}

	public void OnStopMove() {
		base.HandleStopMove();
        DispatchManager.getInstance().onPartnerStop.Invoke();
	}

    public void onOneRoungEnd(float currentDirect) {
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
}
