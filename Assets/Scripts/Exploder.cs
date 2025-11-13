using UnityEngine;
using System.Collections.Generic;

public class Exploder : MonoBehaviour
{
    [SerializeField] private float explosionForce = 5f;
    [SerializeField] private float explosionRadius = 2f;

    public void Explode(List<Rigidbody> rigidbodies)
    {
        foreach (var rb in rigidbodies)
        {
            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, rb.position, explosionRadius);
            }
        }
    }
}
