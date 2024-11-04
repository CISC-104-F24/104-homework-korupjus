using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)

    {
        if (collision.gameObject.CompareTag("Respawn"))
        {
            Debug.LogWarning("The scene is restarting!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
