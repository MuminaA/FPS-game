using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//new line
using UnityEngine.SceneManagement;//new line

public class TimeLimit : MonoBehaviour
{
    public GameObject FadeOut;
    public GameObject gameWintext;

    public static int scoreCount;  //new line

    //new lines
    public float timeValue = 90;
    public Text timerText;
    


    // Update is called once per frame
    void Update()
    {
        if (timeValue == 0)
        {
            gameWintext.SetActive(true);
            FadeOut.SetActive(true);
        }

        else if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }

        else
        {
            timeValue = 0;
        }

        DisplayTime(timeValue); 

    }

    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
