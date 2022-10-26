using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Health health;
    Animator animator;
    private void Awake()
    {
        health = GetComponentInChildren<Health>();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (health.isDead)
            Die();
    }
    void Die()
    {
        animator.SetTrigger("Death");
        gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        Invoke("DestroyEnemy", 1);
    }
    void DestroyEnemy()
    {
        Destroy(this.gameObject);
    }
}
