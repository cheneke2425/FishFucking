using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distanceCheck : MonoBehaviour {
    public float maxSafeDistance;
	public float breakDistance;
    public GameObject fish1;
    public GameObject fish2;
    public float fishDistance;

	SpringJoint2D spring;
    //
	// Use this for initialization
	void Start () {

		spring = GetComponentInChildren<SpringJoint2D>();
		spring.enabled = false;
		
	}
	
	// Update is called once per frame
	void Update () {

		float springDis = spring.distance;
		springDis += 0.1f * Time.deltaTime;
		spring.distance = springDis;

		maxSafeDistance = springDis + 2f;

       fishDistance = Vector3.Distance(fish1.transform.position, fish2.transform.position);
		if (fishDistance > maxSafeDistance)
		{
			GetComponentInChildren<SpringJoint2D>().enabled = true;

			if (fishDistance > breakDistance)
			{
				Debug.Log("dead");
			}

		}
		else {
			GetComponentInChildren<SpringJoint2D>().enabled = false;
		}


	}
}
