using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightMovement : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public Countdown countdownTimer;

    // Update is called once per frame
    public Light2D light;
    void Update()
    {
        // Set the position of the spotlight to the player's position
        transform.position = player.position;
        float remainingTime = countdownTimer.GetRemainingTime();
        float radius = shrinkSpeed(remainingTime);
        set_radius(radius);
    }

    void set_radius(float radius)
    {
        light.pointLightOuterRadius = radius;
        light.pointLightInnerRadius = radius * 0.9f;
    }
    
    float shrinkSpeed(float remainingTime)
    {
        float shrinkRate = (remainingTime / 300) * 10;
        return shrinkRate;
        
    }
}