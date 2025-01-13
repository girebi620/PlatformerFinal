using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingCollision : MonoBehaviour
{
    
    public string playerTag = "Player"; 

    private void OnTriggerEnter(Collider other)
    {
        // Etkile�im kontrol�
        if (other.CompareTag(playerTag))
        {
            // Ana men� sahnesine ge�
            SceneManager.LoadScene(0);
        }
    }
}
