using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int startingHealth = 500;
    public int currentHealth;
    public AudioClip MonsterHurt;

    PlayerHealth playerHealth;
    EnemyMovement enemyMovement;
    EnemyAttack enemyAttack;

    AudioSource HitAudio;
    CapsuleCollider capsuleCollider;            
    bool isDead;                                                           
	public Slider healthSlider;

    void Awake()
    {
        playerHealth = GetComponent<PlayerHealth>();
        HitAudio = GetComponent<AudioSource>();
        capsuleCollider = GetComponent<CapsuleCollider>();
        currentHealth = startingHealth;
		//healthSlider.value = startingHealth;
    }

    void Update()
    {


    }


    public void TakeDamage(int amount, Vector3 hitPoint)
    {

		healthSlider.value = currentHealth;

       
        if (isDead)
        {
            return;
        }
        else
        {
            currentHealth -= amount;
            HitAudio.Play();

            if (currentHealth <= 0 || playerHealth.currentHealth <= 0)
            {
                Death();
            }
        }
    }


    void Death()
    {
        isDead = true;

        capsuleCollider.isTrigger = true;

        enemyMovement.enabled = false;
        enemyAttack.enabled = false;
    }
}
