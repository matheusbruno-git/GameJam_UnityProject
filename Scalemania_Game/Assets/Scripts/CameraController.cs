using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject playerModel;
    public GameObject normalCam;
    public GameObject shootingCam;
    public GameObject cam;

    bool isAiming;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        float camY = cam.transform.rotation.eulerAngles.y;

        isAiming = Input.GetMouseButton(1);

        if(isAiming)
        {
            playerModel.transform.rotation = Quaternion.Slerp(playerModel.transform.rotation, Quaternion.Euler(0, camY, 0), Time.deltaTime * 100);
            normalCam.SetActive(false);
            shootingCam.SetActive(true);
        }
        else
        {
            normalCam.SetActive(true);
            shootingCam.SetActive(false);
        }
    }
}
