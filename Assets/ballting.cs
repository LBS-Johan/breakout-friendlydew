using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballting : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(4, 4);
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 4;
        rb.velocity = rb.velocity.normalized * speed;

        if(transform.position.y < -5)
        {
            transform.position = new Vector2(0, -3);
        }


    }
}
