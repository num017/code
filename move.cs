using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{
    public Rigidbody2D Pl;
    public float speed;
    public GameObject p2;

    void Update()
    {
        Move();
        if(p2==false)
        {
            SceneManager.LoadScene("");
        }
    }

    void Move()
    {
        float horizontalmove = Input.GetAxisRaw("Horizontal");
        Pl.velocity = new Vector2(horizontalmove * speed, Pl.velocity.y);
        if (horizontalmove != 0)
        {
            transform.localScale = new Vector3(horizontalmove, 1, 1);
        }
    }

}
