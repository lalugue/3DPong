using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ball;
    public GameObject scorer;
    public StateManager manager;
    //public static  StateManager manager;
    
    
    void Start()
    {
         //manager = GetComponent(typeof(StateManager)) as StateManager;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Score detected!");
         

         Destroy(ball);
         Debug.Log("Ball destroyed!");

            
         manager.UpdateScore(scorer);

        
          

        
    }
}
