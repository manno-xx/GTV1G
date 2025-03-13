using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

/// <summary>
/// Defines all the items that can be in the Inventory
/// </summary>
public enum ItemType{
    Potion,
    Health,
    Gem
}

/// <summary>
/// A basic inventory.
/// Has A dictionary and when something is added, displays the contents of the inventory in the inspector
/// </summary>
public class Inventory : MonoBehaviour
{
    private Dictionary<ItemType, int> inventoryItems;
    
    void Start()
    {
        inventoryItems = new Dictionary<ItemType, int>();
    }
    
    /// <summary>
    /// Add a type to the inventory
    /// </summary>
    /// <param name="item">The type of item to add</param>
    /// <param name="count">The amount to add</param>
    public void AddToInventory(ItemType item, int count)
    {
        if (inventoryItems.ContainsKey(item))
        {
            inventoryItems[item] += count;
        }
        else
        {
            inventoryItems.Add(item, count);
        }

        DisplayInventory();
    }

    /// <summary>
    /// Quick and Dirty way to show the contents of the inventory
    /// (should be dealt with by some UI)
    /// </summary>
    private void DisplayInventory()
    {
        foreach (var item in inventoryItems)
        {
            // update the ui
            Debug.Log($"{item.Key}, {item.Value}");
        }
    }
}
