using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] GameObject attackPoint;
    Animator animator;
    [SerializeField] float attackDelay;
    float currentAttackDelay;
    private void Start()
    {
        currentAttackDelay = attackDelay;
        animator = GetComponent<Animator>();
    }
    public void Attack(bool isAttacking)
    {
        if (isAttacking && currentAttackDelay >= attackDelay)
            StartCoroutine(StartAttack());
    }
    public void ActivateAttackPoint()
    {
        attackPoint.SetActive(true);
    }
    public void DeActivateAttackPoint()
    {
        attackPoint.SetActive(false);
    }
    IEnumerator StartAttack()
    {
        animator.SetTrigger("Attacking");
        currentAttackDelay -= Time.deltaTime;
        yield return new WaitForSeconds(attackDelay);
        currentAttackDelay = attackDelay;
    }
}
