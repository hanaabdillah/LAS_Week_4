using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterScene : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene("Scene1");
        }

        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("Scene2");
        }

        if (Input.GetKey(KeyCode.Tab))
        {
            SceneManager.LoadScene("Scene3");
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Scene4");
        }
    }
}
