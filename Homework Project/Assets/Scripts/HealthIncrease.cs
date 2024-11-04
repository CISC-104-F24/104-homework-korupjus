using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class HealthIncrease : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider collision)
    {
        
       Debug.Log("Your health is increasing!");  
    }
}
