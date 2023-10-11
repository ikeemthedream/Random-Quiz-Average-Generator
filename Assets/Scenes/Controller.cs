using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Reflection;

[System.Serializable]
public class Controller : MonoBehaviour
{
    float[] num = new float[5];
    float avg;
    public static void DisplayTitle(TMP_Text title)
    {
        title.text = "Average Generator";
    }
    public void CalculateAverage(float[] quizScores, float average, TMP_Text[] txt, TMP_Text letterGrade)
    {
        quizScores = new float[5];

        for (int i = 0; i < quizScores.Length; i++)
        {
            quizScores[i] = (Random.Range(1f, 100.1f));
            print($"Quiz {i + 1}: {quizScores[i]}");

            average = average + quizScores[i];
            if (i == quizScores.Length - 1)
            {
                average = average / quizScores.Length;
                txt[i + 1].text = $"Average: {average}";
                print($"Average: {average}");
            }

            txt[i].text = $"Score: {quizScores[i]}";
        }

        LetterGrade(average, letterGrade);
    }

    private static void LetterGrade(float average, TMP_Text letterGrade)
    {
        switch (average)
        {
            case >= 90:
                print("A");
                letterGrade.text = "A";
                Camera.main.backgroundColor= Color.green;
                break;
            case >= 80:
                print("B");
                letterGrade.text = "B";
                Camera.main.backgroundColor = Color.blue;
                break;
            case >= 70:
                print("C");
                letterGrade.text = "C";
                Camera.main.backgroundColor = Color.red;
                break;
            default:
                print("F");
                letterGrade.text = "F";
                Camera.main.backgroundColor = Color.black;
                break;
        }
    }
}
