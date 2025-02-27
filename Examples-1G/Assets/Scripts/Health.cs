using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// A basic health system (we'll expand on this soon)
/// Should be possible to apply to anything that is damageable
/// </summary>
public class Health : MonoBehaviour
{
    [SerializeField] private float health;
    [SerializeField] private float maxHealth = 100;

    public UnityEvent<float> healthUpdate;
    
    void Start()
    {
        health = maxHealth;
    }

    /// <summary>
    /// Just for testing: When you click the mouse, do damage
    /// This will be removed later...
    /// </summary>
    private void OnMouseDown()
    {
        DoDamage(10);
    }

    public void Heal(int amount)
    {
        health += amount;
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }
    
    /// <summary>
    /// Does damage to this health system
    /// Todo: check for 'death' and notify possible interested parts of the game of the update
    /// </summary>
    /// <param name="damage">The amount of damage to do</param>
    public void DoDamage(int damage)
    {
        health -= damage;
        if (health < 0)
        {
            health = 0;
        }
        // whenever health changes, update/tell anyone interested
        healthUpdate.Invoke(health/maxHealth);
    }
}
