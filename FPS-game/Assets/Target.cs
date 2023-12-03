using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 10f;
    public Vector3 respawnPosition;

    void OnCollisionEnter(Collision collision)
    {
        Bullet bullet = collision.gameObject.GetComponent<Bullet>();
        if (bullet != null)
        {
            health -= bullet.damage;

            if (health <= 0)
            {
                Respawn();
            }
        }
    }

    void Respawn()
    {
        // reset health
        health = 10f;

        // Move target to new respawn position
        transform.position = respawnPosition;
        respawnPosition = new Vector3(Random.Range(-10, 19), Random.Range(1, 5), 8);
    }
}
