using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerScore = 0;
    public int opponentScore = 0;
    Dictionary<string,int> scores = new Dictionary<string,int>();
    
    void Start()
    {
        scores.Add("Player",0);
        scores.Add("Opponent",0);
        Debug.Log("Game has started. These are the scores:");
        Debug.Log(scores);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(GameObject scorer){
        Debug.Log(scorer.name + "has scored!");

        int newScore = scores[scorer.name];
        newScore++;
        scores[scorer.name] = newScore;

        Debug.Log("updated scores: ");
        ListScores();
    }

    void ListScores(){
        foreach (KeyValuePair<string, int> score in scores)
{
        Debug.Log("Player: " + score.Key + " Score: " + score.Value);
}
    }
}
