using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealthModified : MonoBehaviour
{
    public UnityEvent onPlayerDead;

    private void Dead()
    {
        onPlayerDead.Invoke();
        Debug.Log("dead");

        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Dead();
    }
}
