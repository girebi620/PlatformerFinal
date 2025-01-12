using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ShowTime : MonoBehaviour
{
    public GameManager gameManager;
    public Slider slider;
    public Text text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slider.maxValue = gameManager.time;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = gameManager.time;
        text.text = slider.value.ToString(string.Format("0.00"));
    }

    IEnumerator DecreaseTime()
    {
        gameManager.time--;
        yield return new WaitForSeconds(1);
    }
}
