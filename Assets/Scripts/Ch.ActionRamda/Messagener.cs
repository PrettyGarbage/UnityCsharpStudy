using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Messagener : MonoBehaviour
{
    public delegate void Send(string receiver);

    Send onSend;

    private void Start()
    {
        onSend += SendMail;
        onSend += SendMoney;
        onSend += man => Debug.Log("Assainate " + man);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            onSend("player");
        }
    }

    void SendMail(string reciever)
    {
        Debug.Log("Mail sent to " + reciever);
    }

    void SendMoney(string reciever)
    {
        Debug.Log("Money sent to " + reciever);
    }
}
