using UnityEngine;

public class Bouncer : MonoBehaviour
{
    [SerializeField] private float bouncePower;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(rb.velocity.x, bouncePower);
        }
    }
}
