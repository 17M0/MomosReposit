# Week 11

Momo's code for Trap

public class FunnyTrap : MonoBehaviour
{
    public GameObject objectToAppear;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objectToAppear.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            objectToAppear.SetActive(true);
        }
    }
}


FiM's code for Player Mana

using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class PlayerMana : MonoBehaviour
{
    public int mana = 50;
    public TMP_Text manaText;
    public Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manaText.text = "Mana: " + mana;
    }

    // Update is called once per frame
    void Update()
    {
        manaText.text = "Mana: " + mana;

        if (Keyboard.current.fKey.wasPressedThisFrame)
        {
            if (mana >= 5)
            {
                mana -= 5;
            }

            if (mana == 0)
            {
                animator.SetBool("OOM", true);
            }
            else
            {
                animator.SetBool("OOM", false);
            }
        }
    }
}