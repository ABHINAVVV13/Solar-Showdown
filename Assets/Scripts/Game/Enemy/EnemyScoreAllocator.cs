using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScoreAllocator : MonoBehaviour
{
    public delegate void EnemyDestroyed();
    public static event EnemyDestroyed OnEnemyDestroyed;
    public static int score = 0; // The player's score

    public void IncreaseScore(int increaseAmount)
    {
        // Increase the score by the specified amount
        score += increaseAmount;
    }

    void OnDestroy()
    {
        // Increase the score by 1 when the enemy is destroyed
        IncreaseScore(1);
        OnEnemyDestroyed?.Invoke();
    }
}
