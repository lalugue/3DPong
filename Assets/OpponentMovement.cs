using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentMovement : MonoBehaviour
{    
    public int velocity = 5;
    public GameObject ball;
    Rigidbody rb;
    Vector3 size;

    System.Random rnd = new System.Random();
    float[] reactTime = {0.5f, 0.75f, 1};
    int reactPick;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        Debug.Log("The fixed time interval is: " + Time.fixedDeltaTime);
        size = this.GetComponentInChildren<Renderer>().bounds.size;

        reactPick = rnd.Next(3);
     
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(ball != null) {
            Vector3 oldposition = this.transform.position;
            Vector3 target = new Vector3(ball.transform.position.x,0,0);
            target = new Vector3(target.x,oldposition.y,oldposition.z);
            
            
            if(Mathf.Abs(ball.transform.position.x - this.transform.position.x) >= size.magnitude * reactTime[reactPick]){
                rb.velocity = (target - oldposition).normalized * velocity;
                reactPick = rnd.Next(3);            
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
