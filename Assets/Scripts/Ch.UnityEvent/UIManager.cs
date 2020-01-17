using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI playerStateText;

    public void OnPlayerDead()
    {
        playerStateText.text = "You Die!";
    }
}
