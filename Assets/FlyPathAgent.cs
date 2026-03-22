using UnityEngine;

public class FlyPathAgent : MonoBehaviour
{
    public FlyPath flyPath;
    public float flySpeed;
    private int nextIndex = 1;

    // Khởi đầu, ép kẻ địch dịch chuyển ngay lập tức đến điểm số 0 của đường bay
    //void Start() => transform.position = flyPath[0];

    void Update()
    {
        if (flyPath == null) return;
        
        // NẾU BAY HẾT ĐƯỜNG: Tiêu diệt object để dọn rác bộ nhớ
        if (nextIndex >= flyPath.waypoints.Length)
        {
            Destroy(gameObject);
            return;
        }

        // NẾU CHƯA TỚI ĐIỂM TIẾP THEO: Tiếp tục bay và xoay đầu
         if (transform.position != flyPath[nextIndex])
        {
            FlyToNextWaypoint();
            LookAt(flyPath[nextIndex]);
        }
        else
        {
            // Tới nơi thì tăng chỉ mục để nhắm tới điểm tiếp theo
            nextIndex++;
        }
    }

    private void FlyToNextWaypoint() =>
        transform.position = Vector3.MoveTowards(transform.position, flyPath[nextIndex], flySpeed* Time.deltaTime);

    private void LookAt(Vector2 destination)
    {
       Vector2 position = transform.position;
       var lookDirection = destination - position;

    if (lookDirection.magnitude< 0.01f) return;

    // Tính toán góc xoay dựa trên trục hướng xuống (Vector3.down)
    var angle = Vector2.SignedAngle(Vector3.down, lookDirection);
    transform.rotation = Quaternion.Euler(0, 0, angle); 
}
}