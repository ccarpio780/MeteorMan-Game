using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coin : MonoBehaviour
{
    public CoinCounter coinCounter;
    public CountdownTimer theTimer;
    
    AudioSource coinSound;
    // Start is called before the first frame update
    void Start()
    {
        coinSound = GetComponent<AudioSource>();
        coinCounter = GameObject.Find("CoinCounter").GetComponent<CoinCounter>();
        theTimer = GameObject.Find("CountdownTimer").GetComponent<CountdownTimer>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            coinSound.Play();
            coinCounter.coinCount++;
            theTimer.currentTime += 100 * Time.deltaTime;
           
            
            Debug.Log("Collision with player detected. CoinCount: " + coinCounter.coinCount);
          
        }
    }

}
