using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System;
using Unity.VisualScripting;

public class PlayerMovementTutorial : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;
    public float walk;
    public float groundDrag;

    public float jumpForce;
    public float jumpCooldown;
    public float airMultiplier;
    bool readyToJump;

    [HideInInspector] public float walkSpeed;
    [HideInInspector] public float sprintSpeed;

    [Header("Keybinds")]
    public KeyCode jumpKey = KeyCode.Space;

    [Header("Ground Check")]
    public float playerHeight;
    public LayerMask whatIsGround;
    bool grounded;

    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;

    Rigidbody rb;
    Animator anim;
    public int mxHP = 100;
    public int myHP;
    public HealthBar healthBar;
    public Canvas canvas;
    public string scean;
    public AudioSource sound;
    public AudioSource bgsound;
    public float stillTime = 1;
    public Gunscrip Gunfire;
    public bool diad = false;
    public float cooldownitem;
         


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;

        readyToJump = true;
        myHP = mxHP;
        healthBar.SetMaxHealth(mxHP);
        canvas.gameObject.SetActive(false);
        sound.GetComponent<AudioSource>();
    }

    private void Update()
    {
        // ground check
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.3f, whatIsGround);

        MyInput();
        SpeedControl();

        // handle drag
        if (grounded)
            rb.drag = groundDrag;
        else
            
            rb.drag = 0;
        Gunfire.Takehp(myHP);
        
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        // when to jump
        if(Input.GetKey(jumpKey) && readyToJump && grounded)
        {
            readyToJump = false;

            Jump();

            Invoke(nameof(ResetJump), jumpCooldown);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {

            moveSpeed = 20f;
            

        }

        else

        {
            moveSpeed = walk;
            
        }
        if(moveSpeed == 20f)
        {
            print("run");
            
        }


    }

    private void MovePlayer()
    {
        // calculate movement direction
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        // on ground
        if(grounded)
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);

        // in air
        else if(!grounded)
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f * airMultiplier, ForceMode.Force);

        
    }

    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        // limit velocity if needed
        if(flatVel.magnitude > moveSpeed)
        {
            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
        }
    }

    private void Jump()
    {
        // reset y velocity
        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }
    private void ResetJump()
    {
        readyToJump = true;
    }
    public void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.CompareTag("Enamy"))
        // {

        if (myHP <= 0) Invoke(nameof(gameover),10f);

        // }
        if (myHP <= 0) 

        {
            canvas.gameObject.SetActive(true);
            bgsound.Stop();
            rb.constraints = RigidbodyConstraints.FreezeAll;
            playsoun();

        } 
    }

    public void playsoun()
    {
        if (myHP <= 0 && diad == false)
        {
            sound.Play();
            diad = true;
        }
    }

    public void TakeDamage(int damage)
    {

        myHP -= damage;
        Gunfire.Takehp(myHP);
        healthBar.SetHealth(myHP);
    }
    public void heal(int heal)
    {

        myHP += heal;
        healthBar.SetHealth(myHP);
    }

    public void superjump(int jumpboot)
    {
        rb.mass = jumpboot;
        //cooldownitem = 5f;
        if (rb.mass <= 1) Invoke(nameof(jumset),5f);
       // print(cooldownitem);
    }

    public void jumset ()
    {
        rb.mass = 2;
        print("yes");
    }
    /*private IEnumerator waittime ( float Delay)
    {
        canvas.gameObject.SetActive(true);
        Delay = 0.3f;
        yield return new WaitForSeconds(Delay);
        if (myHP <= 0) Invoke(nameof(gameover), 0.5f);

    }*/

    private void gameover()
    {
        //anim.SetTrigger("dead");
        //rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
        print("dead");
        
        Destroy(rb);
        
        SceneManager.LoadScene(scean);


        
    }
}