using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void ToScene2()
    {
        SceneManager.LoadScene("Scene2");
    }

    public void ToScene3()
    {
        SceneManager.LoadScene("Scene3");
    }
}
