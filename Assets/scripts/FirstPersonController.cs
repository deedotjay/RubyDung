using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class FirstPersonController : MonoBehaviour
{
    public static FirstPersonController instance;
    public CharacterController controller;
    public float speed = 10;
    public float gravity = -9.81f;
    public float rotateSpeed = 2.5f;
    public AudioSource footstep;
    public Animator camAnim;
    Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (velocity.y < 0)
        {
            velocity.y = -2;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * rotateSpeed);

        if (Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.S) || (Input.GetKey(KeyCode.D)))))
        {
            camAnim.SetTrigger("bopping");
            footstep.enabled = true;
        }
        else
        {
            camAnim.SetTrigger("idle");
            footstep.enabled = false;
        }
    }
}
