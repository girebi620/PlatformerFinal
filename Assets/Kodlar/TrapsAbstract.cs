//Zaman azaltmak i�in bir soyut s�n�f

using UnityEngine;
using UnityEngine.UI;

public abstract class TrapsAbstract : MonoBehaviour
{
    public int penalty;
    public abstract void DecreaseTime(int penalty);
}
