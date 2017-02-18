using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {

	Transform player; 
	PlayerHealth playerhealth;
	EnemyHealth enemySehat;
//	NavMeshAgent nav; 

	void Awake(){

		playerhealth = player.GetComponent<PlayerHealth>();
		enemySehat = GetComponent<EnemyHealth>();
	//	nav = GetComponent <NavMeshAgent>();
	}

	void Update(){


	}
}
