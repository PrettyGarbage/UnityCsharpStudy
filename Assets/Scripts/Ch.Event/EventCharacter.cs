using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventCharacter : MonoBehaviour
{
    public delegate void Boost(EventCharacter target);

    public event Boost playerBoost;

    public string playerName = "player";

    public float hp = 100;
    public float defense = 50;
    public float damage = 30;

    private void Start()
    {
        playerBoost(this);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerBoost(this);
        }
    }
}
