using UnityEngine;
using TMPro;

public class ChestManager : MonoBehaviour
{
    // TODO: animate lid when player solves puzzle
    [SerializeField] private TMP_Text redText;
    [SerializeField] private TMP_Text greenText;
    [SerializeField] private TMP_Text blueText;
    [SerializeField] private GameObject key;
    private int[] code = {0,0,0}; // {red, green, blue}
    private bool isSolved = false; // Prevents animation from being triggered twice

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // When a button is pushed, increment it's respective code slot
    public void IncrementCode(int index)
    {
        ++code[index];
        // If code increments past 9, reset to 0
        if(code[index]>9){code[index] = 0;}
        // Update canvas to reflect new code and check to see if the correct code has been inputed
        UpdateText;
        CheckCode;
    }

    // Checks if the correct code has been inputed, if so call OpenChest()
    private void CheckCode()
    {
        if(code[0] == 3 && code[1] == 6 && code[2] == 5)
        {
            OpenChest;
        }
    }

    // Update all canvas text to match code array
    private void UpdateText()
    {
        redText.text = code[0].ToString();
        greenText.text = code[1].ToString();
        blueText.text = code[2].ToString();
    }

    // Play animation and give player key
    public void OpenChest()
    {
        if (!isSolved)
        {
            isSolved = true;
        }
    }
}
