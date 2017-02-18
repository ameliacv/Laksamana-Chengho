#pragma strict

//var suara : AudioClip;
var box : GameObject;

function OnTriggerEnter(col : Collider){
	if(col.gameObject.tag == "Player"){
	//	AudioSource.PlayClipAtPoint(suara, transform.position);
		box.animation.Play();
		Application.LoadLevel ("Level1 - Palembang");
		Destroy(gameObject);
		
	}
}