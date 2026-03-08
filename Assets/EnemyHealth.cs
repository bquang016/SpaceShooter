using UnityEngine;

public class EnemyHealth : Health
{
    public static int LivingEnemyCount;

    private void Awake() => LivingEnemyCount++;

    protected override void Die()
    {
        LivingEnemyCount--; // Khi địch chết, giảm biến đếm [cite: 1721]
        base.Die();
    }
}