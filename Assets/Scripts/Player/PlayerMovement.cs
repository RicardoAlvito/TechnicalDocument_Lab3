using System;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Player player;
    private PlayerAnimations playerAnimations;
    [Header("Config")]
    public float speed = 10;
    private Rigidbody2D rigidbody2D;
    private Vector2 moveDirection;
    private Acao actions;

    void Awake()
    {
        actions = new Acao();
        playerAnimations = GetComponent<PlayerAnimations>();
        player = GetComponent<Player>();
    }

    private void OnEnable() => actions.Movement.Enable();
    private void OnDisable() => actions.Movement.Disable(); 

    private void ReadMovement()
    {
        moveDirection = actions.Movement.Move.ReadValue<Vector2>().normalized;
        if (playerAnimations != null)
        {
            if (moveDirection == Vector2.zero)
            {
                playerAnimations.SetMoveBoolTransition(false);
            }
            else
            {
                playerAnimations.SetMoveBoolTransition(true);
                playerAnimations.SetMoveAnimation(moveDirection);
            }
        }
        else
        {
            Debug.LogWarning("estou aqui ha 7 horas");
        }
    }

    private void Move()
    {
        if (player.Stats.HpPlayer <= 0) 
        { return; 
        }
        if (rigidbody2D != null)
        {
            rigidbody2D.MovePosition(rigidbody2D.position + moveDirection * (speed * Time.fixedDeltaTime));
        }
    }

    private void FixedUpdate()
    {
        Move();
    }

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        ReadMovement();
    }
}