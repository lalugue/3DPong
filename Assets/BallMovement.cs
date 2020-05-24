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

     //this.gameObject.GetComponent<Rigidbody>().AddForce(direk * velocity);

     //Debug.Log("Ball is moving");
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position += (direk) * velocity * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected!");

         // get the point of contact
         ContactPoint contact = collision.contacts[0];
         
         
         // reflect our old velocity off the contact point's normal vector
         Vector3 normal = contact.normal;
         //Vector3 normalProject = new Vector3(normal.x, normal.y, 0);
         //Vector3 newdirek = Vector3.Project(normal,normalProject);         
         direk = Vector3.Reflect(direk, normal);
         direk = Vector3.ProjectOnPlane(direk, Vector3.down);  
         


        //direk = Vector3.Reflect(direk, collision.transform.position);
    }
}
