﻿using UnityEngine;
using System.Collections;

public class dialogueTrigger : Trigger {

	//public TextAsset theText;

	public int startLine;
	public int endLine;

	public TextBoxManager theTextBox;

	public TextAsset[] texts;
	public int pointer;
	public bool loop;
	// Use this for initialization
	void Start () {
		pointer = 0;
		theTextBox = FindObjectOfType < TextBoxManager >();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public override void switchTrigger(){
		//Debug.Log ("size: " + size);
		Debug.Log ("pointer: " + pointer);

		if (pointer < texts.Length) {
			theTextBox.ReloadScript (texts[pointer]);
			theTextBox.currentLine = startLine;
			theTextBox.endAtLine = endLine;
			Invoke ("enable", 0.1f);
		}
		if (loop) {
			if (pointer < texts.Length) {
				pointer = (pointer + 1) % (texts.Length);
			}
		} else  {
			pointer++;
		}
			
	}

	public void enable(){
		theTextBox.EnableTextBox();
	}

}
