using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour //handles the player movement for the fish
{
    Vector3 moveForward;
    public float movementSpeed = 5f;
    public float turnSpeed = 30f;
    
    
    bool fishCanDash = true;
    public float dashSpeed = 5f;
    public float dashCoolDownSeconds = 3f;
    
    
    public string fishNumInput;

    
    void FixedUpdate()
    {
        Moving(movementSpeed, turnSpeed, fishNumInput);
        FishDash(); 
    }


    void Moving(float myMoveSpeed, float myTurnSpeed, string fishNum) //function that uses black magic to make the fish move
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
        
    }
   

    void FishDash() //dashing function 
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

   

 }
