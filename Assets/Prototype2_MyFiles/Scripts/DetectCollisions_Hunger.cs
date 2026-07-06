using UnityEngine;

public class DetectCollisions_Hunger : MonoBehaviour
{
    public static int score = 0;
    [SerializeField] private int maxHungerLevel = 20;
    private int currentHungerLevel = 0;
    [SerializeField] private HungerBar hungerBar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hungerBar.UpdateHungerBar(currentHungerLevel, maxHungerLevel);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            handleHunger();
            //Destroy(other.gameObject);
        }
        
    }

    private void handleHunger()
    {
        currentHungerLevel += 5;
        hungerBar.UpdateHungerBar(currentHungerLevel, maxHungerLevel);
        if (currentHungerLevel >= maxHungerLevel)
        {
            score++;
            Debug.Log("Score: " + score);
            Destroy(gameObject);
        }
    }
}
