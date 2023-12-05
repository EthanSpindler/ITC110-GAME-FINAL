using UnityEngine;

public class XControls : MonoBehaviour
{
public float moveSpeed = 8.0f;

    public float jumpForce = 450.0f;

    Rigidbody2D rb;

    public bool isGrounded = false;

    public bool shouldJump = false;

    Animator animator;

    SpriteRenderer spriteRenderer;

    XHealth health;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        health = GetComponent<XHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!health.block) {
            if(this.tag == "Player1") 
                p1update();
            else if(this.tag == "Player2")
                p2update();
        }
    }
    void p1update()
    {
        // get horizontal input
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(new Vector3(horizontalInput, 0, 0) * moveSpeed * Time.deltaTime);

        // animate!
        if (horizontalInput > 0)
        {
            animator.SetBool("isRunning", true);
            spriteRenderer.flipX = false;
        }
        else if (horizontalInput < 0)
        {
            animator.SetBool("isRunning", true);
            spriteRenderer.flipX = true;
        }
        else
        {
            animator.SetBool("isRunning", false);
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            shouldJump = true;
        }
    }

    void p2update()
    {
        // get horizontal input
        float horizontalInput = Input.GetAxis("HorizontalP2");

        transform.Translate(new Vector3(horizontalInput, 0, 0) * moveSpeed * Time.deltaTime);

        // animate!
        if (horizontalInput > 0)
        {
            animator.SetBool("isRunning", true);
            spriteRenderer.flipX = true;
        }
        else if (horizontalInput < 0)
        {
            animator.SetBool("isRunning", true);
            spriteRenderer.flipX = false;
        }
        else
        {
            animator.SetBool("isRunning", false);
        }

        if (Input.GetButtonDown("JumpP2") && isGrounded)
        {
            shouldJump = true;
        }
    }

    void FixedUpdate()
    {
        if (shouldJump == true)
        {
            // quickly set back to false so we don't double-jump
            shouldJump = false;

            //push the rigidbody UP
            rb.AddForce(transform.up * jumpForce);

            // animate!
            animator.SetBool("isJumping", true);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ground") {
            isGrounded = true;
            // reset the animation
            animator.SetBool("isJumping", false);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Ground") {
            isGrounded = false;
        }
    }
}