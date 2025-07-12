using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Animator animator;
    public Transform weapon;
    private int currentIndex = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Kill");
        }

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
}
