using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
	public int BodyHealth = 3;
	public int RightArmHealth = 3;
	public int LeftArmHealth = 3;
	public int RightLegHealth = 3;
	public int LeftLegHealth = 3;
    public AudioClip RobotHit;

    EnemyHealth enemyHealth;
    DamageUI hit;

    AudioSource HurtAudio;
    public int startingHealth = 100;
    public int currentHealth;
	public Image damageImage;
	public float flashSpeed = 5f;
	public Color flashColour = new Color(1f, 0f, 0f, 0.1f);
    PlayerMovement playerMovement;
    PlayerAttack playerAttack;
    bool isDead;
	bool Damaged;

    void Awake()
    {
        enemyHealth = GetComponent<EnemyHealth>();
        HurtAudio = GetComponent<AudioSource>();
        playerMovement = GetComponent<PlayerMovement>();
        playerAttack = GetComponentInChildren<PlayerAttack>();
        hit = GetComponent<DamageUI>();

        currentHealth = startingHealth;
    }


    void Update()
    {
		if (Damaged == true) {

            hit.HitMechPart("Torso");
			damageImage.color = flashColour;

		} else {
			
			damageImage.color = Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);

		}

		Damaged = false;
    }


    public void TakeDamage(int amount)
    {

		Damaged = true;
		HurtAudio.PlayOneShot(RobotHit);

        currentHealth -= amount;

        if (currentHealth <= 0 || enemyHealth.currentHealth <= 0)
        {
            Death();
        }
    }


    void Death()
    {
        isDead = true;

        playerMovement.enabled = false;
        playerAttack.enabled = false;
    }
}
