using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    Text score;
    static int playerScoreUI;
    static int opponentScoreUI;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponentInChildren<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Player: " + playerScoreUI;
        
    }

   public static void UpdateScoresUI(int player, int opponent){
        playerScoreUI = player;
        opponentScoreUI = opponent;
    }
}
