using UnityEngine;

public class Plant : MonoBehaviour
{
    [SerializeField] private float plantingRadius;
    [SerializeField] private LayerMask plantLayer;

    void Update()
    {
        Collider2D overlappingCollider = Physics2D.OverlapCircle(transform.position, plantingRadius, plantLayer);

        if (overlappingCollider != null && Input.GetKeyDown(KeyCode.E) && !overlappingCollider.GetComponent<Animator>().GetBool("Grown"))
        {
            overlappingCollider.GetComponent<Animator>().SetBool("Grown", true);
            GameMaster.Instance.plantsPlanted++;
            AudioManager.instance.Play("Plant");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, plantingRadius);
    }
}

