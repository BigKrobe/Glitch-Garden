using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [Header("Enemy Stats")]
    [SerializeField] float health = 100f;

    [Header("VFX")]
    [SerializeField] GameObject deathFX;
    [SerializeField] float durationOfExplosion;

    public void DealDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            TriggerDeathVFX();
            Destroy(gameObject);
        }
    }

    private void TriggerDeathVFX()
    {
        GameObject deathVFXObject = Instantiate(deathFX, transform.position, transform.rotation);
        Destroy(deathVFXObject, durationOfExplosion);
    }
}
