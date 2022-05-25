using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnControlExs : MonoBehaviour
{
    public void ChangeSceneBack()
    {
        SceneManager.LoadScene("MainPage");
    }

    public void ChangeSceneEx1()
    {
        SceneManager.LoadScene("Ex1");
    }
    
    public void ChangeSceneEx2()
    {
        SceneManager.LoadScene("Ex2");
    }
    
    public void ChangeSceneEx3()
    {
        SceneManager.LoadScene("Ex3");
    }
}
