using System;
using UnityEngine;

/// <summary>
/// An item that is 'droppped' when you click on the floor
/// When the Gameobject with the tag Player (See top of inspector of GameObject named Player) hits it, it is destroyed
/// </summary>
public class PickUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PickUpAndDestroy();
        }
    }

    void PickUpAndDestroy()
    {
        Destroy(gameObject);
    }
}
