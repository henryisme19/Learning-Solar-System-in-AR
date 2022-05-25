using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnControlsMP : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("MainApp");
    }

    public void ChangeSceneAR()
    {
        SceneManager.LoadScene("ARmode");
    }

    public void ChangeSceneEX()
    {
        SceneManager.LoadScene("Exercises");
    }

    public void ChangeSceneQz()
    {
        SceneManager.LoadScene("Quizzes");
    }
}
