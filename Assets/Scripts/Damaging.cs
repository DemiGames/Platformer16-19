using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damaging : MonoBehaviour
{
    [SerializeField]float damage;
    Health health;
    Animator animator;
    public bool isDead;
    private void Awake()
    {
        health = GetComponentInChildren<Health>();
        animator = GetComponent<Animator>();
        isDead = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Damagable"))
        {
            health.GetDamage(damage);
        }
    }
    public void Die()
    {
        animator.SetTrigger("Death");
        isDead = true;
    }
}
