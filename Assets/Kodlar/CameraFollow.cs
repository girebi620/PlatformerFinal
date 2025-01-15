//Üst kamerayý karaktere takip ettirir.

using UnityEngine;
using UnityEngine.UI;

public class CameraFollow : MonoBehaviour
{
    public GameObject Player, Cam;
    public Vector3 Offset;
    
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Cam = Camera.main.gameObject;
    }

    
    void Update()
    {
        cameraFollow();
    }

    public void cameraFollow()
    {
        Cam.transform.position = Player.transform.position + Offset;
    }
}
