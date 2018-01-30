using UnityEngine;
using System.Collections;

public class AnimationTextureDemo : MonoBehaviour {

	public GameObject[] Particles;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		if (GUI.Button(new Rect (0, 0,100,100), "Coin1 Gold"))
			PlayParticle (Particles [0]);
		if (GUI.Button(new Rect (100, 0,100,100), "Coin1 Silver"))
			PlayParticle (Particles [1]);
		if (GUI.Button(new Rect (200, 0,100,100), "Coin1 Bronze"))
			PlayParticle (Particles [2]);
		if (GUI.Button(new Rect (300, 0,100,100), "Coin2 Gold"))
			PlayParticle (Particles [3]);
		if (GUI.Button(new Rect (400, 0,100,100), "Coin2 Silver"))
			PlayParticle (Particles [4]);
		if (GUI.Button(new Rect (500, 0,100,100), "Coin2 Bronze"))
			PlayParticle (Particles [5]);
		if (GUI.Button(new Rect (600, 0,100,100), "Gem Black"))
			PlayParticle (Particles [6]);
		if (GUI.Button(new Rect (0, 100,100,100), "Gem Blue"))
			PlayParticle (Particles [7]);
		if (GUI.Button(new Rect (100,100,100,100), "Gem Green"))
			PlayParticle (Particles [8]);
		if (GUI.Button(new Rect (200,100,100,100), "Gem Purple"))
			PlayParticle (Particles [9]);
		if (GUI.Button(new Rect (300,100,100,100), "Gem Red"))
			PlayParticle (Particles [10]);
		if (GUI.Button(new Rect (400,100,100,100), "Gem Violet"))
			PlayParticle (Particles [11]);
		if (GUI.Button(new Rect (500,100,100,100), "Gem White"))
			PlayParticle (Particles [12]);
		if (GUI.Button(new Rect (600,100,100,100), "Gem Yellow"))
			PlayParticle (Particles [13]);
	}

	void PlayParticle(GameObject g){
		g.SetActive (true);
		g.GetComponent<ParticleSystem> ().Play ();
	}
}
