using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSceneTransfer : MonoBehaviour
{

    public string SceneNameStart;
    public string SceneNameOPT;

    public void StartGame()
    {
        SceneManager.LoadScene(SceneNameStart);

    }

    public void options()
    {
        SceneManager.LoadScene(SceneNameOPT);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
