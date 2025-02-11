using UnityEngine;

public class CircleColliderGizmo : MonoBehaviour 
{
    [SerializeField] private CircleCollider2D _collider;

    private void OnDrawGizmos ()
    {
        if(_collider == null) return;

        Gizmos.color = Color.blue;
        Vector3 colliderCenter = new Vector3(_collider.offset.x, _collider.offset.y, 0);
        Gizmos.DrawWireSphere(transform.position + colliderCenter, _collider.radius);
    }
}