using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnControlRS : MonoBehaviour
{
    //change scene to home
    public void ChangeScene()
    {
        SceneManager.LoadScene("MainApp");
    }
}
