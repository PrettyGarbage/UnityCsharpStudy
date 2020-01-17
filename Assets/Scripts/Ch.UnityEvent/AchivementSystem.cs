using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AchivementSystem : MonoBehaviour
{
    public TextMeshProUGUI achivementText;

    public void UnLockAchivement(string title)
    {
        Debug.Log("도전과제 해제 : " + title);
        achivementText.text = "도전과제 해제" + title;
    }
}
