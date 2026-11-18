using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class ExitDoor : MonoBehaviour
{
    [SerializeField] private GameObject lock1;
    [SerializeField] private GameObject lock2;
    [SerializeField] private GameObject lock3;
    [SerializeField] private Animator door;

    private XRSocketInteractor lockSocket1;
    private XRSocketInteractor lockSocket2;
    private XRSocketInteractor lockSocket3;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Get reference to sockets
        lockSocket1 = lock1.GetComponent<XRSocketInteractor>();
        lockSocket2 = lock2.GetComponent<XRSocketInteractor>();
        lockSocket3 = lock3.GetComponent<XRSocketInteractor>();
    }

    public void CheckSockets()
    {
        // Check if all sockets have keys, if so, open door
        if(lockSocket1.hasSelection && lockSocket2.hasSelection && lockSocket3.hasSelection)
        {
            Debug.Log("Player has escaped");
            door.Play("door_open");
        }
        else
        {
            Debug.Log("Key added");
        }
    }
}
