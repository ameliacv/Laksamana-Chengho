using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class namakamu : MonoBehaviour {
	public Text nama;
	// Use this for initialization
	void Start () {
		nama = GameObject.Find ("Nama").GetComponent<Text>();
	}
	
	public void Hasil(string inputfieldString){
		nama.text = inputfieldString;
	}
}
