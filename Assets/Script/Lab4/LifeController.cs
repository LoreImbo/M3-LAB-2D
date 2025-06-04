using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    private int _health = 10;

    private void TakeDamage(int damage)
    {
        Debug.Log($"La vita attuale del giocatore {gameObject.name} è pari a {_health}");
        _health -= damage;
        if (_health <= 0)
        {
            Debug.Log($"Il giocatore {gameObject.name} è stato sconfitto");
            Destroy(gameObject);
        }
    }

    private void TakeHeal(int amount)
    {
        Debug.Log($"La vita attuale del giocatore {gameObject.name} è pari a {_health}");
        if (_health <= 0)
        {
            Debug.Log($"Il giocatore {gameObject.name} è stato sconfitto");
            Destroy(gameObject);
        }
        _health += amount;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
