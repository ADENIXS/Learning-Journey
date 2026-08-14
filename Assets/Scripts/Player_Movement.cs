using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    //Movement speed
    [SerializeField] float moveSpeed = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Movement speed
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime;
        float yValue = 0f; // No vertical movement in this example this is a jump movemnt
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(xValue * moveSpeed, yValue * moveSpeed, zValue * moveSpeed);
    }
}
