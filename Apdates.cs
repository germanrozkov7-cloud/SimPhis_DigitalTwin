using UnityEngine;

public class Apdates : MonoBehaviour
{
    public float jumpForce = 10f;
    public float moveSpeed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Прыжок на Пробел
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        // Движение: работает и на СТРЕЛКИ, и на A/D (это стандарт Unity)
        float moveInput = Input.GetAxis("Horizontal");

        // Для Unity 6 используем linearVelocity, для старых версий - velocity
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
    }
}