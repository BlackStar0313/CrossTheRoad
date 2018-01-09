using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public GameObject m_car;

	[HideInInspector] public static GameManager mInstance = null ; 

	private bool m_isStartCreateCar = true;
	private float m_maxIntervelCreatCarTime = 5f ; 
	private float m_minIntervelCreateCarTime = 1f;

	public static GameManager getInstance() {
		return GameManager.mInstance ; 
	}
	
	// Use this for initialization
	void Awake () {
		if (GameManager.mInstance == null) {
			GameManager.mInstance = this;
		}
		else if (GameManager.mInstance != this) {
			Destroy(gameObject);
		}
		DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		if (m_isStartCreateCar) {
			StartCoroutine(AutoCreateCar());
		}
	}

	protected IEnumerator AutoCreateCar() {
		this.m_isStartCreateCar = false ;

		Instantiate(this.m_car);
		float randTime = Random.Range(m_minIntervelCreateCarTime, m_maxIntervelCreatCarTime);
		Debug.Log(" delay time is " + randTime ) ; 
		yield return new WaitForSeconds(randTime) ; 

		this.m_isStartCreateCar = true ; 
	}

}
