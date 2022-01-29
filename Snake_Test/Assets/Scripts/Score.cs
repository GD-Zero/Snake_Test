using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public int score;
    public Text scoreText;

    void Start()
    {
        score = 0;    
    }

    void Update()
    {
        scoreText.text = score.ToString();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Eat")
        {
            score++;
        }

        if (collision.tag == "Coin")
        {
            score += 5;
        }
    }


}
