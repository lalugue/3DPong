using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StateManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerScore = 0;
    public int opponentScore = 0;
    static Dictionary<string,int> scores = new Dictionary<string,int>();
    public Text scoreAnnouncer;
    
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

    public IEnumerator UpdateScore(GameObject scorer){
        scoreAnnouncer.gameObject.SetActive(true);
        scoreAnnouncer.text = scorer.name + " has scored!";
        Debug.Log(scorer.name + " has scored!");

        
        int newScore = scores[scorer.name];
        newScore++;
        scores[scorer.name] = newScore;
        
        
        
        yield return new WaitForSecondsRealtime(3);

        Debug.Log("updated scores: ");
        //List and Display Scores helper function; hide announcer text
        ListScores();   

        scoreAnnouncer.gameObject.SetActive(false);

               
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("GameScene");
               
        
    }

    void ListScores(){
        foreach (KeyValuePair<string, int> score in scores)
        {
            Debug.Log("Player: " + score.Key + " Score: " + score.Value);

        }

        //Update the scores in the UI
        ScoreUI.UpdateScoresUI(scores["Player"], scores["Opponent"]);
    }

    
}
