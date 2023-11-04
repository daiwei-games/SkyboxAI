using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public float rotationSpeed;
    public float positionSpeed;

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * positionSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime * positionSpeed;
        }
        transform.Rotate(Vector3.up, mouseX);
        transform.Rotate(Vector3.left, mouseY);
    }
}
