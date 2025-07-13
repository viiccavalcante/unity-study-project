using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBarController : MonoBehaviour
{
    public GameObject lifes3;
    public GameObject lifes2;   
    public GameObject life1;

    public void UpdateHealth(int currentHealth)
    {

        if (currentHealth >= 3)
        {
            lifes3.SetActive(true);
        }
        else if (currentHealth == 2)
        {
            lifes3.SetActive(false);
            lifes2.SetActive(true);
        }
        else if (currentHealth == 1)
        {
            lifes2.SetActive(false);
            life1.SetActive(true);
        }
        else
        {
            life1.SetActive(false);
        }
    }
}
