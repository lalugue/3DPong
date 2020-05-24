using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public int velocity = 10;
    Vector3 hori;
    Vector3 verti;
    Vector3 direk;
    void Start()
    {
        //this.transform.position += (horizontal+vertical) * velocity * Time.deltaTime;
     hori = Vector3.right;
     verti = Vector3.back;
     direk = hori + verti;

     //Debug.Log("Ball is moving");
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position += (direk) * velocity * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Collision detected!");

         // get the point of contact
         ContactPoint contact = collision.contacts[0];
         
         // reflect our old velocity off the contact point's normal vector
         direk = Vector3.Reflect(direk, contact.normal);   

        //direk = Vector3.Reflect(direk, collision.transform.position);
    }
}
