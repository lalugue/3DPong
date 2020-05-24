using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentMovement : MonoBehaviour
{    
    public int velocity = 5;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 oldposition = this.transform.position;
        Vector3 target = new Vector3(ball.transform.position.x,0,0);
        target = new Vector3(target.x - oldposition.x, 0, 0);
        
        
        //this.transform.position += (target - oldposition) * velocity * Time.deltaTime;
        this.transform.position += target * velocity * Time.deltaTime;
        //Debug.Log("Target position is: " + this.transform.position);
        
    }
}
