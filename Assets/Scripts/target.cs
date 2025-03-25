using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour, IDamageable
{
    public float health = 100f;
    public Color damageColor = Color.red;
    public float colorChangeDuration = 0.5f;

    private Renderer targetRenderer;
    private Color originalColor;

    private void Start()
    {
        targetRenderer = GetComponent<Renderer>();
        originalColor = targetRenderer.material.color;
    }
    public void TakeDamage(float damage)
    {
        health -= damage;

        if (health <= 0f)
        {
            Destroy(gameObject);
        }
        StartCoroutine(ChangeColorOnDamage());
    }
    private IEnumerator ChangeColorOnDamage()
    {
        targetRenderer.material.color = damageColor;
        yield return new WaitForSeconds(colorChangeDuration);
        targetRenderer.material.color = originalColor;
    }
}
