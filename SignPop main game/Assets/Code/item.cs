using UnityEngine;

public class item : MonoBehaviour
{
    public float speed = 1.5f;

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        Destroy(gameObject, 0.75f);
    }
}