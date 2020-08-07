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
    static string scorer = "";
    void Start()
    {
    
        
        float horidirek = Random.Range(-1,1);
        horidirek = (horidirek != 0) ? horidirek : 1;     
        horidirek = horidirek/Mathf.Abs(horidirek); 
        hori = new Vector3(horidirek, 0, 0);
        verti = scorer == "Player" ? Vector3.forward : Vector3.back;
        direk = hori + verti;
        
        Debug.Log("scorer dictating ball direction is: " + scorer);
        Debug.Log("direk x is:" + direk.x);      
        
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

         Debug.Log(collision.gameObject.name);
         if((collision.gameObject.name == "Opponent") || (collision.gameObject.name == "Player")){
             velocity++;
         }
         
         
         // reflect our old velocity off the contact point's normal vector
         Vector3 normal = contact.normal;                  
         direk = Vector3.Reflect(direk, normal);
         direk = Vector3.ProjectOnPlane(direk, Vector3.down);  
           
    }

    public void SetPlayerDirection(string scorername){
        scorer = scorername;
             
    }
}
