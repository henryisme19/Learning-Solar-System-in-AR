using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScriptEx : MonoBehaviour
{
    public bool isCorrect = false;
    public ExerciseManager exManager;

    public void Answer()
    {
        if (isCorrect)
        {
            Debug.Log("Correct Answer");
            exManager.correct();
        }
        else
        {
            Debug.Log("Wrong Answer");
            exManager.wrong();
        }
    }
}
