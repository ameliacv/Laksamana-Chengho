using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	public int startingHealth = 100 ;
	public int currenthealt;
	public float sinkSpeed = 2.5f;
	public int scoreValue=10;

	public AudioClip deathClip;

	Animator anim;
	AudioSource enemyAudio;

	CapsuleCollider capsulCollider;
	bool isDead;
	bool isSinking;


	void Awake(){

		enemyAudio = GetComponent<AudioSource>();
		anim = GetComponent <Animator> ();
		capsulCollider = GetComponent<CapsuleCollider>();
		currenthealt = startingHealth;

	}
	void Update(){
		if(isSinking){
			transform.Translate(-Vector3.up * sinkSpeed * Time.deltaTime);
		}
	}


	public void TakeDamage (int amount){
		if (isDead) {
			return;
		} else {
			enemyAudio.Play ();
			currenthealt -= amount;	
			if (currenthealt <= 0) {
				Death ();
			}
		}
	}
	void Death(){
		isDead = true;
		capsulCollider.isTrigger = true;
		anim.Play("Die");
		enemyAudio.clip = deathClip;
		enemyAudio.Play ();

	}

	public void StartSinking(){

		GetComponent <Rigidbody> ().isKinematic = true;
		isSinking = true;
		ScoreManager.score += scoreValue;

	}

}
