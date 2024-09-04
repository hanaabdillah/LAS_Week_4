using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigamePlayer : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float strength;

    public AudioSource source;
    public AudioClip clip;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidbody.velocity = Vector3.up * strength;

            source.PlayOneShot(clip);
        }
    }
}
