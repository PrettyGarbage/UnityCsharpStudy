using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintInputField : MonoBehaviour
{
    public void OnInputfieldTextChanged(string newText)
    {
        Debug.Log("타이핑 하는 중");
        Debug.Log(newText);
    }

    public void OnInputFieldTextEnd(string newText)
    {
        Debug.Log("타이핑 끝");
        Debug.Log(newText);

    }
}
