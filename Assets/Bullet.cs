using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed = 5f; // Tốc độ bay [cite: 660, 699]

    void Update()
    {
        // Lấy vị trí hiện tại
        var newPosition = transform.position;
        // Tăng giá trị Y để bay lên
        newPosition.y += Time.deltaTime * flySpeed;
        // Cập nhật lại vị trí
        transform.position = newPosition;
    }
}