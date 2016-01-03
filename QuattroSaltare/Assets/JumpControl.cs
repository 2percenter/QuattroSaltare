using UnityEngine;
using System.Collections;

public class JumpControl : MonoBehaviour {

	float jumpCount;
	public Vector2 jumpForce = new Vector2(0, 300);
	bool grounded;

//	void Update()
//	{
//		// If the character has more than 0 jumps left
//		if (Input.GetKeyDown("space") && jumpCount > 0)
//		{
//			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
//			GetComponent<Rigidbody2D>().AddForce(jumpForce);
//			jumpCount--; // Reduce the amount of jumps left by 1
//		}
//		// If the character is touching the ground
//		if (grounded)
//		{
//			jumpCount = 4; // Reset amount of jumps left to 4
//		}
//	}
//	
//	void OnCollisionEnter2D(Collision2D col) // When the character collides with something
//	{
//		if(col.collider.tag == "ground") // If the object has the tag "ground"
//		{
//			grounded = true;
//		}
//	}
//	void OnCollisionExit2D(Collision2D col) // When the character stops colliding with something
//	{
//		if(col.collider.tag == "ground") // If the object has the tag "ground"
//		{
//			grounded = false;
//		}
//	}

	void Update()
	{
		// If the character has more than 0 jumps left
		if (Input.GetKeyDown("space") && jumpCount > 0)
		{
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			GetComponent<Rigidbody2D>().AddForce(jumpForce);
			jumpCount--; // Reduce the amount of jumps left by 1
		}
	}
	void OnCollisionEnter2D(Collision2D col) // When the character collides with something
	{
		if(col.collider.tag == "ground") // If the object has the tag "ground"
		{
			jumpCount = 4;
		}
	}


}
