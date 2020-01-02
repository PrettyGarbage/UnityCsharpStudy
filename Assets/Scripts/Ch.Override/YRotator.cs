using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YRotator : BaseRoatator
{
    protected override void Rotate()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
