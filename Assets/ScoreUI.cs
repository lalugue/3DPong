using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    Text score;
    static int playerScoreUI = 0;
    static int opponentScoreUI = 0;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponentInChildren<Text>();
        score.text = "Player: " + playerScoreUI + "\nOpponent: " + opponentScoreUI;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Player: " + playerScoreUI + "\nOpponent: " + opponentScoreUI;
        
    }

   public static void UpdateScoresUI(int player, int opponent){
        playerScoreUI = player;
        opponentScoreUI = opponent;
    }
}
