using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StateManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerScore = 0;
    public int opponentScore = 0;
    static Dictionary<string,int> scores = new Dictionary<string,int>();
    
    
    void Start()
    {
        if(scores.Count == 0){
        scores.Add("Player",0);
        scores.Add("Opponent",0);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake(){
        //DontDestroyOnLoad(scores);
    }

    public void UpdateScore(GameObject scorer){
        Debug.Log(scorer.name + "has scored!");

        int newScore = scores[scorer.name];
        newScore++;
        scores[scorer.name] = newScore;

        Debug.Log("updated scores: ");
        ListScores();
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("GameScene");
    }

    void ListScores(){
        foreach (KeyValuePair<string, int> score in scores)
        {
            Debug.Log("Player: " + score.Key + " Score: " + score.Value);
        }
    }
}
