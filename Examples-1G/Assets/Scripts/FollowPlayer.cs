using UnityEngine;

public enum ViewType
{
    Static,
    LookAt,
    TopDown
}

public class FollowPlayer : MonoBehaviour
{
    private Transform playerTransform;

    [SerializeField] private ViewType viewType;
    [SerializeField] private float cameraHeight;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // look for the player
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        switch (viewType)
        {
            case ViewType.LookAt:
                transform.LookAt(playerTransform.position);
                break;
            case ViewType.TopDown:
                transform.position = playerTransform.position + Vector3.up * cameraHeight;
                transform.LookAt(playerTransform.position);
                break;
            case ViewType.Static:
                break;
        }
        
    }
}
