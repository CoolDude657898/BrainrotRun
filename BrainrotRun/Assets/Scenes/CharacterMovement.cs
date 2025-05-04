using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Level level;
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){
            transform.position += Vector3.forward * 0.01f;
        }

        if (Input.GetKey(KeyCode.S)){
            transform.position += Vector3.back * 0.01f;
        }

        if (Input.GetKey(KeyCode.D)){
            if (transform.position.x < level.levelWidth/2){
                transform.position += Vector3.right * 0.01f;
            }
        }

        if (Input.GetKey(KeyCode.A)){
            if (transform.position.x > -level.levelWidth/2){
                transform.position += Vector3.left * 0.01f;
            }
        }
    }
}
