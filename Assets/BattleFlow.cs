using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleFlow : MonoBehaviour
{
    public GameObject gameOverUI; // Kéo CanvasGameOver vào đây [cite: 1649]
    public GameObject gameWinUI;  // Kéo CanvasGameWin vào đây [cite: 1755]
    public PlayerHealth playerHealth; // Kéo phi thuyền Player vào đây [cite: 1650]
    public GameObject bgMusic;    // Kéo object chứa nhạc nền vào đây [cite: 1651]

    private void Start()
    {
        gameOverUI.SetActive(false);
        gameWinUI.SetActive(false);

        if (playerHealth != null)
            playerHealth.onDead += OnGameOver;
    }

    private void Update()
    {
        if (EnemyHealth.LivingEnemyCount <= 0)
        {
            OnGameWin();
        }
    }

    private void OnGameOver()
    {
        gameOverUI.SetActive(true); // Bật Game Over [cite: 1659]
        if (bgMusic != null) bgMusic.SetActive(false); // Tắt nhạc nền [cite: 1660]
    }

    private void OnGameWin()
    {
        gameWinUI.SetActive(true); // Bật Game Win [cite: 1770]
        if (bgMusic != null) bgMusic.SetActive(false); // Tắt nhạc nền [cite: 1771]
        if (playerHealth != null) playerHealth.gameObject.SetActive(false); // Tạm ẩn Player [cite: 1772]
    }

    public void ReturnToMainMenu()
    {
        // Nhớ reset lại biến đếm địch về 0 trước khi thoát Scene
        EnemyHealth.LivingEnemyCount = 0;
        SceneManager.LoadScene("MainMenu");
    }
}