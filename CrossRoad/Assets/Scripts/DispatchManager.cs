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
	public class EventFloat: UnityEvent<float>  {}


	public EventFloat onPartnerMove = null; 
	public UnityEvent  onPartnerStop = null; 
	public UnityEvent  onPartnerReached = null; 
	public UnityEvent  onPartnerCatched = null; 

	public DispatchManager() {
		onPartnerMove = new EventFloat();
		onPartnerStop = new UnityEvent();
		onPartnerReached = new UnityEvent();
		onPartnerCatched = new UnityEvent();
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
