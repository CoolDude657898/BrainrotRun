using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class CameraController : MonoBehaviour
{
    public GameObject character;
    public GameObject followCamera;
    public Vector3 cameraOffset = new Vector3(0, 9, -15);

    void Update(){
        Transform characterTransform = character.transform;
        followCamera.transform.position = characterTransform.position + cameraOffset;
    }
}
