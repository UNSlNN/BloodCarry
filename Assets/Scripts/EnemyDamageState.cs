using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageState : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // take damage "player" tag
        if (collision.gameObject.tag == "Player")
        {
            HealthState playerHealth = collision.gameObject.GetComponent<HealthState>();
            if(playerHealth != null)
            {
                playerHealth.PlayerHealth(1, gameObject);
            }
        }
        // knockback when player take damage by enemy
        var player = collision.GetComponent<PlayerController>();
        if(player != null)
        {
            player.Knockback(transform);
        }
    }
}
