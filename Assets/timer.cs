using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class timer : MonoBehaviour {
    float timeLeft;
    float time;
    GameController ethanGO;
    GameController kingGO;
    float scoreEthan;
    float scoreKing;

    void Awake()
    {
        //text = GetComponent<Text>();
        //text.text = "Time Left:" + Mathf.Round(timeLeft);
        time = 100;
        timeLeft = time;
        ethanGO = GameObject.Find("Ethan").GetComponent<GameController>();
        kingGO = GameObject.Find("SpartanKing").GetComponent<GameController>();
        
    }

    void Update()
    {
        
        if (timeLeft < 0)
        {
            print("Time Over");
            //text.text = "Time Over !!!";
            scoreEthan = ethanGO.GetScore();
            scoreKing = kingGO.GetScore();

            if (scoreEthan > scoreKing)
            {
                ethanGO.SetResult(true);
                kingGO.SetResult(false);
            }
            if (scoreEthan < scoreKing)
            {
                ethanGO.SetResult(false);
                kingGO.SetResult(true);
            }

            if (scoreEthan == scoreKing)
            {
                ethanGO.SetResultDraw();
                kingGO.SetResultDraw();
            }


            //Application.LoadLevel("gameOver");
        }
        else
        {
            timeLeft -= Time.deltaTime;
            //text.text = "Time Left:" + Mathf.Round(timeLeft);
            //print(timeLeft);
        }
    }
}
