using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManagement : MonoBehaviour {

	public List<GameObject> Spawnpoints = new List<GameObject>();
	public Slider slider;
	public GameObject OniiPrefab;

    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;

    public Text gameover;
    public Text win;

    int SpawnNo;
    bool GameRunning = true;

	// Use this for initialization
	void Start () {

        playerHealth = GetComponent<PlayerHealth>();
        enemyHealth = GetComponent<EnemyHealth>();

        gameover = GetComponent<Text>();
        win = GetComponent<Text>();

        SpawnNo = Random.Range (0, 3);

		GameObject Onii = GameObject.Instantiate(OniiPrefab, Spawnpoints[SpawnNo].transform.position, OniiPrefab.transform.rotation);

		Onii.GetComponent<EnemyHealth> ().healthSlider = slider;

	}
	
	// Update is called once per frame
	void Update () {

        if (playerHealth.currentHealth <= 0 || enemyHealth.currentHealth <= 0) {

            EndGame();

        }
		
	}

    void EndGame() {

        if (playerHealth.currentHealth <= 0)
        {
            gameover.enabled = true;
        }
        else {
           win.enabled = true;
        }
    }
}
