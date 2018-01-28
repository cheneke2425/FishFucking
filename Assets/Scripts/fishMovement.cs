using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using JetBrains.Annotations;
using UnityEngine;

public class fishMovement : MonoBehaviour
{
	//movement
	public float movementSpeed = 3f;
	public float turnSpeed;
	public string fishNumInput;
	
	void FixedUpdate()
	{
		MoveTowards(movementSpeed, turnSpeed, fishNumInput);

	}
	void MoveTowards(float myMoveSpeed, float myTurnSpeed, string fishNum)
	{
		Vector3 moveForward = myMoveSpeed * new Vector3(Input.GetAxis("Horizontal1" + fishNum), Input.GetAxis("Vertical1" + fishNum), 0);
		transform.position += moveForward * Time.deltaTime;
		transform.up += moveForward.normalized * Time.deltaTime * myTurnSpeed;
		
	}
	
	void OnTriggerEnter2D(Collider2D item)
	{
		item.gameObject.SetActive(false);
		//items++;
		print("item picked up");
	}
	
}
