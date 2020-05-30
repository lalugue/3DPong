using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentMovement : MonoBehaviour
{    
    public int velocity = 5;
    public GameObject ball;
    Rigidbody rb;
    double lastTime = 0;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        Debug.Log("The fixed time interval is: " + Time.fixedDeltaTime);
     
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(ball != null) {
            Vector3 oldposition = this.transform.position;
            Vector3 target = new Vector3(ball.transform.position.x,0,0);
            target = new Vector3(target.x,oldposition.y,oldposition.z);
            //target = new Vector3(target.x - oldposition.x, 0, 0);
           
            
            
            //this.transform.position += (target - oldposition) * velocity * Time.deltaTime;            
            //rb.MovePosition(target * velocity * Time.deltaTime);
            
            rb.velocity = (target - oldposition).normalized * velocity;
            lastTime = Time.time;
            
            //Debug.Log("Target position is: " + this.transform.position);
        }
        
    }

    
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name != "ball"){
            this.transform.position = this.transform.position;
        }
        
    }
}
