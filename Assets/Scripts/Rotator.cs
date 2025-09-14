using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 45f; // degrees per second

    void Update()
    {
        // Rotate the coin along the X-axis over time
        transform.Rotate(rotationSpeed * Time.deltaTime, 0f, 0f);
    }
}
