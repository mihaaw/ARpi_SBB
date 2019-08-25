using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public float Timer;
    public bool isPressed = false;
    public Text txt;
    private int nextUpdate = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
            //if (Time.time >= nextTime)
            //    {

            //    Timer -= Time.deltaTime;
            //    txt.text = "Time left:" + Mathf.RoundToInt(Timer);

            //    nextTime += interval;

            //    if (Timer <= 0.0f)
            //    {
            //        timerEnded();
            //    }
            //}

            // If the next update is reached
            if (Time.time >= nextUpdate)
            {

                // Change the next update (current second+1)
                nextUpdate = Mathf.FloorToInt(Time.time) + 1;
                // Call your fonction
                UpdateEverySecond();
            }
    }

    // Update is called once per second
    void UpdateEverySecond()
    {
        Debug.Log("In UpdateSeconds");
        if (isPressed == true)
        {

            Timer -= 1;
            txt.text = "Time left:" + Mathf.RoundToInt(Timer) +  " sec";

            if (Timer <= 0.0f)
            {
                timerEnded();


            }
        }
    }

 
    public void onBusClick()
    {
      isPressed = true;
        Timer = 30.0f;

    }

    public void onTrainClick()
    {
        isPressed = true;
        Timer = 60.0f;
    }

    public void onTramClick()
    {
        isPressed = true;
        Timer = 30.0f;

    }

    void timerEnded()
    {
        txt.text = "You missed it!";
    }

}


