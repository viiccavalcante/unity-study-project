using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    public Animator animator;
    public Transform weapon;
    private int currentIndex = 0;
    public int maxHealth = 3;
    private int currentHealth;
    public HealthBarController healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.UpdateHealth(currentHealth);
    } 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SwitchWeapon();
        }
    }

    void SwitchWeapon()
    {
        int totalWeapons = weapon.childCount;

        weapon.GetChild(currentIndex).gameObject.SetActive(false);

        currentIndex = (currentIndex + 1) % totalWeapons;
        weapon.GetChild(currentIndex).gameObject.SetActive(true);
    }

    public void Attack()
    {
        animator.SetTrigger("Attack");
    }
    
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        healthBar.UpdateHealth(currentHealth);

        if (currentHealth <= 0)
        {
            animator.SetTrigger("Kill");
        }
    }
}
