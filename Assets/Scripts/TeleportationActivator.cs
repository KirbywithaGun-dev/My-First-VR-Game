using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class TeleportationActivator : MonoBehaviour
{
    // Teleport ray gameobject
    public XRRayInteractor teleportInteractor;
	// UI ray interactor
	public XRRayInteractor rayInteractor;
    // Teleport input action
    public InputActionProperty teleportActivatorAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Hide teleport ray by default
        teleportInteractor.gameObject.SetActive(false);
        teleportActivatorAction.action.performed += Action_performed;
		rayInteractor.uiHoverEntered.AddListener(x => DisableTeleportRay());
    }

    // If teleport action is held, show teleport ray
    private void Action_performed(InputAction.CallbackContext obj)
    {
		// If the player is currently interacting with UI, disable teleport
		if(rayInteractor && rayInteractor.IsOverUIGameObject()){return;}
        teleportInteractor.gameObject.SetActive(true);
    }
	
	public void DisableTeleportRay()
	{
		teleportInteractor.gameObject.SetActive(false);
	}

    // Update is called once per frame
    void Update()
    {
        // If teleport action released, hide teleport ray
        if (teleportActivatorAction.action.WasReleasedThisFrame())
        {
            teleportInteractor.gameObject.SetActive(false);
        }
    }
}
