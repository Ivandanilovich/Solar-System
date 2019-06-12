using Assets.Scripts;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    public GameObject canvas;
    public Text text1, text2, text3;
    public Text planetName;
    public Dropdown dropdown;

    void Start()
    {
        showInfo();
        Hide();
    }

    public void showInfo()
    {
        var id = dropdown.GetComponent<Dropdown>().value;
        canvas.gameObject.SetActive(true);
        Dictionary<string, string> v;
        switch (id)
        {
            case 0:
                v = Stuff.mercury;
                break;
            case 1:
                v = Stuff.venus;
                break;
            case 2:
                v = Stuff.earth;
                break;
            case 3:
                v = Stuff.mars;
                break;
            case 4:
                v = Stuff.jupiter;
                break;
            case 5:
                v = Stuff.uranus;
                break;
            case 6:
                v = Stuff.neptune;
                break;
            default:
                v = Stuff.earth;
                break;
        }
        planetName.text = v["namerus"];
        text1.text = v["dist"];
        text2.text = v["weight"];
        text3.text = v["desc"];
    }

    public void Hide()
    {
        canvas.gameObject.SetActive(false);
    }
}
