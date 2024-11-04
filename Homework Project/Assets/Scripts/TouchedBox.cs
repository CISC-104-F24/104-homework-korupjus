using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class YouTouchedBox : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.LogWarning("You bumped into a box!");
            Destroy(gameObject);
        }
    }
    
}

