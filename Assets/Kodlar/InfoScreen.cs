//Oyun baþýnda oyuncuya bilgi veren bir panel açar, bu panel bir süre sonra kaybolur.

using UnityEngine;
using UnityEngine.UI;

public class InfoScreen : MonoBehaviour
{
    public GameObject InfoPanel;
    public float Counter;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Counter -= Time.fixedDeltaTime;
        if (Counter < 0)
        {
            InfoPanel.SetActive(false);
        }
    }

}
