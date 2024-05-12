using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Coin : MonoBehaviour {
   //  [SerializeField] Text Text2;

    [SerializeField] float turnSpeed = 90f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Obstacle>() != null)
        {
            Destroy(gameObject);
            return;
        }

        // Check if the object we collided with is the player
        if (other.gameObject.name != "Player")
        {
            return;
        }

        // Add to the player's score
        GameManager.inst.IncrementScore();

        // Check if the player's score has reached 10
        if (GameManager.inst.score >= 10)
        {
           // Text2.text = "Congratulations! You're going to Level 2";

            // Load level 2
            Application.LoadLevel("Level2");
        }

        // Destroy this coin object
        Destroy(gameObject);
    }

    private void Start()
    {

    }

    private void Update()
    {
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
    }
}
