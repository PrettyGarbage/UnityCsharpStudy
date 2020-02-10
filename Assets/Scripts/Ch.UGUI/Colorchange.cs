using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colorchange : MonoBehaviour
{
    public Toggle toggle;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeColor(int index)
    {
        Color color = Color.white;

        switch(index)
        {
            case 0:
                color = Color.red;
                break;
            case 1:
                color = Color.blue;
                break;
            case 2:
                color = Color.green;
                break;
            case 3:
                color = Color.white;
                break;
        }
        GetComponent<Renderer>().material.color = color;

    }
}
