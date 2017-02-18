using UnityEngine;
using System.Collections;

public class PlayerSerang : MonoBehaviour {
	
	public float timeBetweenAttacks = 0.5f;
	public int attackDamage =50;
	
	Animator anim;
	GameObject Enemy;
	PlayerHealth playerHealt;
	EnemyHealth enemyHealth;
	
	bool enemyInRange;
	float Timer;
	
	
	void Start(){
		Enemy = GameObject.Find("Enemy");
		playerHealt = GetComponent <PlayerHealth>();
		enemyHealth = Enemy.GetComponent<EnemyHealth>();
		anim = GetComponent <Animator>();
	}
	
	void OnTriggerEnter(Collider other){
		if(other.gameObject == Enemy){
			enemyInRange = true;
			Debug.Log("In Range ");
		}
		
	}
	void OnTriggerExit(Collider other){
		if(other.gameObject == Enemy){
			enemyInRange = false;
		}
	}
	void Update(){
		Timer += Time.deltaTime;
		if (Input.GetKeyUp ("space")) {
			anim.Play("Attack",-1,0f);
	/*		if (Timer >= timeBetweenAttacks && enemyInRange && enemyHealth.currenthealt > 0) {
				Attack ();
				anim.SetTrigger ("Player_Serang");
				if (enemyHealth.currenthealt != 0) {
					anim.SetTrigger ("Player_Serang");
				}
				if (!enemyInRange && enemyHealth.currenthealt <= 0) {
					anim.SetTrigger ("Enemy_Mati");
				}
			}*/
		}


		
	}
	void Attack(){
		Timer = 0f;
		
		if(enemyHealth.currenthealt >0  ){
			enemyHealth.TakeDamage(attackDamage);
			
		}
	}
	
	
	
	
}
