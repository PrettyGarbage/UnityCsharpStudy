using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public UIManager uIManager;
    public AchivementSystem achivementSystem;
    public GameManager gameManager;

    private void Dead()
    {
        uIManager.OnPlayerDead();
        achivementSystem.UnLockAchivement("뉴턴의 법칙");
        gameManager.OnPlayerDead();

        Debug.Log("Dead");
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Dead();
    }
}
