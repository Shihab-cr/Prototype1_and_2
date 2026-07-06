using UnityEngine;

public class Local_Multiplayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private GameObject secondPlayer;
    [SerializeField] private Camera[] secondPlayerCameras;
    [SerializeField] private Camera[] firstPlayerCameras;
    void Start()
    {
        secondPlayer.SetActive(false);
    }

    // Update is called once per frame
    //Note for future self: PLEASE READ THIS!!!!!!

    //The x and y in the camera viewport rect are the position of the camera on the screen. (x,y)
    //The width and height are how much space the camera takes up on the screen.  (w,h)

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            secondPlayer.SetActive(true);
            foreach (Camera cam in secondPlayerCameras)
            {
                cam.rect = new Rect(0.5f, 0f, 1f, 1f);
            }
            foreach (Camera cam in firstPlayerCameras)
            {
                cam.rect = new Rect(-0.5f, 0f, 1f, 1f);
            }
        }
    }
}
