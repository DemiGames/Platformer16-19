using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] float currentHP;
    [SerializeField] float maxHP;
    Slider hpSlider;
    public bool isDead;
    private void Start()
    {
        hpSlider = GetComponentInChildren<Slider>();
        currentHP = maxHP;
        hpSlider.value = maxHP;
        isDead = false;
    }
    public void GetDamage(float damage)
    {
        currentHP -= damage;
        hpSlider.value = currentHP / maxHP;
        if (currentHP <= 0)
        {
            hpSlider.value = 0;
            isDead = true;
        }
    }
    
}
