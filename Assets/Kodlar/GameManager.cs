//Zamaný azaltýr.

using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float time;
    
    void Start()
    {
        StartCoroutine(DecreaseTime());
    }

    
    void Update()
    {
    }

    IEnumerator DecreaseTime()
    {
        while (true)
        {
            time--;
            yield return new WaitForSeconds(1);
        }
    }
}
