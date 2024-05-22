using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f; // Speed of the player movement

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
    }

    void FixedUpdate()
    {
        // Move the player
        rb.MovePosition(rb.position + PlayerInput.Instance.InputVector * moveSpeed * Time.fixedDeltaTime);
    }
}