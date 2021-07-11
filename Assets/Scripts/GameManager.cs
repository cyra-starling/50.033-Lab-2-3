using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Text score;
    private int playerScore;

    public void increaseScore(){
        playerScore += 1;
        score.text = "SCORE: " + playerScore.ToString();
    }

    public void damagePlayer(){
        OnPlayerDeath();
    }

    public  delegate  void gameEvent();
    public static event gameEvent OnPlayerDeath;
}
