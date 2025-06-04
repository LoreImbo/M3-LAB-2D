using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    private int countPlayers = 0;
    private int totalPlayers;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            countPlayers++;
            Debug.Log($"Il {other.name} è entrato in {gameObject.name}");
            if (countPlayers == totalPlayers) // prima avevo scritto == 2
            {
                Debug.Log("Livello completato");
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            countPlayers--;
            Debug.Log($"Il {other.name} è uscito da {gameObject.name}");
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        totalPlayers = GameObject.FindGameObjectsWithTag("Player").Length;
        Debug.Log($"Numero totale di Player nella scena: {totalPlayers}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
