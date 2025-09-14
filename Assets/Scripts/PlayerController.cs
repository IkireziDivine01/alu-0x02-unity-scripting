using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;  // Movement speed (editable in Inspector)
    private Rigidbody rb;

    // New score variable
    private int score = 0; // Initial score

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

    // Detect collision with coins
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            score++; // Increment score
            Debug.Log("Score: " + score); // Print score to console

            // Disable or destroy the coin
            other.gameObject.SetActive(false);
            // OR: Destroy(other.gameObject);
        }
    }
}
