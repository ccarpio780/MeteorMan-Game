using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public int coinCount = 0;
    Text coinScore;
    

    
    void Start()
    {
        coinScore = GameObject.Find("ScoreText").GetComponent<Text>();
        
    }

    void Update()
    {
        coinScore.text = "Score: " + coinCount.ToString();
        
    }
    
}
