using UnityEngine;

public class RocketProjectile : MonoBehaviour
{
    private float speed = 10f;
    // private float lifetime = 5f;
    //private float timer = 3f;
    private Vector3 direction;

    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }

    public void LaunchRocketDirection(Vector3 newDirection, float newSpeed)
    {
        direction = newDirection;
        speed = newSpeed;
    }
}
