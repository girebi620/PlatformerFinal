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
            walkAudioSource.clip = walkSound; // Ses kayna��n� ses dosyas� ile e�le�tirir
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

        // Yava� y�r�y�� veya sprint i�in
        if (Input.GetKey(KeyCode.LeftShift))
        {
            AnimatorManager.SetAllAnimatorBools(PlayerAnimator, "ko�ma");
            transform.position += MoveDir * SprintSpeed * Time.deltaTime;
        }
        else
        {
            transform.position += MoveDir * Speed * Time.deltaTime;
            AnimatorManager.SetAllAnimatorBools(PlayerAnimator, "y�r�me");
        }

        // Y�r�y�� kontrol�
        if (x != 0 || z != 0) // E�er karakter hareket ediyorsa
        {
            if (!isWalking && walkAudioSource != null && !walkAudioSource.isPlaying)
            {
                walkAudioSource.Play(); // Y�r�y�� sesi �alar
            }
            isWalking = true;
        }
        else
        {
            if (isWalking && walkAudioSource != null && walkAudioSource.isPlaying)
            {
                walkAudioSource.Stop(); // Y�r�y�� sesini durdurur
            }
            isWalking = false;
            AnimatorManager.SetAllAnimatorBools(PlayerAnimator, "idle");
        }
    }
}
