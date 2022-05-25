using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExerciseManager : MonoBehaviour
{
    public List<QuestionAndAnswerEx> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject ExercisePanel;
    public GameObject GoPanel;

    public Text QuestionText;
    public Text AnswerText;
    public Button NextBtn;

    int totalQuestions = 0;

    private void Start()
    {
        totalQuestions = QnA.Count;
        GoPanel.SetActive(false);
        generateQuestion();
        AnswerText.gameObject.SetActive(false);
        NextBtn.gameObject.SetActive(false);
    }

    public void ChangeSceneQuit()
    {
        SceneManager.LoadScene("Exercises");
    }

    public void redo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GameOver()
    {
        ExercisePanel.SetActive(false);
        GoPanel.SetActive(true);
    }

    public void correct()
    {
        //when you are right
        AnswerText.gameObject.SetActive(true);
        NextBtn.gameObject.SetActive(true);
        AnswerText.text = "Correct Answer: " + QnA[currentQuestion].Answer[QnA[currentQuestion].CorrectAnswer];
    }

    public void wrong()
    {
        //when you answer wrong
        AnswerText.gameObject.SetActive(true);
        NextBtn.gameObject.SetActive(true);
        AnswerText.text = "Correct Answer: " + QnA[currentQuestion].Answer[QnA[currentQuestion].CorrectAnswer];
    }

    public void nextQuestion()
    {
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
        AnswerText.gameObject.SetActive(false);
        NextBtn.gameObject.SetActive(false);
    }

    void SetAnswer()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScriptEx>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answer[i];

            if (QnA[currentQuestion].CorrectAnswer == i)
            {
                options[i].GetComponent<AnswerScriptEx>().isCorrect = true;
            }
        }
    }

    void generateQuestion()
    {
        if (QnA.Count > 0)
        {
            currentQuestion = UnityEngine.Random.Range(0, QnA.Count);

            QuestionText.text = QnA[currentQuestion].Question;
            SetAnswer();
        }
        else
        {
            Debug.Log("Out of Questions");
            GameOver();
        }


    }

}