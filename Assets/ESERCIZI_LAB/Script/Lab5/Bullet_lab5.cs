using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullets
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float speed = 5;
        private float _lifeSpan = 5f;
        private Rigidbody2D _rb;

        void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
            Destroy(gameObject, _lifeSpan);
        }

        void OnCollisionEnter2D(Collision2D other)
        {
            if (other.collider.TryGetComponent<Enemy>(out Enemy _enemy))
            {
                Destroy(_enemy.gameObject);
                Destroy(gameObject);
            }
        }

        public void ShootBullet(Vector2 force)
        {
            _rb.AddForce(force * speed, ForceMode2D.Impulse);
        }
    }
}