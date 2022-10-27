using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] Transform attackPoint;
    [SerializeField] float damage;
    public Animator animator;
    [SerializeField] float attackDelay;
    [SerializeField] float attackRange;
    [SerializeField] LayerMask humanoids;
    float currentAttackDelay;
    PlayerLose playerLose;
    Health health;
    private void Awake()
    {
        currentAttackDelay = attackDelay;
        playerLose = GetComponent<PlayerLose>();
        health = GetComponentInChildren<Health>();
    }
    private void Update()
    {
        if (health.isDead)
            Die();
    }
    public void Attack(bool isAttacking)
    {
        if (isAttacking && currentAttackDelay >= attackDelay)
            StartCoroutine(StartAttack());
        
    }
    IEnumerator StartAttack()
    {
        animator.SetTrigger("Attacking");
        currentAttackDelay -= Time.deltaTime;
        yield return new WaitForSeconds(attackDelay);
        currentAttackDelay = attackDelay;
    }
    public void Hit()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, humanoids);
        foreach (var enemy in hitEnemies)
            enemy.GetComponentInChildren<Health>().GetDamage(damage);
    }
    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
    public void Die()
    {
        animator.SetTrigger("Death");
        StartCoroutine(Lose());
    }
    IEnumerator Lose()
    {
        yield return new WaitForSeconds(1);
        playerLose.losePanel.SetActive(true);
    }
}
