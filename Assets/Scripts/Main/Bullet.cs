using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float shootSpeed;
    [SerializeField] private ParticleSystem ps;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(DeathTimer());
    }

    void Update()
    {
        rb.velocity = transform.right * shootSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameMaster.Instance.KillPlayer();
        }
        die();
    }

    private IEnumerator DeathTimer()
    {
        yield return new WaitForSeconds(1f);
        die();
    }

    void die()
    {
        Destroy(gameObject);
    }
}