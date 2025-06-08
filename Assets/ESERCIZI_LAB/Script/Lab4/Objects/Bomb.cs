using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private int damage = 3;
    private void OnTriggerEnter2D(Collider2D other)
    {
        bool result = other.TryGetComponent<LifeController>(out LifeController life);

        if (result)
        {
            life.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
