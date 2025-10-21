using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void LoadGameScene()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadGameSceneDelay()
    {
        Invoke("LoadGameScene", 4.5f);
    }


    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadMainMenuDelay()
    {
        Invoke("LoadMainMenu", 5f);
    }


    public void QuitGame()
    {
        Application.Quit();
    }
    public void QuitGameDelay()
    {
        Invoke("QuitGame", 4f);
    }

}
