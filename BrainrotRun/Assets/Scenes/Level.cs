using JetBrains.Annotations;
using Unity.Mathematics;
using UnityEngine;

public class Level : MonoBehaviour
{
    public Vector3 levelSpawn;
    public int levelWidth;
    public int levelLength;
    public Vector3 levelScale;
    public Vector3 characterScale;  
    public Quaternion characterRotation;
    public GameObject characterToClone;
    public GameObject levelToClone;
    public CameraController cameraController;

    void StartLevel(){
        Vector3 levelBasePosition = new Vector3(0, 0, levelLength/2);
        GameObject levelClone = Instantiate(levelToClone, levelBasePosition, Quaternion.identity);
        levelClone.transform.localScale = levelScale;
        
        GameObject characterClone = Instantiate(characterToClone, levelSpawn, characterRotation);
        characterClone.transform.localScale = characterScale;

        CharacterMovement characterMovement = characterClone.AddComponent<CharacterMovement>();

        characterMovement.level = this;

        if (cameraController != null){
            cameraController.character = characterClone;
        }

    }

    void Start(){
        StartLevel();
    }
}
