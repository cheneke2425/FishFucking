using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishBoundParticle : MonoBehaviour {
    GameObject myFish1,myFish2;
    float counting = 0;
    float countDirect = 1;
    public float fishBoundSpeed;
        // Use this for initialization
	void Start () {
        myFish1 = GameObject.Find("Fish1");
        myFish2 = GameObject.Find("Fish2");
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 intPos = myFish2.transform.position - myFish1.transform.position;
        transform.position = myFish1.transform.position + counting * intPos;
        counting += Time.deltaTime * 0.01f * countDirect*fishBoundSpeed;

        if (counting >= 1)
        {
            countDirect = -countDirect;
        }
        if (counting <= 0)
        {
            countDirect = -countDirect;
        }

    }
}
