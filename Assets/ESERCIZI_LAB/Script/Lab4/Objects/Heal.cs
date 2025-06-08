using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    [SerializeField] private int healAmount = 1;
    private void OnTriggerEnter2D(Collider2D other)
    {
        bool result = other.TryGetComponent<LifeController>(out LifeController life);

        if (result)
        {
            life.TakeHeal(healAmount);
        }
        Destroy(gameObject);
    }
}
