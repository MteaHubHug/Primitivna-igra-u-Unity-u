using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kretanje1 : MonoBehaviour
{
    Rigidbody2D rb;

    // Player Movement Variables/....
    public static int movespeed = 3;
    public Vector3 userDirection = Vector3.right;

    public float jumpForce;
   
    void Start()  // Start is called before the first frame update
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    void Update()      // Update is called once per frame
    {
        transform.Translate(userDirection * movespeed * Time.deltaTime);
        Jump();
    }
}
