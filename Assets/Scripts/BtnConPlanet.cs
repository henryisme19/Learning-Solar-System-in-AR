using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnConPlanet : MonoBehaviour
{
    //change scene to home
    public void ChangeScene()
    {
        SceneManager.LoadScene("MainPage");
    }
}
