using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    PlayerMovement playerMovement;
    PlayerAttack playerAttack;
    Damaging damaging;
    Health health;
    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
        playerAttack = GetComponent<PlayerAttack>();
        damaging = GetComponentInChildren<Damaging>();
        health = GetComponentInChildren<Health>();
    }
    private void Update()
    {
        if (!health.isDead)
        {
            float horizontalDirection = Input.GetAxisRaw("Horizontal");
            bool isJumpButtonPressed = Input.GetButtonDown("Jump");
            bool isAttacking = Input.GetMouseButtonDown(0);
            playerMovement.Move(horizontalDirection, isJumpButtonPressed);
            playerAttack.Attack(isAttacking);
        }
    }
}
