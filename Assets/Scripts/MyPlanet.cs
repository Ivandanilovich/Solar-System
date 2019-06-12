using Assets.Scripts;
using System;
using UnityEngine;

public class MyPlanet : IPlanet
{
    public GameObject obj { get; set; }
    public float e { get; set; } = 0.3f;
    public float dayC { get; set; }
    private float sigma = 0;
    private float p = 0;
    private float rp = 0;

    public Vector3 AxisRotate()
    {
        return new Vector3(0, (float)sigma * dayC, 0);
    }

    public Vector3 PRotate(float ti)
    {
        sigma += (float)(1 / (ti * Math.Sqrt(
            Math.Pow(obj.transform.position.x, 2) +
            Math.Pow(obj.transform.position.y, 2) +
            Math.Pow(obj.transform.position.z, 2)
            ))) * 0.001f;

        var r = p / (1 + e * Math.Cos(sigma));
        var y = 0;
        var x = r * Math.Cos(sigma);
        var z = r * Math.Sin(sigma);
        return new Vector3((float)x, (float)y, (float)z);
    }

    public Vector3 StartPosition()
    {
        rp = obj.transform.position.x * GlobalConfigurator.OrbitMul;
        p = rp * (1 + e);
        return new Vector3(rp, 0, 0);
    }
}
