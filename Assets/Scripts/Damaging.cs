using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damaging : MonoBehaviour
{
    [SerializeField] float damage;
    PlayerLose playerLose;
    Health health;
    Animator animator;
    private void Awake()
    {
        health = GetComponentInChildren<Health>();
        playerLose = GetComponent<PlayerLose>();
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Damagable"))
        {
            collision.gameObject.GetComponentInChildren<Health>().GetDamage(damage);
            //health.GetDamage(damage);
            collision.gameObject.GetComponent<Animator>().SetTrigger("Hurt");
        }
    }
    public void Die()
    {
        health.isDead = true;
        animator.SetTrigger("Death");
        StartCoroutine(Lose());
    }
    IEnumerator Lose()
    {
        yield return new WaitForSeconds(1);
        playerLose.losePanel.SetActive(true);
    }
}
