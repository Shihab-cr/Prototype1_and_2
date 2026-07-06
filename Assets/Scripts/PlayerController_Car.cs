using UnityEngine;

public class PlayerController_Car : MonoBehaviour
{
    //private variables
    [SerializeField] private float vehicleSpeed = 20f;
    [SerializeField] private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float verticalInput;

    [SerializeField] private string HorizontalInput;
    [SerializeField] private string VerticalInput;
   

    // Update is called once per frame
    void FixedUpdate()
    {
        //Get input here
        horizontalInput = Input.GetAxis(HorizontalInput);
        verticalInput = Input.GetAxis(VerticalInput);

        //Move Vehicle here
        transform.Translate(Vector3.forward * Time.deltaTime * vehicleSpeed * verticalInput);
        //Rotate vehicle here
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
    public float GetVehicleTurnSpeed()
    {
        return turnSpeed;
    }
}
        //Old code
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);