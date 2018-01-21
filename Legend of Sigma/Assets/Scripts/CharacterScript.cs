using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterScript : MonoBehaviour {

    public float speed;
    public Text batteryCountText;
    public Text healthText;
    public int maxBatts;
    private int numBatts;
    private int health;
    private bool isAlive;
    public GameObject deadPanel;

	// Use this for initialization
	void Start () {
        isAlive = true;
        /*
        Text[] texts = GameObject.FindObjectsOfType<Text>();
        for (int i = 0; i < texts.Length; i++)
        {
            if (texts[i].tag == "BatteryText")
            {
                batteryCountText = texts[i];
            }
            else if (texts[i].tag == "HealthText")
            {
                healthText = texts[i];
            }
            else if (texts[i].tag == "DeadText")
            {
                deadText = texts[i];
            }
        }
        */

        numBatts = 0;
        batteryCountText.text = "Batteries: " + numBatts.ToString() + " / " + maxBatts;

        health = 100;
        healthText.text = "Health: " + health;
    }
	

    void FixedUpdate()
    {
        if (isAlive)
        {
            float input = Input.GetAxis("Vertical");
            //GetComponent<Rigidbody2D>().AddForce(gameObject.transform.up * speed * input);
            transform.Translate(Vector3.up * Time.deltaTime * input * speed);

            float input2 = Input.GetAxis("Horizontal");
            //GetComponent<Rigidbody2D>().AddForce(gameObject.transform.right * speed * input2);
            transform.Translate(Vector3.right * Time.deltaTime * input2 * speed);

            transform.rotation = Quaternion.identity;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Battery2"))
        {
            Destroy(other.gameObject);
            numBatts += 1;
            batteryCountText.text = "Batteries: " + numBatts.ToString() + " / " + maxBatts;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ship" && numBatts == maxBatts)
        {
            endGame();
        }

    }

    void endGame()
    {
        SceneManager.LoadScene("end", LoadSceneMode.Single);
    }

    public void hurt(int damage)
    {
        if (isAlive)
        {
            health = health - damage;
            healthText.text = "Health: " + health;
            if (health == 0 || health < 0)
            {
                isAlive = false;
                deadPanel.SetActive(true);
            }
        }
    }
}
