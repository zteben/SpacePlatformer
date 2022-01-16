using UnityEngine;

public class winGame : MonoBehaviour
{
 
         void OnTriggerEnter2D(Collider2D other)
      {
        if (other.tag == "Player")
        {
            PlayerMovement playerWins = other.gameObject.GetComponent<PlayerMovement>();
            playerWins.winGame();
        }

      }
}
