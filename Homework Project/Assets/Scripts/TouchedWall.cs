using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public float playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = 500;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall")) 
        {
            Debug.LogWarning("Get off the wall!"); 
        }
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall")) 
        {
            Debug.LogWarning("You are being shocked!");
            playerHealth = playerHealth - (20* Time.deltaTime);
            Debug.Log("Health Remaining: " + playerHealth);
            if(playerHealth < 0)
            { 
                playerHealth = 0; 
            }
            

        }
    }
    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}
