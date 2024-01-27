using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] InfomationSO infomationSO;
    [SerializeField] ShowTextCharacter showTextCharacter;

    float speed;
    float force;
    float weight;
    float dame;
    bool isGround;
    [SerializeField] bool playerA;
    [SerializeField] int numberJump = 1;
    int _numberJump;
    bool facingRight;
    

    Rigidbody2D rb;
    Animator ani;
    BoxCollider2D boxCollider;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();

        speed = infomationSO.Speed;
        force = infomationSO.Force;
        weight = infomationSO.Weight;
        dame = infomationSO.Dame;
        
        rb.sharedMaterial = infomationSO.PhysicsMaterial2D;

        facingRight = true;
        isGround = false;
        _numberJump = numberJump;

        Invoke("ConvertClass", 0.2f);
    }
    void ConvertClass()
    {
        showTextCharacter.SetName(playerA ? "Người chơi 1" : "Người chơi 2");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GameController.instance.Pause) return;
        isGround = boxCollider.IsTouchingLayers();
        CheckInput();
    }

    void CheckInput()
    {
        if((Input.GetKey(KeyCode.A) && playerA) || (Input.GetKey(KeyCode.LeftArrow) && !playerA)){
            Run(-1);
        }else if((Input.GetKey(KeyCode.D) && playerA) || (Input.GetKey(KeyCode.RightArrow) && !playerA))
        {
            Run(1);
        }else { Run(0); }

        if ((Input.GetKeyDown(KeyCode.W) && playerA) || (Input.GetKeyDown(KeyCode.UpArrow) && !playerA))
        {
            Jump();
        }
        if((Input.GetKeyDown(KeyCode.F) && playerA) || (Input.GetKeyDown(KeyCode.Return) && !playerA))
        {
            Attack();
        }
    }

    void Run(float move)
    {
        if((facingRight && move < 0) || (!facingRight && move > 0))
            Flip();
        move *= isGround ? 1 : 2;
        Debug.Log(move);
        ani.SetBool("Run", move != 0);
        rb.velocity = new Vector2(speed * move, rb.velocity.y);
    }
    void Jump()
    {
        if (_numberJump == 0) return;
        _numberJump--;
        rb.velocity = new Vector2(rb.velocity.x, force);
    }
    private void Attack()
    {
        ani.SetTrigger("Attack");
    }
    void Flip()
    {
        //Debug.Log("Flip");
        facingRight = !facingRight;
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        showTextCharacter.Flip();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        _numberJump = numberJump;
    }
}
