﻿using UnityEngine;
using System.Collections;

public class resume5 : MonoBehaviour {
	bool pause;
    GameObject Box;
	GameObject panel1;
	GameObject Player;
	// Use this for initialization
	void Start () {
		Player = GameObject.Find("Player");
		panel1 = GameObject.Find ("Soal5");

		panel1.SetActive (false);
	}
	void OnTriggerEnter(Collider other){
		if(other.gameObject == Player ){		
			panel1.SetActive (true);
			Pause();
			Debug.Log("Pause");
		}
		
	}
	void OnTriggerExit(Collider other){
		if(other.gameObject == Player){
			Time.timeScale = 1;
			Debug.Log("Not Pause");
			panel1.SetActive (false);
		}
	}
	void Pause(){
		Time.timeScale =0; 
	}
	

}
