using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    [SerializeField] private int playerNumber = 1;
    private Rigidbody2D rb;
    private readonly float jumpForce = 5;

    private float _horizontal;
    private bool isJumping = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _horizontal = Input.GetAxis($"P{playerNumber}Horizontal");

        if (Input.GetButtonDown($"P{playerNumber}Jump"))
            isJumping = true;

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //float v = Input.GetAxis("Vertical");

        // COSì NON GESTISCO LA GRAVITA --> ANDREBBE AGGIUNTO UN FLOAT CHE RAPPRESENTA LA VELOCITA VERTICALE DA INCREMENTARE DI -9.81f * Time.deltaTime
        //Vector2 dir = new Vector2(h, 0); //transform.position.y);
        //rb.MovePosition(rb.position + dir * (speed * Time.deltaTime));
        //transform.position = transform.position + dir * (speed * Time.deltaTime);

        // così gestisco già la gravita
        Vector2 velocity = rb.velocity;
        velocity.x = _horizontal * speed;
        if (isJumping)
        {
            velocity.y = jumpForce;
            isJumping = false;
        }
        rb.velocity = velocity;
        
    }
}
