using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingCollision : MonoBehaviour
{
    
    public string playerTag = "Player"; 

    private void OnTriggerEnter(Collider other)
    {
        // Etkileþim kontrolü
        if (other.CompareTag(playerTag))
        {
            // Ana menü sahnesine geç
            SceneManager.LoadScene(0);
        }
    }
}
