using UnityEngine;

public class ChestManager : MonoBehaviour
{
    private int[] code = {0,0,0}; // {red, green, blue}

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
    }

    public void OpenChest()
    {
        
    }
}
