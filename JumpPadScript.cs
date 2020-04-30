using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPadScript : MonoBehaviour
{
    //This is code to show a slider in the inspector view so that you can
    //change the value of the bounce height without coming back into the IDE.
    [Range(100, 1000)]
    public float bounceHeight; 

    void OnCollisionEnter(Collision collision)
    {
        GameObject bouncer = collision.gameObject;
        Rigidbody rb = bouncer.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * bounceHeight);
    }

    /*This code works on a gameobject that contains a rigidbody. And
     it also suggests that the upward direction of you game is the (positive0 y-axis
     If there are any problems just let me know ;)  */
}
