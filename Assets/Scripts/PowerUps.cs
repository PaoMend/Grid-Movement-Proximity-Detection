using UnityEngine;

public class PowerUps : MonoBehaviour
{
    [SerializeField] private Transform player;
    private float PowerUpDistance = 0.5f;
    [SerializeField] private RocektBurst rocketBurst;

    void Update()
    {
        if (player == null)
            return;

        float distance = Vector3.Distance(transform.position,player.position);

        if (distance <= PowerUpDistance)
        {
            rocketBurst.AddRocket();
            Destroy(gameObject);
        }
    }
}