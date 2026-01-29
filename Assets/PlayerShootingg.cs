using UnityEngine;

public class PlayerShootingg : MonoBehaviour
{
    public GameObject bulletPrefabs;
    public float shootingInterval;
    public Vector3 bulletOffset; // Biến mới thêm vào
    private float lastBulletTime;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Time.time - lastBulletTime > shootingInterval)
            {
                ShootBullet();
                lastBulletTime = Time.time;
            }
        }
    }

    void ShootBullet()
    {
        // Cộng thêm bulletOffset vào vị trí hiện tại
        Instantiate(bulletPrefabs, transform.position + bulletOffset, transform.rotation);
    }
}