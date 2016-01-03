using UnityEngine;
using System.Collections;

public class movetowards : MonoBehaviour {

	public GameObject moveToThis;
	private Vector2 moveToThisV2;
	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () 
	{
		moveToThisV2 = moveToThis.transform.position;

		transform.position = Vector2.MoveTowards (gameObject.transform.position, moveToThisV2, 5 * Time.deltaTime);
	
	}
}
