using System;
using UnityEngine;

/// <summary>
/// a simple NPC.
/// Following the player when close, otherwise do nothing
/// </summary>
public class NPCBehavior : MonoBehaviour
{
    // reference to the player game object
    private GameObject thePlayer;

    [SerializeField]private float minDistance = 4;
    [SerializeField]private float speed = 1;
    
    void Start()
    {
        // finds the player gameobject (a reference to it)
        thePlayer = GameObject.Find("Player");
    }

    void Update()
    {
        // check proximity
        float distance = Vector3.Distance(transform.position, thePlayer.transform.position);
        
        // if close then move towards the player
        if (distance < minDistance)
        {
            // move toward the player
            transform.position = Vector3.MoveTowards(
                transform.position, 
                thePlayer.transform.position, 
                speed * Time.deltaTime);
        }
    }

    private void OnDrawGizmos()
    {
        float distance = Vector3.Distance(transform.position, thePlayer.transform.position);
        
        // if close then move towards the player
        if (distance < minDistance)
        {
            Gizmos.DrawLine(transform.position, thePlayer.transform.position);
        }
    }
}
