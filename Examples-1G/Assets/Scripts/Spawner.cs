using UnityEngine;

public class Spawner : MonoBehaviour
{
    // the npc to instantiate
    [SerializeField] private GameObject original;
    
    void Start()
    {
        // write a loop that executes an x amount of times
        for (int i = 0; i < 10; i++)
        {
            // in the loop, instantiate an NPC
            // the NPC's logic will be in the object itself
            Instantiate(original, 
                new Vector3(
                    Random.Range(-10, 10), 
                    0.5f, 
                    Random.Range(-10, 10)), 
                Quaternion.identity);
        }
    }
}
