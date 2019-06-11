using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public GameObject[] planetObj;

    

    private Dictionary<string, MyPlanet> planets;

    void Start()
    {
        planets = new Dictionary<string, MyPlanet>()
        {
            {"Mercury",     new MyPlanet(){obj = planetObj[0], dayC = 58}},
            {"Venus",       new MyPlanet(){obj = planetObj[1], dayC = 1.5f}},
            {"Earth",       new MyPlanet(){obj = planetObj[2], dayC = 365}},
            {"Mars",        new MyPlanet(){obj = planetObj[3], dayC = 350}},
            {"Jupiter",     new MyPlanet(){obj = planetObj[4], dayC = 1114}},
            {"Uranus",      new MyPlanet(){obj = planetObj[5], dayC = 42}},
            {"Neptune",     new MyPlanet(){obj = planetObj[6], dayC = 18}}
        };

        foreach (var p in planets.Values)
        {
            p.obj.transform.position = p.StartPosition();
        }


    }

    float t = 0;
    void Update()
    {
        t = 0.01f;
        foreach (var p in planets.Values)
        {
            p.obj.transform.position = p.PRotate(t);
            p.obj.transform.eulerAngles = p.AxisRotate();
        }
        //var p = planets["Earth"];
        //p.obj.transform.position = p.PRotate(t);
        //var v = p.AxisRotate();
        //print(v.y);
        //p.obj.transform.eulerAngles = v;
    }
}
