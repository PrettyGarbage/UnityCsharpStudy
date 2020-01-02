using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZRoatator : BaseRoatator
{
    protected override void Rotate()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}
