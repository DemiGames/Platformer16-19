using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    PlayerMovement playerMovement;
    PlayerAttack playerAttack;
    Health health;
    public bool canMove;
    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
        playerAttack = GetComponent<PlayerAttack>();
        health = GetComponentInChildren<Health>();
        canMove = true;
    }
    private void Update()
    {
        if (!health.isDead && canMove)
        {
            float horizontalDirection = Input.GetAxis("Horizontal");
            bool isJumpButtonPressed = Input.GetButtonDown("Jump");
            bool isAttacking = Input.GetMouseButtonDown(0);
            playerMovement.Move(horizontalDirection, isJumpButtonPressed);
            playerAttack.Attack(isAttacking);
        }
        if (GameManager.Instance.isFinished)
            canMove = false;
    }
}
