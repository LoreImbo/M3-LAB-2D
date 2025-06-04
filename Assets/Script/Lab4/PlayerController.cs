using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    private Rigidbody2D rb;
    // le avevo scritte qui perché mi servivano poi in FixedUpdate
    //private float _horizontal;
    //private float _vertical;
    private Vector2 input;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float _horizontal = Input.GetAxis($"Horizontal");
        float _vertical = Input.GetAxis("Vertical");

        input = new Vector2(_horizontal, _vertical).normalized;

    }

    void FixedUpdate()
    {
        rb.velocity = input * speed;
    }
}
