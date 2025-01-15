//Oyun baþýnda oyuncuya bilgi veren bir panel açar, bu panel bir süre sonra kaybolur.

using UnityEngine;
using UnityEngine.UI;

public class InfoScreen : MonoBehaviour
{
    public GameObject InfoPanel;
    public float Counter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Counter -= Time.fixedDeltaTime;
        if (Counter < 0)
        {
            InfoPanel.SetActive(false);
        }
    }

}
