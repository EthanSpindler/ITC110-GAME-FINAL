using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartiAttack : MonoBehaviour
{

    private GameObject sideAttackArea = default;
    private GameObject upAttackArea = default;


    private bool attacking = false;

    private bool block = false;

    private float timeToAttack = 1f;
    private float timer = 0f;

    Animator animator;

    SpriteRenderer spriteRenderer;

    CartiHealth health;
    // Start is called before the first frame update
    void Start()
    {
        upAttackArea = transform.GetChild(1).gameObject;
        sideAttackArea = transform.GetChild(0).gameObject;
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        upAttackArea.SetActive(false);
        sideAttackArea.SetActive(false);
        health = GetComponent<CartiHealth>();
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
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Attack();
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            UpAttack();
        }
    }

    void p2update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            Attack();
        }

        if(Input.GetKeyDown(KeyCode.P))
        {
            UpAttack();
        }


    }

    private void Attack()
    {
        if(attacking == false) {
            animator.SetTrigger("doAttack");
        }
    }

    private void UpAttack()
    {
        if(attacking == false) {
            animator.SetTrigger("doUpAttack");
        }
    }

    private void UpColliderToggleOn()
    {
        upAttackArea.SetActive(true);
        attacking = true;
        Debug.Log("Toggle On Up");
    }

    private void UpColliderToggleOff()
    {
        Debug.Log("Toggle On Up");
        upAttackArea.SetActive(false);
        attacking = false;
        Debug.Log("Toggle Off Up");
    }

    private void SideColliderToggleOn()
    {
        sideAttackArea.SetActive(true);
        attacking = true;
    }

    private void SideColliderToggleOff()
    {
        sideAttackArea.SetActive(false);
        attacking = false;
        Debug.Log("Toggle Off Side");
    }
}
