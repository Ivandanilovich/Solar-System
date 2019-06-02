using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void CloseApp()
    {
        Application.Quit();
    }
    public void LoadAbout()
    {
        SceneManager.LoadScene("About");
    }

    public void LoadMain()
    {
        SceneManager.LoadScene("Main");
    }
}
