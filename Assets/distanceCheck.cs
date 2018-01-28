using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distanceCheck : MonoBehaviour {
    public float maxDistance;
    public GameObject fish1;
    public GameObject fish2;
    public float fishDistance;
    //
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       fishDistance = Vector3.Distance(fish1.transform.position, fish2.transform.position);
        if(fishDistance>maxDistance)
        {
            print("fishes are dead");
        }

	}
}
