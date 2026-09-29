using UnityEngine;

public class DestroyZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy01") ||
            other.CompareTag("Enemy02") ||
            other.CompareTag("Enemy03"))
        {
            Destroy(other.gameObject);
        }
    } 
}