using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Button attackButton;
    public Button changeTargetButton;
    public Animator playerAnimator;
    public List<Transform> enemies;
    private int currentTargetIndex = 0;
    public GameObject targetPointer;

    private void Start()
    {
        UpdateTargetPointerPos();
    }

    private void Update() {
        UpdateTargetPointerPos();
    }

    public void OnAttackClicked()
    {
        playerAnimator?.SetTrigger("Attack");
    }

    public void OnChangeTargetClicked()
    {
        currentTargetIndex = (currentTargetIndex + 1) % enemies.Count;
        UpdateTargetPointerPos();
    }

    private void UpdateTargetPointerPos()
    {
        if (targetPointer != null && enemies.Count > 0)
        {
            Transform target = enemies[currentTargetIndex];
            Vector3 offset = new Vector3(0, 2f, 0);
            targetPointer.transform.position = target.position + offset;
        }
    }
}
