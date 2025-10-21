using UnityEngine;

public class ColliderReaction : MonoBehaviour
{
    [SerializeField] private float detectionRange;
    [SerializeField] private LayerMask targetLayer;

    private void OnCollisionEnter(Collision collision)
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, detectionRange, targetLayer);

        foreach (Collider hitCollider in hitColliders)
        {
            Debug.Log(hitCollider.name);
        }

    }

   
}
