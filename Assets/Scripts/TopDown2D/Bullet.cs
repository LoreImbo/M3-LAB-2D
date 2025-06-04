using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{
    [SerializeField] private float _lifeSpan = 5;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, _lifeSpan);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject); // <- si distrugge quando collide con qualcosa
    }
}
