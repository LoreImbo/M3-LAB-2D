using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerControllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float speed = 5;
        private float _horizontal;
        private float _vertical;
        private Rigidbody2D _rb;
        private Vector2 _dir;
        // Start is called before the first frame update
        void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }
    
        // Update is called once per frame
        void Update()
        {
            _horizontal = Input.GetAxisRaw("Horizontal");
            _vertical = Input.GetAxisRaw("Vertical");
    
            _dir = new Vector2(_horizontal, _vertical).normalized;
        }
    
        void FixedUpdate()
        {
            _rb.MovePosition(_rb.position + _dir * (speed * Time.deltaTime));
        }
    }
}

