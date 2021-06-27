using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
   public bool isGameOver = false;
     public static int score = 0;
   // int score = 0;
   public Text Score;
    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
     
    }
    public void IncrementScore()
    {
        if (isGameOver==false)
        {
            // score.text = "Score:" + Score;
            score++;
            Score.text = "Score:  " + score;
            Debug.Log(score);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
     //Score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
