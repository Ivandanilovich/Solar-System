using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlanet: IPlanet
{
    public GameObject obj { get; set; }

    public void AxisRotate()
    {
        throw new System.NotImplementedException();
    }

    public void PRotate()
    {
        throw new System.NotImplementedException();
    }

    public Vector3 StartPosition()
    {
        return new Vector3(obj.transform.position.x * GlobalConfigurator.OrbitMul, 0, 0);
    }
}
