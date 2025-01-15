//Karakteri hareket ettirir.

using UnityEngine;

public class CharacterMove : MonoBehaviour, IMove
{
    public float Speed, SprintSpeed;
    private Rigidbody rb;
    public Animator PlayerAnimator;
    public AudioSource walkAudioSource; 
    public AudioClip walkSound; 

    private bool isWalking = false; 

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        if (walkAudioSource != null && walkSound != null)
        {
            walkAudioSource.clip = walkSound; // Ses kaynaðýný ses dosyasý ile eþleþtirir
        }
    }

    void Update()
    {
        Move(Speed);
    }

    public void Move(float Speed)
    {
        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");

        Vector3 MoveDir = transform.right * x + transform.forward * z;

        // Yavaþ yürüyüþ veya sprint için
        if (Input.GetKey(KeyCode.LeftShift))
        {
            AnimatorManager.SetAllAnimatorBools(PlayerAnimator, "koþma");
            transform.position += MoveDir * SprintSpeed * Time.deltaTime;
        }
        else
        {
            transform.position += MoveDir * Speed * Time.deltaTime;
            AnimatorManager.SetAllAnimatorBools(PlayerAnimator, "yürüme");
        }

        // Yürüyüþ kontrolü
        if (x != 0 || z != 0) // Eðer karakter hareket ediyorsa
        {
            if (!isWalking && walkAudioSource != null && !walkAudioSource.isPlaying)
            {
                walkAudioSource.Play(); // Yürüyüþ sesi çalar
            }
            isWalking = true;
        }
        else
        {
            if (isWalking && walkAudioSource != null && walkAudioSource.isPlaying)
            {
                walkAudioSource.Stop(); // Yürüyüþ sesini durdurur
            }
            isWalking = false;
            AnimatorManager.SetAllAnimatorBools(PlayerAnimator, "idle");
        }
    }
}
