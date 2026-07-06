using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float outOfBounds = 30f;
    public float lowerBounds = -10f;
    [SerializeField] private PlayerLogic playerLogic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerLogic = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerLogic>();
    }

    // Update is called once per frame
    void Update()
    {
        // if object goes out of player's view, destroy it.
        if (transform.position.z > outOfBounds || transform.position.z < lowerBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.x > outOfBounds || transform.position.x < -outOfBounds)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < lowerBounds)
        {
            playerLogic.playerLives--;
        }
    }
}
