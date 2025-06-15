using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    public float speed = 10.0f;
    public Rigidbody2D rb;
    Vector2 move;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void OnMove(InputValue value)
    {
        move = value.Get<Vector2>();
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(0, move.y * speed);
    }
}
