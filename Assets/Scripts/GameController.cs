using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public TextMesh scoreText;
    private int score;
    
    // Use this for initialization
    void Start () {
        score = 0;
        UpdateScore();
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "+ " + score;
    }

    public void SetResult(bool winner)
    {
        if (winner)
        {
            scoreText.text = "Heeero !!!";
        }
        else
        {
            scoreText.text = "Zeeero !!!";
        }
    }

    public void SetResultDraw()
    { 
        scoreText.text = "Draw !!!";
    }

    public int GetScore()
    {
        return score;
    }

}
