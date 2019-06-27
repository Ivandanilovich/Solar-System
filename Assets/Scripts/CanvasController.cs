using Assets.Scripts;
using Newtonsoft.Json;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    public GameObject canvas;
    public Text text1, text2, text3;
    public Text planetName;
    public Dropdown dropdown;

    private PlanetsStuff[] planetsInfo;

    void Start()
    {
        showInfo();
        Hide();

        var jsonTextFile = Resources.Load<TextAsset>("planets.json");

        planetsInfo = JsonConvert.DeserializeObject<List<PlanetsStuff>>(jsonTextFile.text).ToArray();
    }

    public void showInfo()
    {
        var id = dropdown.GetComponent<Dropdown>().value;
        canvas.gameObject.SetActive(true);
        planetName.text = planetsInfo[id].Namerus;
        text1.text = planetsInfo[id].Dist;
        text2.text = planetsInfo[id].Weight;
        text3.text = planetsInfo[id].Desc;
    }

    public void Hide()
    {
        canvas.gameObject.SetActive(false);
    }
}
