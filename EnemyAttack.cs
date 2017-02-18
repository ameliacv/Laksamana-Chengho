using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {

	public float timeBetweenAttacks = 0.5f;
	public int attackDamage =10;

	Animator anim;
	GameObject Player;
	PlayerHealth playerHealt;
	EnemyHealth enemyHealth;

	bool playerInRange;
	float Timer;


	void Awake(){
		Player = GameObject.FindGameObjectWithTag ("Player");
		playerHealt = Player.GetComponent <PlayerHealth>();
		enemyHealth = GetComponent<EnemyHealth>();
		anim = GetComponent <Animator>();
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject == Player){
			playerInRange = true;
		}

	}
	void OnTriggerExit(Collider other){
		if(other.gameObject == Player){
			playerInRange = false;
		}
	}
	void Update(){
		Timer += Time.deltaTime;

		if ( Timer >= timeBetweenAttacks && playerInRange && enemyHealth.currenthealt >0) {
			Attack();
			anim.SetTrigger("Enemy_Serang");
			if(playerHealt.currentHealt != 0){
				anim.SetTrigger("Enemy_Serang");
			}
		}
		if(playerHealt.currentHealt <= 0){
			anim.SetTrigger("Player_Matih");
		}

	}
	void Attack(){
		Timer = 0f;

		if(playerHealt.currentHealt >0  ){
			playerHealt.TakeDamage(attackDamage);

		}
	}
	



}
