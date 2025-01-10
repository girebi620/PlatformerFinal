using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CharacterMove : MonoBehaviour, IMove
{
    public float Speed, SprintSpeed;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move(Speed);
    }

    public void Move(float Speed)
    {
        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");

        Vector3 MoveDir = transform.right * x + transform.forward * z;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += MoveDir * SprintSpeed * Time.deltaTime;
        }
        else
        {
            transform.position += MoveDir * Speed * Time.deltaTime;
        }
    }
}

