using UnityEngine;

/// <summary>
/// A basic health system (we'll expand on this soon)
/// Should be possible to apply to anything that is damageable
/// </summary>
public class Health : MonoBehaviour
{
    [SerializeField] private int health;
    [SerializeField] private int maxHealth = 100;
    
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
        health -= 10;
    }

    /// <summary>
    /// Does damage to this health system
    /// Todo: check for 'death' and notify possible interested parts of the game of the update
    /// </summary>
    /// <param name="damage">The amount of damage to do</param>
    public void DoDamage(int damage)
    {
        health -= damage;
    }
}
