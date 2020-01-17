using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    private int m_point = 0;
    public int point
    {
        get
        {
            Debug.Log(m_point);
            return m_point;
        }
        set
        {
            if (value < 0)
            {
                m_point = 0;
            }
            else if (value > 10000)
            {
                point = 10000;
            }
            else
            {
                m_point = value;

            }
        }
    }

    //SETGET을 사용하면 아래와 같이
    //private int point = 0;

    //public void SetPoint(int newPoint)
    //{
    //    if(newPoint < 0)
    //    {
    //        point = 0;
    //    }
    //    else if(newPoint > 10000)
    //    {
    //        point = 10000;
    //    }
    //    else
    //    {
    //        point = newPoint;
    //    }
    //}

    //public int GetPoint()
    //{
    //    Debug.Log(point);
    //    return this.point;
    //}
}
