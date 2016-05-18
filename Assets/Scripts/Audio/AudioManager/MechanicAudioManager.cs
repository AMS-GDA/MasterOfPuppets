﻿using UnityEngine;
using System.Collections;

public class MechanicAudioManager : AbstractAudioManager {

    //Audioclips
    public AudioClip buttonClip;

    //AudioSources
    public AudioSource button;

    //Volume
    public float buttonVolume;
	public float maxConveyorBeltVolume;
	public float maxGhostWallVolume;

	//fadeTime
	public float fadeTime;

	public GameObject[] audioControllers;

    public static MechanicAudioManager instance;

    void Awake() {
        if (instance != null) {
            Debug.LogError("Multiple instances of SoundEffectsHelper!");
        }
        instance = this;
    }

	void Start(){
		audioControllers = GameObject.FindGameObjectsWithTag ("AudioContoller");
	}

    public static MechanicAudioManager getInstance() {
        return instance;
    }

    public void playButtonSound() {
        playOneShotSound(buttonClip, button, buttonVolume);
    }
		
}