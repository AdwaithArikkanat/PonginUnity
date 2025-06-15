using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 10.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        float x = Random.value < 0.5f ? 1.0f : -1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);
        rb.AddForce(new Vector2(x, y) * speed);
    }
    public void resetPos()
    {
        rb.position = Vector3.zero;
        rb.linearVelocity = Vector3.zero;
        Start();
    }
}
