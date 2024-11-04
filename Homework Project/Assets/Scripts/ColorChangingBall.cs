using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangingBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.LogWarning("The ball feels very sad after the player leaves(It turned blue get it...).");
            GetComponent<MeshRenderer>().material.color = Color.blue;
        }
    }
}
