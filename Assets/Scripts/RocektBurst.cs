    using UnityEngine;

public class RocektBurst : MonoBehaviour
{
    [SerializeField] private float RocketSpawnrate = 3f;
    [SerializeField] private float speed = 10f;
    [SerializeField] private GameObject rocketPrefab;
    [SerializeField] private int rocketCount = 5;
    public float RocketLifetime = 2f;
    public float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= RocketSpawnrate)
        {
            timer = 0f;
            burst();
        }
    }

    public void burst()
    {
        float angleStep = 360f / rocketCount;
        float angle = 0f;

        for (int i = 0; i < rocketCount; i++)
        {
            float projectileDirXPosition = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180);
            float projectileDirYposition = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180);

            Vector2 direction = new Vector2(projectileDirXPosition, projectileDirYposition) - new Vector2(transform.position.x, transform.position.y);

            GameObject rocket = Instantiate(rocketPrefab, transform.position, Quaternion.identity);
            rocket.GetComponent<RocketProjectile>().LaunchRocketDirection(direction, speed);
            Destroy(rocket, RocketLifetime);

            angle += angleStep;
        }
    }

    public void AddRocket()
    {
        if (rocketCount < 8)
        {
            rocketCount++;
        }
    }
}
