using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyedBox : MonoBehaviour
{
    public float boxesDestroyed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            boxesDestroyed = boxesDestroyed + 1;
            Debug.LogWarning("You have destroyed " + boxesDestroyed + " box/es.");
        }
    }
}
