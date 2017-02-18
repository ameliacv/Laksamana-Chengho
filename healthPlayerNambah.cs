using UnityEngine;
using System.Collections;

public class healthPlayerNambah : MonoBehaviour {
	PlayerHealth playerh;
	GameObject player;
	public int nambah =-10;
	void Awake(){
		playerh = GetComponent<PlayerHealth>();
		//player = GameObject.FindGameObjectWithTag ("Player");
	}
	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Player"){
			playerh.TakeDamage(nambah);
			Destroy(other.gameObject);
		}

	}
}
