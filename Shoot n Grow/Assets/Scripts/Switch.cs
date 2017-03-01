﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

	public GameObject affectedObject;

	void OnTriggerEnter(Collider other){
		if (affectedObject.activeSelf) {
			affectedObject.SetActive (false);
		}
		else {
			affectedObject.SetActive (true);
		}
		gameObject.SetActive (false);	
	}
}