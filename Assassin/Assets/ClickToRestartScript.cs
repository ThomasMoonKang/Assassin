﻿using UnityEngine;
using System.Collections;

public class ClickToRestartScript : MonoBehaviour {
	
	public float fadeInSpeed = 0.5f;
	public float fadeOutSpeed = 0.5f;
	public GameObject bloodSlice;


	private Transform player;
	private Animator playerAnimator;

	void Start() {
		player = GameObject.Find("Player").transform;
		playerAnimator = player.GetComponent<Animator> ();
	}

	void HitByRay() {
		GameObject bloodSliceInstance = Instantiate
			(bloodSlice, this.transform.position - new Vector3(0,0,10), 
			 Quaternion.Euler(340, 90, 0)) as GameObject;
		Debug.Log ("BUTTON CLICKED");
		player.position = new Vector2(this.transform.position.x, this.transform.position.y+0.1f);
		playerAnimator.SetTrigger("Slash");
		AutoFade.LoadLevel(Application.loadedLevel, fadeInSpeed,fadeOutSpeed,Color.black);
	}
}
