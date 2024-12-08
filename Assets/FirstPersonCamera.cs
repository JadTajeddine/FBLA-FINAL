using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public float sensitivity = 10f;
    public float minAngle = -90f;
    public float maxAngle = 90f;

    private float rotationX = 0f;
    private float rotationY = 0f;

    void Update()
    {
        rotationX += Input.GetAxis("Mouse X") * sensitivity;
        rotationY += Input.GetAxis("Mouse Y") * sensitivity;

        rotationY = Mathf.Clamp(rotationY, minAngle, maxAngle);

        transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0f);
    }
}