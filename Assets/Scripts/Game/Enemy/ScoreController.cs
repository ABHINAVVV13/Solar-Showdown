using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System; // Use System, not System.Random

public class ScoreController : MonoBehaviour
{
    public float score = 0; // The player's score

    public void AddScore(int increaseAmount)
    {
        // Increase the score by the specified amount
        score += increaseAmount;

        System.Random random = new System.Random();
        int decreaseAmount = random.Next(0, 2); // Call Next on the random instance
        score -= decreaseAmount;
    }
    
}