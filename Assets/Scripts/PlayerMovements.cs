using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    private float speed = 10f;

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(horizontal, vertical, 0f);
        transform.position += movement.normalized * speed * Time.deltaTime;
    }
}
