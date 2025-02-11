using UnityEngine;

/// <summary>
/// A simple bullet to do damage to a Health system
/// </summary>
public class Bullet : MonoBehaviour
{
    // The items within the square brackets are for the inspector
    // - SerializeField makes the variable appear there
    // - Tooltip makes a tooltip appear as soon when you hover the mouse over the variable
    // - Range shows a slider to set the value within the given bounds
    [SerializeField, Tooltip("how much damage does this bullet do?"), Range(1, 20)]
    private int damageAmount;
    
    /// <summary>
    /// If the bullet hits anything,
    /// - check if there is a Health component on it
    /// - if so: call its DoDamage function 
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Health>(out Health health))
        {
            health.DoDamage(damageAmount);
        }
    }
}
