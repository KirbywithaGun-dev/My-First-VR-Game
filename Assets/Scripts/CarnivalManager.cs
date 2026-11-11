using UnityEngine;

public class CarnivalManager : MonoBehaviour
{
    [SerializeField] private GameObject key;
    private int canCount = 0;

    void Start()
    {
        // Hide key by default
        key.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        // When a can enters this collider it is "knocked over" and canCount is increased
        if (other.CompareTag("Can"))
        {
            ++canCount;
            Debug.Log("Cans knocked over: " + canCount);
            // If all cans are knocked over, show key
            if (canCount >= 12)
            {
                Debug.Log("Carnival Puzzle Solved");
                key.SetActive(true);
            }
        }
        else if (other.CompareTag("Ball"))
        {
            Debug.Log("Baseball entered");
        }
    }

    // If a can leaves the collider (usually during a reset) decrement canCount
    /*
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Can"))
        {
            --canCount;
        }
    }
    */
}
