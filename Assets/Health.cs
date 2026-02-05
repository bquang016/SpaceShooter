using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab; // Prefab nổ
    public int defaultHealthPoint = 3; // Máu mặc định
    private int healthPoint;

    private void Start() => healthPoint = defaultHealthPoint;

    public void TakeDamage(int damage)
    {
        if (healthPoint <= 0) return;
        healthPoint -= damage;
        if (healthPoint <= 0) Die();
    }

    protected virtual void Die()
    {
        // Tạo hiệu ứng nổ nếu có
        if (explosionPrefab != null)
        {
            var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosion, 1f);
        }
        Destroy(gameObject);
    }
}