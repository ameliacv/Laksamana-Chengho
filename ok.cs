using UnityEngine;
using System.Collections;

public class ok : MonoBehaviour {
	Animator anim;
	public float timeBetweenAttacks = 0.5f;
	public int attackDamage =50;
	public int distance =5;
	float Timer;

	// Use this for initialization
	void Awake(){
		PlayerHealth playerh = gameObject.GetComponent<PlayerHealth>();
		anim = GetComponent <Animator>();

	}
	// Update is called once per frame
	void Update () {
		Timer += Time.deltaTime;

		if(Input.GetKeyUp("space")){
			anim.Play("Attack");
			GameObject [] enemy;
			enemy = GameObject.FindGameObjectsWithTag("Enemy");

			foreach(GameObject enemi in enemy){
				if(enemi != null && Vector3.Distance(transform.position,enemi.transform.position) < distance){
					playerAttack(enemi);
					Debug.Log("berhasil Mel ");
				}
			}
		}
	}
	void playerAttack(GameObject enemy){
		EnemyHealth enemyHealth = enemy.GetComponent<EnemyHealth>();
		enemyHealth.TakeDamage (attackDamage);
	}


}
