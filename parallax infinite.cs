using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float gameSpeed = 5f;
    public float parallaxFactor = 0.5f;

    public float backgroundWidth = 20f;

    void Update()
    {
        float speed = gameSpeed * parallaxFactor;

        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x <= -backgroundWidth)
        {
            transform.position += Vector3.right * backgroundWidth * 2f;
        }
    }
}