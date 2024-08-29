using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    Rigidbody2D rigidbo;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        rigidbo = GetComponent<Rigidbody2D>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Pindah")
        {
            SceneManager.LoadScene("Scene2");
        }

        if (collision.tag == "Balik")
        {
            SceneManager.LoadScene("Scene2");
        }
    }

    // Update is called once per frame
    void Update()
    {
        rigidbo.velocity = new Vector2(0, 0);

        if(Input.GetKey(KeyCode.D))
        {
            rigidbo.velocity = new Vector2(speed, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rigidbo.velocity = new Vector2(-speed, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            rigidbo.velocity = new Vector2(0, speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rigidbo.velocity = new Vector2(0, -speed);
        }
    }
}
