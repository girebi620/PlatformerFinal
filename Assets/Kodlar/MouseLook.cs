//Oyuncunun fare ile sa�a sola bakmas�n� sa�lar.

using UnityEngine;
using UnityEngine.UI;

public class MouseLook : MonoBehaviour
{
    public GameObject Oyuncu;
    public float HorizontalSensitivity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Oyuncu = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
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
