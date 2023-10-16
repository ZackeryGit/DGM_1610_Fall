using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int credits;
    public int score;

    public TextMeshProUGUI creditText;
    public TextMeshProUGUI scoreText;


    // Increase
    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScoreText();
        
    }
    public void IncreaseCredits(int amount)
    {
        credits += amount;
        UpdateCreditText();
    }

    
    //Decrease
    public void DecreaseScore(int amount)
    {
        score -= amount;
        UpdateScoreText();
    }
    public void DecreaseCredits(int amount)
    {
        credits -= amount;
        UpdateCreditText();

    }


    //Update
    public void UpdateCreditText()
    {
        creditText.text = credits + " Credits";
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score \n" + score;
    }
}
