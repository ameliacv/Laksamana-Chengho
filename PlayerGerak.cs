using UnityEngine;


public class PlayerGerak : MonoBehaviour 
{
	public float speed = 6f;

	Vector3 movement;
	Animator anim;
	Rigidbody playerRigid;
	int floorMask;
	float camRayLength = 100f;

	void Awake()
	{
		floorMask = LayerMask.GetMask ("Floor");
		anim = GetComponent<Animator> ();
		playerRigid = GetComponent<Rigidbody> ();
	}

	void FixedUpdate()
	{
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");  

		Move (h, v);
		Turning ();
		Animating (h,v);
	}

	void Move (float h, float v)
	{
		movement.Set (h, 0f, v);

		movement = movement.normalized * speed * Time.deltaTime;

		playerRigid.MovePosition (transform.position + movement);
	}

	void Turning()
	{
		Ray camRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit floorHit;
		if (Physics.Raycast (camRay, out floorHit, camRayLength, floorMask)) {
			Vector3 playerToMouse = floorHit.point - transform.position;
			playerToMouse.y=0f;

			Quaternion newRotation = Quaternion.LookRotation(playerToMouse);
			playerRigid.MoveRotation(newRotation);
		}
	}
	void Animating(float h, float v){
		bool walking = h != 0f || v != 0f;
		anim.SetBool ("isWalking", walking);

	}


	}

