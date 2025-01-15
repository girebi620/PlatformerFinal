//Bu script oyuncu var�� yerine gelince ana men�ye d�nd�r�r.
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingCollision : MonoBehaviour
{
    
    public string playerTag = "Player"; 

    private void OnTriggerEnter(Collider other)
    {
        // Etkile�im kontrol�n� yapar
        if (other.CompareTag(playerTag))
        {
            // Ana men� sahnesine ge�er
            SceneManager.LoadScene(0);
        }
    }
}
