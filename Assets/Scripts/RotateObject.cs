using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float speed; //variable declaration

    [SerializeField]
    private bool isSunActive = false; //variable initialization
    // Start is called before the first frame update
    void Start()
    {
        //speed = 10.0f; //variable assignment
        //Debug.Log("This is the start method");
    }

    // Update is called once per frame
    void Update()
    {
        /*Debug.Log("This is the Update Method"); */

        //Called a function
        RotateMe();
    }

    //Declared a function
    public void RotateMe()
    {
        transform.Rotate(0, 1 * speed * Time.deltaTime, 0);
    }
}
