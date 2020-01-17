using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    delegate float Calculate(float a, float b);

    Calculate onCalculate;

    private void Start()
    {
        onCalculate = Sum;
        onCalculate -= Subtract;
        onCalculate += MultiPly;
    }

    public float Sum(float a, float b)
    {
        Debug.Log(a + b);
        return a + b;
    }

    public float Subtract(float a, float b)
    {
        Debug.Log(a - b);
        return a - b;
    }

    public float MultiPly(float a, float b)
    {
        Debug.Log(a * b);
        return a * b;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //onCalculate(1,10);
            Debug.Log("결과값: " + onCalculate(1, 10));
        }
    }
}
