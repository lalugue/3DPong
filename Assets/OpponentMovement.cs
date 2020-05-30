using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentMovement : MonoBehaviour
{    
    public int velocity = 5;
    public GameObject ball;
    Rigidbody rb;
     Vector3 size;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        Debug.Log("The fixed time interval is: " + Time.fixedDeltaTime);
        size = this.GetComponentInChildren<Renderer>().bounds.size;
     
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(ball != null) {
            Vector3 oldposition = this.transform.position;
            Vector3 target = new Vector3(ball.transform.position.x,0,0);
            target = new Vector3(target.x,oldposition.y,oldposition.z);
            
            
            if(Mathf.Abs(ball.transform.position.x - this.transform.position.x) >= size.magnitude/2){
                rb.velocity = (target - oldposition).normalized * velocity;            
            }
            
            
        }
        
    }

    
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name != "ball"){
            this.transform.position = this.transform.position;
        }
        
    }
}
