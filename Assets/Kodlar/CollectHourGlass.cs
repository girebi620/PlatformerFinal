//Kum saati toplandýðýnda zamaný arttýrýr.

using UnityEngine;
using UnityEngine.UI;

public class CollectHourGlass : MonoBehaviour
{
    public int Prize;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("kum saati"))
        {
            GameObject.FindObjectOfType<GameManager>().time += Prize;
            Destroy(other.gameObject);
        }
    }
}
