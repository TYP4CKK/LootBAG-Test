using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float damageAmount = 25f;
    private IDamageable damageableTarget;

    void OnCollisionEnter(Collision collision)
    {
        damageableTarget = collision.gameObject.GetComponent<IDamageable>();

        if (damageableTarget != null)
        {
            Debug.Log("Hasar verebileceğimiz nesneye çarptık: " + collision.gameObject.name);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.GetComponent<IDamageable>() == damageableTarget)
        {
            damageableTarget = null;
        }
    }

    void Update()
    {
        if (damageableTarget != null && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E tuşuna basıldı, hasar veriliyor...");
            damageableTarget.TakeDamage(damageAmount);
            Debug.Log("Hasar verildi!");
        }
    }
}
