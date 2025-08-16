using UnityEngine;

public class Followplayer : MonoBehaviour
{
    private Vector3 offset = new Vector3(0, 6, -10);
    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        // offset the camera behind the player
        transform.position = player.transform.position + offset;
    }
}
