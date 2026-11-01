using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class TeleportationActivator : MonoBehaviour
{
    // Teleport ray gameobject
    public XRRayInteractor teleportInteractor;
    // Teleport input action
    public InputActionProperty teleportActivatorAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Hide teleport ray by default
        teleportInteractor.gameObject.SetActive(false);

        teleportActivatorAction.action.performed += Action_performed;
    }

    // If teleport action is held, show teleport ray
    private void Action_performed(InputAction.CallbackContext obj)
    {
        teleportInteractor.gameObject.SetActive(true);
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
