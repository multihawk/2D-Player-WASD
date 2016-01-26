using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //moving left + right

        float moveHorizontal = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(moveHorizontal * speed, rb.velocity.y);

        //jumping

        if (Input.GetKeyDown("space")){
            transform.Translate(Vector2.up, Space.World);
        }
    }

    
}