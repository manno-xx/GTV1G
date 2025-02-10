using UnityEngine;

/// <summary>
/// A simple bullet to do damage to Health
/// </summary>
public class Bullet : MonoBehaviour
{
    /// <summary>
    /// If the bullet hits anything,
    /// - check if there is a health component on it
    /// - if so: call its DoDamage function 
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Health>(out Health health))
        {
            health.DoDamage(5);
        }
    }
}
