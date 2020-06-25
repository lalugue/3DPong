using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleCredits : MonoBehaviour
{
    public GameObject CurrentUI;
    public GameObject NextUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }
   

    public void ToggleCreditsUI(){
        HideCurrentUI();
        ShowNextUI();
    }

    void HideCurrentUI(){       
       CurrentUI.SetActive(false);
    }

    void ShowNextUI(){
        NextUI.SetActive(true);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
