using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishMovement : MonoBehaviour
{
	public float movementSpeed;
	public float turnSpeed;
	public string fishNumInput;
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}
	void FixedUpdate()
	{
		MoveTowards(movementSpeed, turnSpeed, fishNumInput);
	}
	void MoveTowards(float myMoveSpeed, float myTurnSpeed, string fishNum)
	{
		Vector3 moveForward = myMoveSpeed * new Vector3(Input.GetAxis("Horizontal" + fishNum), Input.GetAxis("Vertical" + fishNum), 0);
		transform.position += moveForward * Time.deltaTime;
		if (moveForward.x >= 0f)
		{
			transform.up = new Vector3(1, 0, 0);
		}
		else
		{
			transform.up = new Vector3(-1, 0, 0);
		}
			
		//transform.up = moveForward.normalized * Time.deltaTime;


	}

	void OnTriggerEnter2D(Collider2D item)
	{
		item.gameObject.SetActive(false);
		print("item picked up");

	}
}
