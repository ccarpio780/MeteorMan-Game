using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{

    public float currentTime = 0f;
    public float startingTime = 35f;

    [SerializeField] Text countdownText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = ((int)(currentTime)).ToString();

        if (currentTime <= 0)
        {
            currentTime = 0f;
            SceneManager.LoadScene(1);
        }
    }
}
