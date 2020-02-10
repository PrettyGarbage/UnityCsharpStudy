using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Util : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Container<string> container = new Container<string>();
        container.messages = new string[3];

        container.messages[0] = "Hello";
        container.messages[1] = "World";
        container.messages[2] = "Generic";

        for(int i = 0; i < container.messages.Length; i++)
        {
            Debug.Log(container.messages[i]);
        }


        Container<int> containert = new Container<int>();
        containert.messages = new int[3];

        containert.messages[0] = 10;
        containert.messages[1] = 20;
        containert.messages[2] = 30;

        for (int i = 0; i < container.messages.Length; i++)
        {
            Debug.Log(containert.messages[i]);
        }
    }
}

public class Container<T>
{
    public T[] messages;
}