using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingTwins : MonoBehaviour
{
    public GameObject twinOne;
    public GameObject twinTwo;
    public GameObject switchOne;
    public GameObject switchTwo;
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
        if(collision.gameObject.CompareTag("Switch1"))
        {
            twinTwo.SetActive(false);
            twinOne.SetActive(true);
        }
        if (collision.gameObject.CompareTag("Switch2"))
        {
            twinOne.SetActive(false);
            twinTwo.SetActive(true);
        }
    }
}
