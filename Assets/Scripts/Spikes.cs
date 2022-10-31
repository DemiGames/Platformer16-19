using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    float damage = 50;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var health = collision.GetComponentInChildren<Health>();
        if (health == null)
            return;
        else
            health.GetDamage(damage);
    }
}
