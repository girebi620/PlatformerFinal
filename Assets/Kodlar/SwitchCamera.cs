//Üst ve arka kamera arasýnda geçiþ yapar.

using UnityEngine;
using UnityEngine.UI;

public class SwitchCamera : MonoBehaviour
{
    public Camera cam1, cam2;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        SwitchCam();
    }

    public void SwitchCam()
    {
        if (Input.GetMouseButton(1))
        {
            cam1.gameObject.SetActive(false);
            cam2.gameObject.SetActive(true);
        }
        else
        {
            cam1.gameObject.SetActive(true);
            cam2.gameObject.SetActive(false);
        }
    }
}
