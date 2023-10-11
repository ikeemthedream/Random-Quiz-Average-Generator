using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIData : MonoBehaviour
{
    public TMP_Text titleText;

    Controller ctr = new Controller();
    private float[] quizScore;
    private float avg;
    [SerializeField]
    private TMP_Text[] texts;
    [SerializeField]
    private TMP_Text letterGrade;

    private void Start()
    {
        Controller.DisplayTitle(titleText);
    }

    public void Run()
    {
        ctr.CalculateAverage(quizScore, avg, texts, letterGrade);
    }

    private void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
            
        //}
    }
}
