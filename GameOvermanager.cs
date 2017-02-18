using UnityEngine;
using System.Collections;

public class GameOvermanager : MonoBehaviour {
	public PlayerHealth playerHealth;
	public float restartDelay = 5f;
	GameObject player;
	Animator anim;
	float restartTimer;

	void Awake(){
		anim = GetComponent<Animator>();

	}

	void Update (){
		if(playerHealth.currentHealt <=0 ){
			anim.SetTrigger("GameOver");

			restartTimer += Time.deltaTime;

			if(restartTimer >= restartDelay){
				Application.LoadLevel(Application.loadedLevel);
			}
		}
	}

}
