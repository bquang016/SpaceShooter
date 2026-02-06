using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public EnemyHealth health;
    public int damage = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var playerHealth = collision.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damage);
            if (health != null)
            {
                health.TakeDamage(1000);
            }
        }
    }
}