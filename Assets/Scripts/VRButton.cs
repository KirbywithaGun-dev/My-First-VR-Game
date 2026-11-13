using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class VRButton : MonoBehaviour
{
    // Time button is inactive after release
    [SerializeField] private float deadTime = 1.0f;
    // bool to lock down button during dead time
    private bool deadTimeActive = false;

    public UnityEvent onPressed, onReleased;

    // Checks if the button top is colliding with the trigger
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Button") && !deadTimeActive)
        {
            onPressed?.Invoke();
            Debug.Log("Button has been pressed");
        }
    }

    // Checks if button top leaves the trigger, if so trigger a coroutine to wait before the button can be pressed again
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Button") && !deadTimeActive)
        {
            onReleased?.Invoke();
            Debug.Log("Button has been released");
            StartCoroutine(WaitForDeadTime());
        }
    }

    // Lock button until dead time has passed
    IEnumerator WaitForDeadTime()
    {
        deadTimeActive = true;
        yield return new WaitForSeconds(deadTime);
        deadTimeActive = false;
    }
}
