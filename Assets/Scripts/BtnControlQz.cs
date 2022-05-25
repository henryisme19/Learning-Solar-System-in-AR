using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnControlQz : MonoBehaviour
{
    public void ChangeSceneBack()
    {
        SceneManager.LoadScene("MainPage");
    }

    public void ChangeSceneQz1()
    {
        SceneManager.LoadScene("Qz1");
    }

    public void ChangeSceneQz2()
    {
        SceneManager.LoadScene("Qz2");
    }

    public void ChangeSceneQz3()
    {
        SceneManager.LoadScene("Qz3");
    }
}
