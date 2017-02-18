using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {
	public PlayerHealth playerSehat;
	public GameObject enemy;
	public float spawnTime = 10f;
	public Transform[] spawnPoints;

	void Start(){
		InvokeRepeating ("Spawn",spawnTime,spawnTime);
	}

	void Spawn(){
		if(playerSehat.currentHealt <= 0f){
			return;
		}

		int spawnPointIndex = Random.Range (0,spawnPoints.Length);
		Instantiate (enemy, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
	}
}
