using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.XR.WSA;

public class AudioManager : MonoBehaviour
{
	//audio sources for the specific parts of the track

	public GameObject item1;
	public GameObject item2;

	public AudioMixer master;
	
	public AudioSource track1;
	public AudioSource track2;
	public AudioSource track3;
	
	public float volume = 0f;

	public Vector3 distanceVector;
	public Vector3 itemDistanceVector;
	public Vector3 itemDistanceVector2;

	public BoxCollider2D collider;

	public GameObject midpoint;

	private bool enteredBox = false;
	void OnCollisionEnter2D (Collision2D collision)
	{
		if (collision.gameObject.tag == "Fuck")
		{
			enteredBox = true;
			play(volume);
			volume = 0.5f;
			volume--;
		}
		
		//volume = 0f;
	}


	private void Update()
	{
		if (item1 == null)
		{
			track1.volume -= 0.1f;
		}

		if (item2 == null)
		{
			track2.volume -= 0.1f;
		}
	}

	private void OnCollisionStay2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Fuck")
		{
			if (enteredBox)
			{
				float distance = distanceVector.magnitude;
				track3.volume = 1 / distance;
				Debug.Log("Fuck me");

				float distance1 = itemDistanceVector.magnitude;
				track1.volume = 1 / distance1;
				
				
				float distance2 = itemDistanceVector2.magnitude;
				track2.volume = 1 / distance2;

			}
		}
	}

	void OnCollisionExit2D(Collision2D collision)
	{
		//if (collision.gameObject.tag == "Fuck")
		//{
			volume = 0f;
		//}
	}

	void play(float volume)
	{
		//audio.volume = volume;
		//audio.Play();
	}

	void FixedUpdate()
	{
		track1.volume = volume;
		distanceVector = midpoint.GetComponent<Transform>().position - transform.position;
		itemDistanceVector = midpoint.GetComponent<Transform>().position - item1.transform.position;
		itemDistanceVector2 = midpoint.GetComponent<Transform>().position - item2.transform.position;
		Debug.Log(volume);
		
	}


}
