using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour
{

    [SerializeField] private float startingHealth;
    // public, aber get: Variable kann von anderen Scripts genommen werden
    // private set: kann nur in diesem Script gesetzt werden
    public float currentHealth { get; private set; }
    private Animator anim;
    private bool dead;

    private SpriteRenderer spriteRend;
    [SerializeField] private Behaviour[] components;
    [SerializeField] private AudioClip sound_player_hurt;


    // Schaden verhindern, wenn true
    //private bool invulnerable = false;

    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
        spriteRend = GetComponent<SpriteRenderer>();
    }
    

    public void Update()
    {

        //if (Input.GetKeyDown(KeyCode.E))
        //    TakeDamage(1);
        //Debug.Log("Currenthealth: " + currentHealth);


    }

    public void TakeDamage(float _damage)
    {
        if (Input.GetKey(KeyCode.G))
        {
            Debug.Log("No Damage due to Kristall");
            return;
        }
        

        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {
            SoundManager.instance.PlaySound(sound_player_hurt);
            anim.SetTrigger("hurt");
        }
        else
        {
            if (!dead)
            {
                anim.SetTrigger("die");

                //Deactivate all attached component classes
                foreach (Behaviour component in components)
                    component.enabled = false;

                dead = true;
                // SoundManager.instance.PlaySound(deathSound);
            }
        }
        
    }
    public void AddHealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
    }

    public void Respawn()
    {
        dead = false;
        AddHealth(startingHealth);
        anim.ResetTrigger("die");
        anim.Play("Idle");

        foreach (Behaviour component in components)
            component.enabled = true;
    }
    

}