using UnityEngine;

public class carWheels : MonoBehaviour
{
    public bool isFrontWheel;
    public float rotationSpeed= 70f;
    public float horizontalTurnSpeed = 45f;

    public float horizontalInput;
    public float verticalInput;

    public float maxSteerAngle = 30f;
    public float steerAngle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        steerAngle = horizontalTurnSpeed * Time.deltaTime * horizontalInput;

        if (isFrontWheel)
        {
            transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime * verticalInput);
            //if(transform.localRotation.y < 60f)
            //{
            //    transform.Rotate(Vector3.up, steerAngle);
            //}
            //else
            //{
            //    transform.Rotate(Vector3.up, 0f);
            //}
        }
        else
        {
            transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime * verticalInput);
        }
        
    }
}
