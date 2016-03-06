﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class buttonTrigger : Trigger {


	public List<GameObject> objects = new List<GameObject> ();

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.CompareTag ("Player") || other.CompareTag ("Doll")) {
			if (!objects.Contains (other.gameObject)) 
				objects.Add (other.gameObject);
			switchTriggerOn ();
			Debug.Log ("ON");
		}
	}

//	void OnTriggerStay2D(Collider2D other) {
//		if (other.CompareTag ("Player") || other.CompareTag ("Doll")) {
//			if (other.gameObject.GetComponent<dollType> ().type.Equals (specialDoll))
//				Debug.Log ("On");
//				switchTriggerOn ();
//		}
//	}

	void OnTriggerExit2D(Collider2D other) {
		if (other.CompareTag ("Player") || other.CompareTag ("Doll")) {
			objects.Remove (other.gameObject);
			if (objects.Count == 0) {
				switchTriggerOff ();
				Debug.Log ("Off");
			}
		}
	}


}
