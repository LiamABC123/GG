using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public int lapsToWin = 5;
    private int playerOneLaps = 0;
    private int playerTwoLaps = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("CarPlayerOne"))
        {
            playerOneLaps++;
            CheckForWinner();
        }
        else if (other.CompareTag("CarPlayerTwo"))
        {
            playerTwoLaps++;
            CheckForWinner();
        }
    }

    private void CheckForWinner()
    {
        if (playerOneLaps >= lapsToWin)
        {
            Debug.Log("Player One wins!");
            // You can add your win logic here for Player One
        }
        else if (playerTwoLaps >= lapsToWin)
        {
            Debug.Log("Player Two wins!");
            // You can add your win logic here for Player Two
        }
    }
}
