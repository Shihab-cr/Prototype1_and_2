using UnityEngine;

public class movingVehicleObstacle : MonoBehaviour
{
    public float movingSpeed = 10f;
    void Update()
    {
        transform.Translate(Vector3.forward * movingSpeed * Time.deltaTime);
    }
}
