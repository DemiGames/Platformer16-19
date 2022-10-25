using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] float currentHP;
    [SerializeField] float maxHP;
    Slider hpSlider;
    Damaging damaging;
    public bool isDead;
    private void Awake()
    {
        hpSlider = GetComponentInChildren<Slider>();
        currentHP = maxHP;
        hpSlider.value = maxHP;
        damaging = GetComponentInParent<Damaging>();
        isDead = false;
    }
    public void GetDamage(float damage)
    {
        currentHP -= damage;
        hpSlider.value = currentHP / maxHP;
        if (currentHP <= 0)
        {
            hpSlider.value = 0;
            damaging.Die();
        }
    }
}
