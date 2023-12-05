using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UziHealth : MonoBehaviour
{
    [SerializeField] private int health = 120;

    private int MAX_HEALTH = 120;

    public bool block = false;

    public HealthBar healthBar;

    public bool moveNot = false;

    void Start()
    {
        healthBar.SetMaxHealth(MAX_HEALTH);
    }

    // Update is called once per frame
    void Update()
    {
        if(this.tag == "Player1")
            p1update();
        else if(this.tag == "Player2")
            p2update();
            
    }

    void p1update() {
        if(Input.GetKey(KeyCode.S))
        {
            Block(true);
        }

        if(!Input.GetKey(KeyCode.S))
        {
            Block(false);
        }
    }

    void p2update() {
        if(Input.GetKey(KeyCode.L))
        {
            Block(true);
        }

        if(!Input.GetKey(KeyCode.L))
        {
            Block(false);
        }
    }

    private void Block(bool blocking)
    {
        block = blocking;

    }

    public void Damage(int amount)
    {
        if(block) {
            amount = 0;
            Debug.Log("blocked!");
        }

        if(amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative Damage");
        }

        this.health -= amount;

        healthBar.SetHealth(this.health);

        if(health <= 0)
        {
            Die();
        }
    }

    public void Heal(int amount)
    {
        if(amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative Damage");
        }

        bool wouldBeOverMaxHealth = health + amount > MAX_HEALTH;

        if(wouldBeOverMaxHealth)
        {
            this.health = MAX_HEALTH;
        }
        else
        {
            this.health += amount;
        }
    }

    private void Die()
    {
        if(this.tag == "Player1") {
            GameObject.Find("Player2Win").GetComponent<TextMeshProUGUI>().text = "Player 2 Wins!!";
        }
        else if(this.tag == "Player2") {
            GameObject.Find("Player1Win").GetComponent<TextMeshProUGUI>().text = "Player 1 Wins!!";
        }
        Debug.Log("You have Died");
        Destroy(gameObject);
        SceneManager.LoadScene("MainTitle");
    }
}
