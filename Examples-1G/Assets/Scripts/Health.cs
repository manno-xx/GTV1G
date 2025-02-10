using UnityEngine;

/// <summary>
/// A basic health system
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
    /// Just for testing: WHen you click the mouse, do damage
    /// </summary>
    private void OnMouseDown()
    {
        health -= 10;
    }

    /// <summary>
    /// does damage to this health system
    /// </summary>
    /// <param name="damage">The amount of damage to do</param>
    public void DoDamage(int damage)
    {
        health -= damage;
    }
}
