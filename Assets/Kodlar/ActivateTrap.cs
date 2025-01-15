//Tuzak oyuncu ile i� i�e ge�ti�inde tuza�� aktifle�tirir.

using UnityEngine;

public class ActivateTrap : MonoBehaviour
{
    public Animator SpikeAnimator;
    public AudioSource audioSource; 
    private bool hasTriggered = false; 

    private void OnTriggerEnter(Collider other)
    {
        // E�er oyuncu tuza�a dokunduysa ve tuzak daha �nce tetiklenmediyse
        if (other.CompareTag("Player") && !hasTriggered)
        {
            if (SpikeAnimator != null)
            {
                AnimatorManager.SetAllAnimatorBools(SpikeAnimator, "IsTriggered");
            }

            if (audioSource != null && !audioSource.isPlaying) 
            {
                audioSource.Play(); 
            }

            hasTriggered = true; 
        }
    }
}
