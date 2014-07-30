using UnityEngine;
using System.Collections;

public class RealtimeMovementInputBehavior : MonoBehaviour {
	
	public float maxSpeed = .25f;
	private bool facingRight = true;

	Animator anim;
	
	void Start () 
	{
		anim = GetComponent<Animator> ();
	}
	
	void FixedUpdate () 
	{
		float speed = maxSpeed;
		float moveX = Input.GetAxis ("Horizontal");
		float moveY = Input.GetAxis ("Vertical");

		anim.SetFloat ("Move X", Mathf.Abs (moveX));
		anim.SetFloat ("Move Y", moveY);
		
		if (Mathf.Abs (moveX) > 0 && Mathf.Abs (moveY) > 0)
			speed = speed * .85f;
		
		rigidbody2D.velocity = new Vector2 (moveX * speed, moveY * speed);
		
		if ((moveX > 0 && !facingRight) || (moveX < 0 && facingRight))
			Flip ();
	}
	
	void Flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}