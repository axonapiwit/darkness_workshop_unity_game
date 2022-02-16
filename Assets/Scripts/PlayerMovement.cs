using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;
    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        // Player Flip
        if (horizontalInput > 0.05f)
            transform.localScale = new Vector3(5, 5, 5);
        else if (horizontalInput < -0.05f)
            transform.localScale = new Vector3(-5, 5, 5);

        // Player jump
        if (Input.GetKey(KeyCode.W))
            body.velocity = new Vector2(body.velocity.x, speed);
    }
}
