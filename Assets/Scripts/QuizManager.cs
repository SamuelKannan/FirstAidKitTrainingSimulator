using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuizManager : MonoBehaviour
{
    public List<Preliminary> QnA;
    public GameObject[] options;
    public int currentQuestion;
    public Text QuestionTxt;
    public Text ScoreTxt;
    int totalQuestions = 0;
    public int score;

    public GameObject QuizPanel;
    public GameObject ScorePanel;
    void Start() 
    {
        totalQuestions = QnA.Count;
        ScorePanel.SetActive(false);
        GenerateQuestions();
    }
    
    void GameOver()
    {
        QuizPanel.SetActive(false);
        ScorePanel.SetActive(true);
        ScoreTxt.text = "You answered " + score + " out of " + totalQuestions + " correctly"; 
    }
    public void Correct()
    {
        score += 1;
        QnA.RemoveAt(currentQuestion);
        GenerateQuestions();
    }

    public void Wrong()
    {
        QnA.RemoveAt(currentQuestion);
        GenerateQuestions();
    }
    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<PreliminaryAnswer>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];

            if (QnA[currentQuestion].CorrectAnswer == i+1)
            {
                options[i].GetComponent<PreliminaryAnswer>().isCorrect = true;
            }
        }
    }

    void GenerateQuestions()
    {
        if (QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);
            QuestionTxt.text = QnA[currentQuestion].Question;
            SetAnswers();
        }
        else
        {
            Debug.Log("Out of Questions");
            GameOver();
        }
    }
}
