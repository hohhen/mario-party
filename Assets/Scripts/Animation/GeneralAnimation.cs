﻿using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
public class GeneralAnimation : MonoBehaviour {
	private string anim_anchor;
	private int currentFrame;
	private float nextFrameChange = 0.0f;
	public Mesh[] frames;
	public float period = 0.13f;
	
	// Use this for initialization
	void Start () {

        currentFrame = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Time.time > nextFrameChange){
			nextFrameChange += period;
			nextWaveFrame();
		}
	}
	
	private void nextWaveFrame()
	{
		if (currentFrame < frames.Length - 1)
			currentFrame += 1;
		else
			currentFrame = 0;
		
		this.GetComponent<MeshFilter>().mesh = frames[currentFrame];
	}
}