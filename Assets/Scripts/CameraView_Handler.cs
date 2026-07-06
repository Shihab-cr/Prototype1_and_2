using UnityEngine;

public class CameraView_Handler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private Camera firstView;
    [SerializeField] private Camera thirdView;

    [SerializeField] private Camera firstView2;
    [SerializeField] private Camera thirdView2;
    void Start()
    {
        firstView.enabled = false;
        thirdView.enabled = true;
        firstView2.enabled = false;
        thirdView2.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.V))
        {
            firstView.enabled = !firstView.enabled;
            thirdView.enabled = !thirdView.enabled;
        }
        if(Input.GetKeyDown(KeyCode.B))
        {
            firstView2.enabled = !firstView2.enabled;
            thirdView2.enabled = !thirdView2.enabled;
        }
    }
}
