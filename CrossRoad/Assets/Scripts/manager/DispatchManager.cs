using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DispatchManager {
	public static DispatchManager m_Instance = null ; 

	public static DispatchManager getInstance() {
		if (DispatchManager.m_Instance == null) {
			DispatchManager.m_Instance = new DispatchManager();
		}
		return DispatchManager.m_Instance;
	}

	public class EventV3: UnityEvent<Vector3>  {}
	public class EventInt: UnityEvent<int>  {}
	public class EventFloatV3: UnityEvent<float,Vector3>  {}
	public class EventFloat: UnityEvent<float>  {}
	public class EventFloatFloat: UnityEvent<float ,float> {}
	public class EventV3Collider: UnityEvent<Vector3, BasicCollider>  {}
	public class EventEmpty: UnityEvent {} 
	public class EventGameObject: UnityEvent<GameObject> {} 
	public class EventGameObjectInt: UnityEvent<GameObject, int> {} 
	public class EventBool: UnityEvent<bool>  {}


	public EventFloatFloat onPartnerMoveIng = null; 
	public EventEmpty onPartnerStartMove = null; 
	public EventEmpty  onPartnerStop = null; 
	public EventFloat  onPartnerReached = null; 
	public EventFloat  onPartnerCatched = null; 
	public EventV3Collider onCollidePlayer = null;

	public EventInt onMoveUIShow = null ; 
	public EventEmpty onMoveUIHide = null ; 
	public EventGameObjectInt onMoveUIActivity = null ;

	public EventBool onMoveWrong = null ; 
	public EventEmpty onMoveRight = null ; 
	public EventEmpty onAddCoin = null ; 

	public EventEmpty onStartGame = null ; 
	public EventInt onSelectShopItem = null ;
	public EventEmpty onRefreshShopShow = null ; 

	public EventV3 onAddHeart = null ;
	public EventEmpty onGameOver = null ; 

	public DispatchManager() {
		onPartnerMoveIng = new EventFloatFloat();
		onPartnerStartMove = new EventEmpty();
		onPartnerStop = new EventEmpty();
		onPartnerReached = new EventFloat();
		onPartnerCatched = new EventFloat();
		onCollidePlayer = new EventV3Collider();

		onMoveUIShow = new EventInt(); 
		onMoveUIHide = new EventEmpty();
		onMoveUIActivity = new EventGameObjectInt();

		onMoveWrong = new EventBool();
		onMoveRight = new EventEmpty();
		onAddCoin = new EventEmpty();

		onStartGame = new EventEmpty();
		onSelectShopItem = new EventInt();
		onRefreshShopShow = new EventEmpty();

		onAddHeart = new EventV3();
		onGameOver = new EventEmpty();
	}

	public void ClearAll() {
		onPartnerMoveIng.RemoveAllListeners();
		onPartnerStartMove.RemoveAllListeners();
		onPartnerStop.RemoveAllListeners();
		onPartnerReached.RemoveAllListeners();
		onPartnerCatched.RemoveAllListeners();
		onCollidePlayer.RemoveAllListeners();

		onMoveUIShow.RemoveAllListeners();
		onMoveUIHide.RemoveAllListeners();
		onMoveUIActivity.RemoveAllListeners();

		onMoveWrong.RemoveAllListeners();
		onMoveRight.RemoveAllListeners();
		onAddCoin.RemoveAllListeners();

		onStartGame.RemoveAllListeners();
		onSelectShopItem.RemoveAllListeners();
		onRefreshShopShow.RemoveAllListeners();

		onAddHeart.RemoveAllListeners();
		onGameOver.RemoveAllListeners();
	}

	// public delegate void EventHandler();
	// public delegate void EventHandlerS(string msg);
	// public delegate void EventHandleI(int msg);
	// public delegate void EventHandleSI(string msgS, int msgI);
	// public delegate void EventHandleT<T>(T msg);

	// public event EventHandleT<Vector3> onPartnerMove ;
	// public event EventHandler onPartnerStop;
	// public event EventHandler onPartnerReachEnd;
	// public event EventHandler onPartnerCatched;

	// public void OnPartner() {
	// 	onPartnerStop();
	// }

	// public static string ON_PARTNER_MOVE = "on_partner_move";
	// public static string ON_PARTNER_STOP = "on_partner_stop";
	// public static string ON_PARTNER_REACHED = "on_partner_reached";
	// public static string ON_PARTNER_CATCHED = "on_partner_catched";


}
