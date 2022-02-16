using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    public Camera camera3;
    public Camera camera4;
    public Camera camera5;
    public Camera camera6;
    public Camera camera7;
    public Camera camera8;
    public Camera camera9;


    public void Start()
    {
        camera1.enabled = true;
        camera2.enabled = false;
        camera3.enabled = false;
        camera4.enabled = false;
        camera5.enabled = false;
        camera6.enabled = false;
        camera7.enabled = false;
        camera8.enabled = false;
        camera9.enabled = false;
    }

    public void Update()
    {
        //Cycles through cameras when assigned number key is pressed
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            camera1.enabled = true;
            camera2.enabled = false;
            camera3.enabled = false;
            camera4.enabled = false;
            camera5.enabled = false;
            camera6.enabled = false;
            camera7.enabled = false;
            camera8.enabled = false;
            camera9.enabled = false;
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            camera1.enabled = false;
            camera2.enabled = true; 
            camera3.enabled = false;
            camera4.enabled = false;
            camera5.enabled = false;
            camera6.enabled = false;
            camera7.enabled = false;
            camera8.enabled = false;
            camera9.enabled = false;
        }
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            camera1.enabled = false;
            camera2.enabled = false;
            camera3.enabled = true;
            camera4.enabled = false;
            camera5.enabled = false;
            camera6.enabled = false;
            camera7.enabled = false;
            camera8.enabled = false;
            camera9.enabled = false;
        }
        if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            camera1.enabled = false;
            camera2.enabled = false;
            camera3.enabled = false;
            camera4.enabled = true;
            camera5.enabled = false;
            camera6.enabled = false;
            camera7.enabled = false;
            camera8.enabled = false;
            camera9.enabled = false;
        }
        if(Input.GetKeyDown(KeyCode.Alpha5))
        {
            camera1.enabled = false;
            camera2.enabled = false;
            camera3.enabled = false;
            camera4.enabled = false;
            camera5.enabled = true;
            camera6.enabled = false;
            camera7.enabled = false;
            camera8.enabled = false;
            camera9.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            camera1.enabled = false;
            camera2.enabled = false;
            camera3.enabled = false;
            camera4.enabled = false;
            camera5.enabled = false;
            camera6.enabled = true;
            camera7.enabled = false;
            camera8.enabled = false;
            camera9.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            camera1.enabled = false;
            camera2.enabled = false;
            camera3.enabled = false;
            camera4.enabled = false;
            camera5.enabled = false;
            camera6.enabled = false;
            camera7.enabled = true;
            camera8.enabled = false;
            camera9.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            camera1.enabled = false;
            camera2.enabled = false;
            camera3.enabled = false;
            camera4.enabled = false;
            camera5.enabled = false;
            camera6.enabled = false;
            camera7.enabled = false;
            camera8.enabled = true;
            camera9.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            camera1.enabled = false;
            camera2.enabled = false;
            camera3.enabled = false;
            camera4.enabled = false;
            camera5.enabled = false;
            camera6.enabled = false;
            camera7.enabled = false;
            camera8.enabled = false;
            camera9.enabled = true;
        }
    }
}