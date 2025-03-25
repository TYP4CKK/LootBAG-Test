using UnityEngine;

public class target : MonoBehaviour, IDamageable
{
    public float health = 100f;

    public bool IsDead => health <= 0;

    public void TakeDamage(float amount)
    {
        health -= amount;
        Debug.Log($"{gameObject.name} has taken {amount} damage. Remaining Health: {health}");

        if (IsDead)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log($"{gameObject.name} has died!");
        Destroy(gameObject);
    }
}
