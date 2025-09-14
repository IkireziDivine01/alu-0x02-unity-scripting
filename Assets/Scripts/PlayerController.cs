using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;  // Movement speed (editable in Inspector)

    private Rigidbody rb;

    void Start()
    {
        // Get the Rigidbody component attached to the Player
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Get input from WASD or Arrow keys
        float moveHorizontal = Input.GetAxis("Horizontal"); // A/D or Left/Right
        float moveVertical = Input.GetAxis("Vertical");     // W/S or Up/Down

        // Create a movement vector (no Y movement → stays on X/Z plane)
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Apply force to Rigidbody for smooth movement
        rb.AddForce(movement * speed);
    }
}
