//Oyuncunun fare ile sa�a sola bakmas�n� sa�lar.

using UnityEngine;
using UnityEngine.UI;

public class MouseLook : MonoBehaviour
{
    public GameObject Oyuncu;
    public float HorizontalSensitivity;
    
    void Start()
    {
        Oyuncu = GameObject.FindGameObjectWithTag("Player");
    }

    
    void Update()
    {
        LookAround();
    }

    public void LookAround()
    {
        var mouseX = Input.GetAxis("Mouse X");
        Oyuncu.transform.eulerAngles += new Vector3(0, mouseX, 0);
    }
}
