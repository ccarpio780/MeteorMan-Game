using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void LoadScene()
    {

        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }


}
