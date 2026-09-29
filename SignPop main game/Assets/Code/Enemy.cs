using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        if (transform.position.y < -7)
        {
            Destroy(gameObject);
        }
    }
}