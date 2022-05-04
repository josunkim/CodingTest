using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LotMouse : MonoBehaviour
{
    [SerializeField]
    private Transform cameraArm;
    [SerializeField]
    private Transform characterBpdy;

  
    // Start is called before the first frame update
    void Start()
    {
       
    }


    void Update()
    {
        LookAround();
    }
    private void LookAround()
    {
        Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        Vector3 camAngle = cameraArm.rotation.eulerAngles;

        cameraArm.rotation = Quaternion.Euler(camAngle.x - mouseDelta.y, camAngle.y + mouseDelta.x, camAngle.z);
    }
}
