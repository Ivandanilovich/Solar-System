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
            {"Mercury",     new MyPlanet(){obj = planetObj[0]}},
            {"Venus",       new MyPlanet(){obj = planetObj[1]}},
            {"Earth",       new MyPlanet(){obj = planetObj[2]}},
            {"Mars",        new MyPlanet(){obj = planetObj[3]}},
            {"Jupiter",     new MyPlanet(){obj = planetObj[4]}},
            {"Uranus",      new MyPlanet(){obj = planetObj[5]}},
            {"Neptune",     new MyPlanet(){obj = planetObj[6]}}
        };

        foreach (var p in planets.Values)
        {
            p.obj.transform.position = p.StartPosition();
        }
    }


    void Update()
    {

    }
}
