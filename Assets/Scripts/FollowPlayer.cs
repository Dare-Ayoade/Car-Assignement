using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject player; 
    private Vector3 offset = new Vector3(0, 5, -7); //offset of the camera from the player
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //offset the camera position to be above and behind the player
        transform.position = player.transform.position + offset;
        
    }
}
