using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertTest : MonoBehaviour
{
    public PointManager pointManager;

    private void Start()
    {
        pointManager.point = 1000;
        pointManager.point = -10000;

        //Set Get을 이용한 방식

        //pointManager.SetPoint(100);

        //int myPoint = pointManager.GetPoint();
        //Debug.Log("현재 포인트 : " + myPoint);

        //pointManager.SetPoint(-10000);
        //myPoint = pointManager.GetPoint();
        //Debug.Log("현재 포인트 : " + myPoint);
    }
}
