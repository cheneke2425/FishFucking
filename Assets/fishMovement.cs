using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishMovement : MonoBehaviour {
    public float movementSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void FixedUpdate()
    {
        transform.position += movementSpeed* new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime, Input.GetAxis("Vertical")*Time.deltaTime, 0);
    }
}
