//Oyuncunun hasar almasýný saðlar.

using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.UI;

public class DamagePlayer : TrapsAbstract
{
   public override void DecreaseTime(int penalty)
   {
        GameObject.FindObjectOfType<GameManager>().time -= Random.Range(penalty / 2, penalty * 2);
   }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DecreaseTime(penalty);
        }
    }
}
