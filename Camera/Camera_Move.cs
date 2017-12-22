using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Move : MonoBehaviour
{
    public GameObject camera1;
    private bool trap = false;

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" && trap == false)
        {
            MoveCamera(new Vector3(-1.71f, 2.89f, -7.08f),new Vector3(25.2f, -90, 0));
            trap = true;
        }
        else if (other.gameObject.tag == "Player" && trap == true)
        {
            MoveCamera(new Vector3(0.1965061f, 2.68f, -8.287f),new Vector3(32.27f, -90, 0));
            trap = false;
        }
    }

    private void MoveCamera(Vector3 position, Vector3 rotation)
    {
        iTween.MoveTo(camera1, position, 2f);
        iTween.RotateTo(camera1, rotation, 2f);
    }

}
