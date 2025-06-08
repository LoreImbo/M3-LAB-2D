using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    private int _health = 10;

    public void TakeDamage(int damage)
    {
        Debug.Log($"La vita iniziale del giocatore {gameObject.name} prima di colpire la bomba è pari a {_health}");
        _health -= damage;
        if (_health <= 0)
        {
            Debug.Log($"Il giocatore {gameObject.name} è stato sconfitto");
            Destroy(gameObject);
        }
        Debug.Log($"La vita attuale del giocatore {gameObject.name} è pari a {Mathf.Max(0, _health)}");
    }

    public void TakeHeal(int amount)
    {
        Debug.Log($"La vita iniziale del giocatore prima di curarsi {gameObject.name} è pari a {_health}");
        if (_health <= 0)
        {
            Debug.Log($"Il giocatore {gameObject.name} è stato sconfitto");
            Destroy(gameObject);
        }
        _health += amount;
        Debug.Log($"La vita attuale del giocatore {gameObject.name} è pari a {_health}");

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
