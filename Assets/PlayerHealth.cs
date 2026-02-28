using UnityEngine;

public class PlayerHealth : Health
{
    public GameObject gameOverCanvas;

    protected override void Die()
    {
        base.Die();
        Debug.Log("Player died");
        if (gameOverCanvas != null)
        {
            gameOverCanvas.SetActive(true);
        }
    }
}