using UnityEngine;
using UnityEngine.UI;
public class HungerBar : MonoBehaviour
{
    [SerializeField] private Slider slider;
    private Camera mainCamera;
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slider = GetComponent<Slider>();
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        if (mainCamera == null)
        {
            Debug.LogError("Main Camera not found. Please ensure there is a camera tagged 'MainCamera' in the scene.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = mainCamera.transform.rotation;
        transform.position = target.position + offset;
    }

    public void UpdateHungerBar(float currentHunger, float MaxHunger)
    {
        slider.value = currentHunger/ MaxHunger;
    }
}
