using UnityEngine;
using UnityEngine.UI;

public class CameraFollow : MonoBehaviour
{
    public GameObject Player, Cam;
    public Vector3 Offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Cam = Camera.main.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        cameraFollow();
    }

    public void cameraFollow()
    {
        Cam.transform.position = Player.transform.position + Offset;
    }
}
