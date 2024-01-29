using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthController : MonoBehaviour
{
    [SerializeField]
    private float _currentHealth;
    [SerializeField]
    private float _maximumHealth;
    public float remainingHealthPercentage { get { return _currentHealth / _maximumHealth; } }
    public UnityEvent onDied;
    public UnityEvent onDamaged;
    public UnityEvent onHealthChanged;
    public bool isInvincible { get; set; }
    public void TakeDamage(float damageAmount)
    {
        if (_currentHealth == 0)
        {
            return;
        }

        if(isInvincible)
        {
            return;
        }
        _currentHealth -= damageAmount;

        onHealthChanged.Invoke();

        if(_currentHealth < 0)
        {
            _currentHealth = 0;
        }

        if(_currentHealth == 0)
        {
            onDied.Invoke();
        }
        else 
        {
            onDamaged.Invoke();
        }
    }

    public void AddHealth(float amountToAdd)
    {
        if(_currentHealth == _maximumHealth)
        {
            return;
        }
        _currentHealth += amountToAdd;
        onHealthChanged.Invoke();

        if(_currentHealth > _maximumHealth)
        {
            _currentHealth = _maximumHealth;
        }
    }
}
