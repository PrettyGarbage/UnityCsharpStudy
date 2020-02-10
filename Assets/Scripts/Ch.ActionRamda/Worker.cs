using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Worker : MonoBehaviour
{
    Action work;

    //Action work와 같음 (Action은 매개변수를 받지 않고 리턴하지 않는 일들에만 가능 자주쓰이니 만들어진 예약어)
    //delegate void Action();
    //void work;

    void MoveBricks()
    {
        Debug.Log("벽돌을 옮겼다.");
    }

    void DigIn()
    {
        Debug.Log("땅을 팠다.");
    }

    private void Start()
    {
        work += MoveBricks;
        work += DigIn;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            work();
        }
    }
}
