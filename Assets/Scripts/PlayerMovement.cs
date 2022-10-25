using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float jumpForce;
    [SerializeField] bool isGrounded;
    [SerializeField] float speed;
    [SerializeField] Transform groundCollider;
    [SerializeField] float jumpOffset;
    [SerializeField] LayerMask groundMask;
    Animator animator;
    private Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        Vector2 overlapcirclePosition = groundCollider.position;
        isGrounded = Physics2D.OverlapCircle(overlapcirclePosition, jumpOffset, groundMask);
    }
    public void Move(float direction, bool isJumpButtonPressed)
    {
        animator.SetBool("Jumping", !isGrounded);
        if (isJumpButtonPressed)
            Jump();
        if (direction > 0)
        {
            HorizontalMovement(direction);
            transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }
        else if (direction < 0)
        {
            HorizontalMovement(direction);
            transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        }
        else
            animator.SetBool("Running", false);
    }
    void Jump()
    {
        if (isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
    void HorizontalMovement(float direction)
    {
        rb.velocity = new Vector2(direction * speed, rb.velocity.y);
        animator.SetBool("Running", true);
    }
}
