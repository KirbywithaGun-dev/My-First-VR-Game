using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;


public class BookshelfManager : MonoBehaviour
{
	[SerializeField] private GameObject blueSocketObject;
	[SerializeField] private GameObject greenSocketObject;
	[SerializeField] private GameObject redSocketObject;
    [SerializeField] private GameObject Key;
    
    private XRSocketInteractor blueSocket;
    private XRSocketInteractor greenSocket;
    private XRSocketInteractor redSocket;

    private int blueId = 0;
    private int greenId = 0;
    private int redId = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Get reference to sockets
        blueSocket = blueSocketObject.GetComponent<XRSocketInteractor>();
        greenSocket = greenSocketObject.GetComponent<XRSocketInteractor>();
        redSocket = redSocketObject.GetComponent<XRSocketInteractor>();
        // hide key by default
        Key.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void CheckSockets()
	{
		if (blueSocket.hasSelection)
        {
            var interactable = blueSocket.firstInteractableSelected; // get reference to object inside socket

            GameObject socketedObject = interactable.transform.gameObject; // add socketed object to a gameobject variable

            blueId = socketedObject.GetComponent<Book>().GetId(); // Get the id value from the book script inside the object
            Debug.Log("Blue shelf has id: " + blueId);
        }

        if (greenSocket.hasSelection)
        {
            var interactable = greenSocket.firstInteractableSelected; // get reference to object inside socket

            GameObject socketedObject = interactable.transform.gameObject; // add socketed object to a gameobject variable

            greenId = socketedObject.GetComponent<Book>().GetId(); // Get the id value from the book script inside the object
            Debug.Log("Green shelf has id: " + greenId);
        }

        if (redSocket.hasSelection)
        {
            var interactable = redSocket.firstInteractableSelected; // get reference to object inside socket

            GameObject socketedObject = interactable.transform.gameObject; // add socketed object to a gameobject variable

            redId = socketedObject.GetComponent<Book>().GetId(); // Get the id value from the book script inside the object
            Debug.Log("Red shelf has id: " + redId);
        }

        // If each socket has the correct book, spawn the key
        if(blueId == 1 && greenId == 2 && redId == 3)
        {
            Debug.Log("Bookcase Puzzle Solved!");
            Key.gameObject.SetActive(true);
        }
	}
}
