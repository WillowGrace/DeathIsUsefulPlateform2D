using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepScore : MonoBehaviour
{
    public float score;
    float startTime = 0;
    Text Clock;
    //timer

    //score = limitleft X 25
    // Start is called before the first frame update
    void Start()
    {
        Clock = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //time
        float timePassed = startTime + Time.time;

        //show time limit
        Clock.text = FormatTime(timePassed);
        //stop time (from player)
        
        //turn time to points
        score = (startTime - timePassed) * 25;
        //save points to display

    }
     string FormatTime(float time)
    {
        float totalTime = time;
        int minutes = (int)(totalTime / 60) % 60;
        int seconds = (int)totalTime % 60;

        string answer = minutes.ToString("00") + "." + seconds.ToString("00");
        return answer;

    }

    void ScoreBourd()
    {
        //saved points

        //sort points

        //display points

    }
}
