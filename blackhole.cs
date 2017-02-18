using UnityEngine;
using System.Collections;

public class blackhole : MonoBehaviour {
	ParticleSystem ps ;
	// Use this for initialization
	void Start () {
		ps = gameObject.GetComponent<ParticleSystem>();
		if (ps.isPlaying) {
			ps.Stop ();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
