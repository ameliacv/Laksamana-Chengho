﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class input2 : MonoBehaviour {
	public Text hasil;
	 Slider SliderSoal1;
	GameObject panel1;
	public GameObject Box;
	float nilai_now;
	float nilai =10;
	// Use this for initialization
	void Start () {
		hasil = GameObject.Find ("Hasil2").GetComponent<Text>();
		panel1 = GameObject.Find ("Soal2");
		SliderSoal1 = GameObject.Find("SoalSlider").GetComponent<Slider>();
		nilai_now = SliderSoal1.value;
		Debug.Log(nilai_now);
	}
	
	public void Hasil(string inputfieldString){
		if (inputfieldString == "I'tidal") {
			hasil.text = "Berhasil, Temukan Soal Berikutnya";
			Debug.Log("Pertanyaan 2 Selesai");
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
		SliderSoal1.value = nilai_now;
	}
}
