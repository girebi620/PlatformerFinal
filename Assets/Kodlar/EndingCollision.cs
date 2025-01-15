//Bu script oyuncu varýþ yerine gelince ana menüye döndürür.
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingCollision : MonoBehaviour
{
    
    public string playerTag = "Player"; 

    private void OnTriggerEnter(Collider other)
    {
        // Etkileþim kontrolünü yapar
        if (other.CompareTag(playerTag))
        {
            // Ana menü sahnesine geçer
            SceneManager.LoadScene(0);
        }
    }
}
