using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float time;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(DecreaseTime());
    }

    // Update is called once per frame
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
