using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    //bool toucheLeSol = true;

    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(3, rb.velocity.y);

    }

    //So no air jump :)
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "stuff")
        {
            SceneManager.LoadScene("GameOver");
        }
        if(collision.gameObject.tag == "done"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if(collision.gameObject.tag == "ground"){
            if (Input.GetKeyDown("space"))
            {
                rb.velocity = Vector2.zero;
                //rb.AddForce(Vector2.up * 5.6581f, ForceMode2D.Impulse);
                //rb.AddForce(new Vector2(0, 1000));
                //toucheLeSol = false;
            }
        }
    }

}

