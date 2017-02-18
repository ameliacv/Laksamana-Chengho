﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class input5 : MonoBehaviour {
	public Text hasil;
	Slider slider;
	GameObject panel1;
	public GameObject Box;
	float nilai_now;
	float nilai =10;
	// Use this for initialization
	void Start () {
		hasil = GameObject.Find ("Hasil5").GetComponent<Text>();
		panel1 = GameObject.Find ("Soal5");
		slider = GameObject.Find("SoalSlider").GetComponent<Slider>();
		nilai_now = slider.value;
		Debug.Log(nilai_now);
	}
	
	public void Hasil(string inputfieldString){
		if (inputfieldString == "Jama Qosor") {
			hasil.text = "Berhasil, Temukan Soal Berikutnya";
			Debug.Log("Pertanyaan 5 Selesai");
			OnValueChanged(nilai);
			panel1.SetActive(false);
			Time.timeScale =1; 
			Destroy(Box,0f);
		} else {
			hasil.text = "Ulangi Lagi Sampai Berhasil";
		}
		
	}
	public void OnValueChanged(float newValue)
	{
		nilai_now += newValue;
		slider.value = nilai_now;
	}
}
