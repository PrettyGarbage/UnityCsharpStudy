using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
    public void HealthBoost(EventCharacter character)
    {
        Debug.Log(character.playerName + "이 체력을 강화했다.");
        character.hp += 10;
    }

    public void ShieldBoost(EventCharacter character)
    {
        Debug.Log(character.playerName + "이 방어를 강화했다.");
        character.defense += 10;
    }

    public void DamageBoost(EventCharacter character)
    {
        Debug.Log(character.playerName + "이 공격을 강화했다.");
        character.damage += 10;
    }

    private void Awake()
    {
        EventCharacter player = FindObjectOfType<EventCharacter>();

        player.playerBoost += HealthBoost;
        player.playerBoost += ShieldBoost;
        player.playerBoost += DamageBoost;
    }
}
