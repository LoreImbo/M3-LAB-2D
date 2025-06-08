using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BulletClass = Bullets.Bullet;
using ControllerPlayer = PlayerControllers.PlayerController;

public class PlayerShooterController : MonoBehaviour
{
    [SerializeField] private float fireRate = 1f;
    private float _lastShotTime;
    [SerializeField] private float fireRange = 5f;
    public BulletClass bullet;

    public GameObject FindNearestEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject nearestEnemy = null;
        float shortestDistance = Mathf.Infinity;

        foreach (GameObject enemy in enemies)
        {
            float distance = Vector2.Distance(transform.position, enemy.transform.position);
            if (distance < shortestDistance)
            {
                shortestDistance = distance;
                nearestEnemy = enemy;
            }
        }
        if (nearestEnemy == null)
        {
            Debug.Log("Tutti i nemici distrutti");
            return null;
        }
        return nearestEnemy;
    }

    public void Shoot()
    {
        GameObject enemy = FindNearestEnemy();
        if (enemy == null) return;

        if (Vector2.Distance(transform.position, enemy.transform.position) <= fireRange)
        {
            if (Time.time - _lastShotTime > fireRate)
            {
                _lastShotTime = Time.time;
                BulletClass b = Instantiate(bullet, transform.position, transform.rotation);
                Vector2 force = (enemy.transform.position - transform.position).normalized;
                b.ShootBullet(force);
            }
        }
        else
        {
            Debug.Log("Nessun nemico a portata");
        }
            

    }
    void Update()
    {
        Shoot();
    }
}
