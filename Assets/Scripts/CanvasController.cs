using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    public GameObject canvas;
    public Text text1, text2, text3;
    public Text planetName;

    void Start()
    {
        showInfo();
        Hide();
    }

    public void showInfo(int id = 3)
    {
        canvas.gameObject.SetActive(true);
        planetName.text = Stuff.mercury["namerus"];
        text1.text = Stuff.mercury["dist"];
        text2.text = Stuff.mercury["weight"];
        text3.text = Stuff.mercury["desc"];
    }

    public void Hide()
    {
        canvas.gameObject.SetActive(false);
    }
}
