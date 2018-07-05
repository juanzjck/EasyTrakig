using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayEffectTimed : MonoBehaviour {

	private AIDesigner.EffectsBuilder eb;
	public string effectName = "particle blast";
	public float interval = 0.5f;

	// Use this for initialization
	void Start () {
		eb = GetComponent<AIDesigner.EffectsBuilder>();

		if (eb != null){
			// tell Effects Builder to play every 0.5 seconds:
			InvokeRepeating("PlayEffect", interval, interval);
		}
	}
	

	void PlayEffect(){
		// tell EFfects Builder to play the effect set in effectName:
		eb.Play(effectName);
	}
}
