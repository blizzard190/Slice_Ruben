using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_change : MonoBehaviour
{
    [SerializeField]
    public GameObject CameraPoint;
    public GameObject CameraPoint1;

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" && Camera.main.transform.position != CameraPoint.transform.position)
        {
            MoveCamera(CameraPoint.transform.position, new Vector3(17.74f, -90, 0));
        }
        else if (other.gameObject.tag == "Player" && Camera.main.transform.position != CameraPoint1.transform.position)
        {
            MoveCamera(CameraPoint1.transform.position, new Vector3(62.35f, -90, 0));
        }
    }

    private void MoveCamera(Vector3 position, Vector3 rotation)
    {
        Camera.main.transform.position = position;
        Camera.main.transform.rotation = Quaternion.Euler(rotation);
    }
}