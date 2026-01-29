using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public GameObject explosionPrefab; // Prefab hiệu ứng nổ

    // Hàm này tự động chạy khi có vật thể (Trigger) bay vào
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Die();
    }

    private void Die()
    {
        // Tạo hiệu ứng nổ (sẽ làm ở bước 5)
        if (explosionPrefab != null)
        {
            var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosion, 1f); // Xóa hiệu ứng nổ sau 1 giây
        }

        // Xóa máy bay địch
        Destroy(gameObject);
    }
}