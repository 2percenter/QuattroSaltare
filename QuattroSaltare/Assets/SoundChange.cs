using UnityEngine;
using System.Collections;

public class SoundChange : MonoBehaviour 
{

	public AudioClip idleSound;       	//Drag your idling sound clip file here in the inspector.
	public AudioClip movingSound;		//Drag your moving sound clip file here in the inspector.
	private AudioSource m_audioSource;
	
	void Start () 
	{
		m_audioSource = gameObject.GetComponent<AudioSource> (); //locates the game object's audio source that you say you have set up already.
	}

	void Update () 
	{

		if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.RightArrow)) //Checks to see if any arrow key is being pressed down.
		{
			if (m_audioSource.clip != movingSound) //If the moving sound isn't already active, it will do so within here.
			{
				m_audioSource.clip = movingSound;
				m_audioSource.Play ();
			}
		}
		else
		{
			if (m_audioSource.clip != idleSound) //We need to go back to the idling sound, so we do that in here.
			{
				m_audioSource.clip = idleSound;
				m_audioSource.Play ();
			}
		}
	
	}
}
