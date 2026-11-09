using UnityEngine;

public class CarnivalManager : MonoBehaviour
{

    Collider[] knockedCans = Physics.OverlapBox(
            transform.position,
            transform.localScale,
            Quaternion.identity,
            0 // layer mask (0 = all layers)
        );
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Debug.Log("A baseball has entered the collider");
        }
        else if (other.CompareTag("Can"))
        {
            Debug.Log("A Can has entered the collider");
        }

    }
}
