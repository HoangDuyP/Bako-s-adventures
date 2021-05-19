using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shiba_Alter : MonoBehaviour
{
    public Transform Shiba_limit;
    public Rigidbody Shiba_body;
    public BoxCollider Shiba_box;
    public Transform RespawnPoint_Shiba_Alter;
    public AudioSource JumpSound;
    public AudioClip Sound;
    public float Distance_limit = 21f;
    public float speed_ = 10f;
    public float jumpHeight_ = 600f;
    public float pull_strength = 0f;
    private void Start()
    {
        Shiba_body = gameObject.GetComponent<Rigidbody>();
        Shiba_box = gameObject.GetComponent<BoxCollider>();
        JumpSound = gameObject.GetComponent<AudioSource>();
    }
    private void Update()
    {
        Jump(); 
    }
    private void FixedUpdate()
    {
        Move_Rotate();
        PullBack();
    }
    private void Move_Rotate()
    {
        float horizontalInput = Input.GetAxis("Horizontal Right");
        float verticalInput = Input.GetAxis("Vertical Right");
        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        movementDirection.Normalize();
        transform.Translate(movementDirection * speed_ * Time.deltaTime, Space.World);
        if (movementDirection != Vector3.zero)
        {
            transform.forward = movementDirection;
        }
    }
    private void Jump()
    {
        
        if(Input.GetButtonDown("Jump Right") && Ground_Check())
        {
            Vector3 jumpForce = new Vector3(0, 1f, 0f);
            jumpForce.Normalize();
            JumpSound.PlayOneShot(Sound);
            Shiba_body.AddForce(jumpForce * jumpHeight_);
        }
    }
    private bool Ground_Check()
    {
        RaycastHit hit;
        Vector3 RayDirection = new Vector3(0f, -1f, 0f);
        if(Physics.Raycast(Shiba_box.bounds.center, RayDirection,out hit, Shiba_box.bounds.extents.y))
        {
            if (hit.collider.tag == "Platform")
            {
                RespawnPoint_Shiba_Alter.position = transform.position;
                return true;
            }
            if (hit.collider.tag == "Puzzle")
                return true;
        }
        return false;
    }
    private void PullBack()
    {
        
        if (Vector3.Distance(transform.position, Shiba_limit.position) > Distance_limit)
        {
            Vector3 Direction = Shiba_limit.position - transform.position;
            Direction.Normalize();
            Shiba_body.AddForce(Direction * pull_strength);
        }
    }
}
