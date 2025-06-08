using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ControllerPlayer = PlayerControllers.PlayerController;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    private static ControllerPlayer _player;
    private Rigidbody2D _rb;

    void Awake()
    {
        if (_player == null)
        {
            _player = FindAnyObjectByType<ControllerPlayer>();
        }
        _rb = GetComponent<Rigidbody2D>();
    }

    public void EnemyMovement()
    {
        if (_player != null && _player.gameObject != null)
        {
            _rb.MovePosition(Vector2.MoveTowards(_rb.position, _player.transform.position, speed * Time.deltaTime));
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.TryGetComponent<ControllerPlayer>(out ControllerPlayer _player))
        {
            Destroy(_player.gameObject);
        }
    }
    void Update()
    {
        EnemyMovement();
    }
}
