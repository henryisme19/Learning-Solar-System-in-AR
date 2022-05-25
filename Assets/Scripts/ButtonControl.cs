using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour
{

    public GameObject theText;
    public GameObject thePanel;
    //cancel from quiting the apps
    public void CancelButton() 
    {
        thePanel.SetActive(false);
    }
    //exit button function
    public void CloseButton() 
    {
        thePanel.SetActive(true);
    }
    //quit from the apps
    public void QuitButton() 
    {
        Application.Quit();
    }
    //change scene for login
    public void ChangeScene1()
    {
        SceneManager.LoadScene("LoginScreen");
    }
    //change scene for registration
    public void ChangeScene2()
    {
        SceneManager.LoadScene("RegistrationScreen");
    }
}
