using UnityEngine;

public class CamController : MonoBehaviour
{
    private GameObject player;
    public Vector3 offset;

    void Start()
    {
        player = GameObject.Find("Player");
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
