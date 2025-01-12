using UnityEngine;
using UnityEngine.UI;

public class ActivateTrap : MonoBehaviour
{
    public Animator SpikeAnimator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(SpikeAnimator != null)
            AnimatorManager.SetAllAnimatorBools(SpikeAnimator, "IsTriggered");
        }
    }
}
