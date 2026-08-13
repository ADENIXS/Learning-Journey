using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Serialized fields for movement values meaning they can be set in the Unity Inspector
        float xValue = Input.GetAxis("Horizontal");
        float yValue = 0f; // No vertical movement in this example this is a jump movemnet
        float zValue = Input.GetAxis("Vertical");
        transform.Translate(xValue, yValue, zValue);
    }
}
