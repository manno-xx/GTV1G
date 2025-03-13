using UnityEngine;
using UnityEngine.AI;

public class ClickMoveTarget : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;

    [SerializeField] private GameObject lootDrop;
    
    private void OnMouseDown()
    {
        Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(r, out RaycastHit hitInfo))
        {
            if (hitInfo.transform.name == "Floor")
            {
                Instantiate(lootDrop, hitInfo.point + Vector3.up * 0.5f, Quaternion.identity);
                agent.destination = hitInfo.point;
            }
        }
    }
}
