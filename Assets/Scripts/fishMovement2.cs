using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishMovement2 : MonoBehaviour {
    public float movementSpeed2;
	public float turnSpeed2;

	public String fishNumInput2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void FixedUpdate()
    {
        //print("!");
	//	Vector3 moveForward = movementSpeed2 * new Vector3(Input.GetAxis("Horizontal2") * Time.deltaTime, Input.GetAxis("Vertical2") * Time.deltaTime, 0);
	//	transform.position += moveForward*Time.deltaTime * turnSpeed2;
	//	transform.up += moveForward.normalized;
	    
	    MoveTowards(movementSpeed2, turnSpeed2, fishNumInput2);

    }
	void MoveTowards(float myMoveSpeed, float myTurnSpeed,string fishNum)
	{
		Vector3 moveForward = myMoveSpeed * new Vector3(Input.GetAxis("Horizontal2"+fishNum) * Time.deltaTime, Input.GetAxis("Vertical2"+fishNum) * Time.deltaTime, 0);
        transform.position += moveForward;
		transform.up += moveForward.normalized * Time.deltaTime * myTurnSpeed; ;

	}
}
