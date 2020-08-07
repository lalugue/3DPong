using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Tooltip("Speed of the paddle")]
    public int velocity = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.LeftArrow)){
            Vector3 position = this.transform.position;            
            this.transform.position += Vector3.left * velocity * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow)){
            Vector3 position = this.transform.position;            
            this.transform.position += Vector3.right * velocity * Time.deltaTime;
        }
    }
}
