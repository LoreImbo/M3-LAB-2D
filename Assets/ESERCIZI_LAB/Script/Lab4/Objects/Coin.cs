using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private static int _totalCoins = 0;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _totalCoins++;
            Debug.Log($"Il {other.name} ha raccolto {_totalCoins} coins");
            Destroy(gameObject);
        }        
    }
}
