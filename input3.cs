﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class input3 : MonoBehaviour {
	public Text hasil;
	Slider SliderSoal;
	GameObject panel1;
	public GameObject Box;
	float nilai_now;
	float nilai =10;
	// Use this for initialization
	void Start () {
		hasil = GameObject.Find ("Hasil3").GetComponent<Text>();
		panel1 = GameObject.Find ("Soal3");
		SliderSoal = GameObject.Find("SoalSlider").GetComponent<Slider>();
		nilai_now = SliderSoal.value;
		Debug.Log(nilai_now);
	}
	
	public void Hasil(string inputfieldString){
		if (inputfieldString == "Subuh") {
			hasil.text = "Berhasil, Temukan Soal Berikutnya";
			Debug.Log("Pertanyaan 3 Selesai");
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
		SliderSoal.value = nilai_now;
	}
}
