using UnityEngine;
using UnityEngine.SceneManagement;

public class RestrictedAreaZone : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float warningDistance = 3f;
    [SerializeField] private float restartDistance = 1f;
    private SpriteRenderer spriterenderer;
    private Vector3 originalposition;

    void Start()
    {
        originalposition = transform.position;
        spriterenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance < restartDistance)
        {
            restart();
        }
        else if (distance < warningDistance)
        {
            warning();
        }
        else
        {
            normal();
        }
    }

    void warning()
    {
        spriterenderer.color = Color.red;
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void normal()
    {
        spriterenderer.color = Color.black;
    }
}