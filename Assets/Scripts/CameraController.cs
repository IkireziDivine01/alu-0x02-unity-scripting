using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;   // Drag the Player object here in Inspector
    private Vector3 offset;     // Constant offset between camera & player

    void Start()
    {
        // Store the initial offset between camera and player
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        // Update camera position to follow player with same offset
        transform.position = player.transform.position + offset;
    }
}
