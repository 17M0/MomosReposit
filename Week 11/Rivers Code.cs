River’s code for Health Pack

using UnityEngine;

public class HealthPack : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerHealth player = other.GetComponent<PlayerHealth>();

        if (player != null)
        {
            if (player.health == 100)
            {

            }
            else
            {
                player.health += 10;

                if (player.health > 100)
                {
                    player.health = 100;
                }
            }
            Destroy(gameObject);
        }
    }
}

FiM’s code for Player Mana

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