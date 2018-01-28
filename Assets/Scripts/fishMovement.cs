using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishMovement : MonoBehaviour
{
    public float movementSpeed;
    public float turnSpeed;
    public string fishNumInput;
    Vector3 moveForward;
    public float dashSpeed;
    bool fishCanDash=true;
    public float dashCoolDownSeconds;
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
        FishDash();
        
        
    }
   void LateUpdate()
    {
       
    }


    void MoveTowards(float myMoveSpeed, float myTurnSpeed, string fishNum)
    {
        moveForward = myMoveSpeed * new Vector3(Input.GetAxis("Horizontal" + fishNum), Input.GetAxis("Vertical" + fishNum), 0);
        transform.position += moveForward * Time.deltaTime;

        
        if (moveForward.x > 0f)
        {
            transform.up = new Vector3(1, 0, 0);
        }
        else if (moveForward.x < 0)
        {
            transform.up = new Vector3(-1, 0, 0);
        }

        transform.up = new Vector3(transform.up.x, 0, 0);

      

        //transform.up = new Vector3(moveForward.normalized.x,0,0) * Time.deltaTime;

        //if(transform.up.x>0)
        //{
        //    if(moveForward.x < 0)
        //    {
        //        transform.up = new Vector3(-1, 0, 0);
        //    }
        //}
        //else if(transform.up.x<0)
        //{
        //    if(moveForward.x>0)
        //    {
        //        transform.up = new Vector3(1, 0, 0);
        //    }
        //}
       


    }
   

    void FishDash()
    {
        if(Input.GetButtonDown("Dash"+fishNumInput)&&fishCanDash)
        {
            print("dash");
           GetComponent<Rigidbody2D>().AddForce(dashSpeed*new Vector2(moveForward.x, moveForward.y), ForceMode2D.Impulse);
            fishCanDash = false;
            StartCoroutine(dashCoolDown());
            //GetComponent<Rigidbody2D>().AddForce(dashSpeed * new Vector2(1,1), ForceMode2D.Impulse);
        }
    }
    IEnumerator dashCoolDown()
    {
       
        yield return new WaitForSeconds(dashCoolDownSeconds);
        fishCanDash = true;
    }

    void OnTriggerEnter2D(Collider2D item)
    {
        item.gameObject.SetActive(false);
        print("item picked up");

    }
}