using UnityEngine;

public class FinishArea : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float finishzoneDistance = 0.5f;
    [SerializeField] private GameObject finishScreen;

    void Start()
    {
        finishScreen.SetActive(false);
    }

    void Update()
    {
        if (player == null)
            return;

        float distance = Vector3.Distance(transform.position, player.position);

        if (distance <= finishzoneDistance)
        {
            WinScreen();
        }
    }

    void WinScreen()
    {
        finishScreen.SetActive(true);
    }
}