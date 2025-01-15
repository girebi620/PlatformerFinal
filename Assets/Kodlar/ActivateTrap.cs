//Tuzak oyuncu ile iç içe geçtiðinde tuzaðý aktifleþtirir.

using UnityEngine;

public class ActivateTrap : MonoBehaviour
{
    public Animator SpikeAnimator;
    public AudioSource audioSource; 
    private bool hasTriggered = false; 

    private void OnTriggerEnter(Collider other)
    {
        // Eðer oyuncu tuzaða dokunduysa ve tuzak daha önce tetiklenmediyse
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
