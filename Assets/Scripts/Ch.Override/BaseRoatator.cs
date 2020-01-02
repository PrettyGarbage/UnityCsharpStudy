﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseRoatator : MonoBehaviour
{

    public float speed = 60f;

    private void Update()
    {
        Rotate();
    }

    protected virtual void Rotate()
    {
        transform.Rotate(speed * Time.deltaTime, 0, 0);
    }
}
