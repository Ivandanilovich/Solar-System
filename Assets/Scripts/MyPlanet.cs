using Assets.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlanet /*: IPlanet*/
{
    public GameObject obj { get; set; }
    public float e { get; set; } = 1f;

    private float sigma = 0;
    private float p = 0.83f;//Фокальный параметр эллипсa p - отрезок который выходит из фокуса эллипсa и перпендикулярный большой полуоси:
    //p=b**2/a


    public void AxisRotate()
    {
        throw new System.NotImplementedException();
    }

    public Vector3 PRotate(float ti)
    {
        sigma += ti;
        //   var r = p / (1 + e * Math.Cos(sigma));
        var r = 10;
        var z = 0;
        var x = r * Math.Cos(sigma);
        var y = r * Math.Sin(sigma);
        return new Vector3((float)x, (float)y, z);
    }

    public Vector3 StartPosition()
    {
        return new Vector3(obj.transform.position.x * GlobalConfigurator.OrbitMul, 0, 0);
    }
}
