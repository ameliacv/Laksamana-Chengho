#pragma strict

var box : GameObject;
var paused: boolean;

function Start(){
	Time.timeScale =1;
}

function OnTriggerEnter(col : Collider){
	if(col.gameObject.tag == "Player"){
	//	AudioSource.PlayClipAtPoint(suara, transform.position);
		//box.animation.Play();
		Time.timeScale =0;
		Application.LoadLevel ("soal1");
		Destroy(gameObject);
		
	}
	}