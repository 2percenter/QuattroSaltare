using UnityEngine;
using System.Collections;

public class MoveRotate : MonoBehaviour {


	public Quaternion origRot;
	public float maxAngle;
	public Quaternion maxRotation;
	private float moveHor;
	public float speed;
	public float rotateSpeed;
	public float rotationFraction;

	// Use this for initialization
	void Start () 
	{
		origRot = gameObject.transform.rotation;
		maxRotation = new Quaternion (0.0f, 0.0f, 45.0f, 0.0f);

	}
	
	// Update is called once per frame
	void Update () 
	{
		rotationFraction = Time.deltaTime * rotateSpeed;
		moveHor = Input.GetAxis ("Horizontal"); 
		if (moveHor != 0.0f) {
			gameObject.transform.position = new Vector3 (gameObject.transform.position.x + speed * Time.deltaTime, gameObject.transform.position.y, gameObject.transform.position.z);
			gameObject.transform.rotation = Quaternion.Lerp (origRot, maxRotation, rotationFraction);

		} 
		else 
		{
			gameObject.transform.rotation = Quaternion.Lerp (maxRotation, origRot, rotationFraction);
		}

	}
}
