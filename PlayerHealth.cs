using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
	public int startingHealt = 100;
	public int currentHealt = 0 ;
	 Slider healtSlider;
	 Image damageImage;
	public float flashSpeed = 5f;
	public Color flashColour = new Color (1f,0f,0f,0.1f);

	Animator anim;
	PlayerGerak playerMovement;

	bool isDead;
	bool damage;

	void Awake(){
		anim = GetComponent <Animator>();
		playerMovement = GetComponent<PlayerGerak>();
		currentHealt = startingHealt;
		healtSlider = GameObject.Find("HeartSlider").GetComponent<Slider>();
		damageImage = GameObject.Find("DamageImage").GetComponent<Image>();
	}

	void Update (){
		if (damage) {
			damageImage.color = flashColour;
		} else {
			damageImage.color = Color.Lerp(damageImage.color,Color.clear,flashSpeed * Time.deltaTime);

		}
		damage = false;
	}
	public void TakeDamage(int amount){
		damage = true;

		currentHealt -= amount;

		healtSlider.value = currentHealt;

		if (currentHealt <= 0 && !isDead) {
			Death();
		}
	}
	public void Death(){
		isDead = true;

		playerMovement.enabled = false;
	}

}
