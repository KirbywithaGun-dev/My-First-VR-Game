using UnityEngine;

public class ResettableObject : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbody;
    private Vector3 originalPosition;
    private Quaternion originalRotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        originalPosition = transform.position;
        originalRotation = transform.rotation;
    }

    public void ResetObject()
    {
        transform.position = originalPosition;
        transform.rotation = originalRotation;
        if (rigidbody != null)
        {
            rigidbody.linearVelocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;
        }
    }
}
