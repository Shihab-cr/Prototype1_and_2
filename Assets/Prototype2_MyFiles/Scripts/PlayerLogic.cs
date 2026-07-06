using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float horizontalInput;
    private float verticalInput;
    public float speed = 10f;
    public float xRange = 10f;
    public float zRange = 16f;
    public float zMinRange = -1.6f;
    public GameObject projectilePrefab;
    public int playerLives = 300;
    void Start()
    {
        Debug.Log("Player Lives: " + playerLives);
        Debug.Log("Score: 0");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if(transform.position.z < zMinRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMinRange);
        }
        else if(transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);
        

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            return;
        }
        playerLives--;
        if (playerLives <= 0)
        {
            GameOverHandler();
        }
        Destroy(other.gameObject);
        Debug.Log("Player Lives: " + playerLives);
    }

    private void GameOverHandler()
    {
        Debug.Log("Game Over!");
        //Destroy(gameObject);
        Time.timeScale = 0;
    }
    public void RestartGame()
    {
        Time.timeScale = 1;
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}
