using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text myText;

    public int timeLeft = 180;
    private float gameTime;

    void Update()
    {
        myText.text = "Time left " + timeLeft + " sec.";
        gameTime += 1 * Time.deltaTime;
        if (gameTime >= 1)
        {
            timeLeft -= 1;
            gameTime = 0;
        }
        if (timeLeft < 30)
        {
            myText.color = Color.red;
        }
        if (timeLeft < 100)
        {
            myText.fontSize = 20;
        }
    }
}