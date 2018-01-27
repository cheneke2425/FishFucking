using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishMovement2 : MonoBehaviour {
    public float movementSpeed2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void FixedUpdate()
    {
        //print("!");
        transform.position += movementSpeed2* new Vector3(Input.GetAxis("Horizontal2") * Time.deltaTime, Input.GetAxis("Vertical2")*Time.deltaTime, 0);
    }
}
