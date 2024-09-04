using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterScene : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartCoroutine(PlayAudioAndLoadScene("Scene1"));
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(PlayAudioAndLoadScene("Scene2"));
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            StartCoroutine(PlayAudioAndLoadScene("Scene3"));
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            StartCoroutine(PlayAudioAndLoadScene("Scene4"));
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            StartCoroutine(PlayAudioAndLoadScene("Minigame"));
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            StartCoroutine(PlayAudioAndLoadScene("VisualNovel"));
        }
    }

    IEnumerator PlayAudioAndLoadScene(string sceneName)
    {
        source.PlayOneShot(clip);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneName);
    }
}