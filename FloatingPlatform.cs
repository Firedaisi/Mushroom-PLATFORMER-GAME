using UnityEngine;

public class FloatingPlatform : MonoBehaviour
{
    public Transform pointA;   // Start point
    public Transform pointB;   // End point
    public float speed = 0.5f;   // Movement speed

    private Rigidbody2D rb;
    private Transform target;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (rb == null)
        {
            Debug.LogError("Rigidbody2D component not found on platform!");
        }

        target = pointB;  // Start moving towards pointB
    }

    void FixedUpdate()
    {
        if (rb == null || pointA == null || pointB == null) return; // safety check

        // Calculate next position towards target
        Vector2 newPos = Vector2.MoveTowards(rb.position, (Vector2)target.position, speed * Time.fixedDeltaTime);

        // Move platform smoothly using Rigidbody2D
        rb.MovePosition(newPos);

        // Switch target when close enough
        if (Vector2.Distance(newPos, (Vector2)target.position) < 0.1f)
        {
            target = (target == pointA) ? pointB : pointA;
        }
    }
}

