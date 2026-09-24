using UnityEngine;

public class PeopleMove : MonoBehaviour
{
    public float score = 0.5f;
   public int lives = 3; 
    public string name = "Bob";
    public bool gameOver = false;

    public float speed;

    public Vector3 targetPosition;

// Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        //Debug.Log("Hello World!");
        Debug.Log(name);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Uh oh");
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime); //speed*Time.deltaTime is helping us avoid differet frame rates from having different speeds
        if (score < 10)
        {
            //Debug.Log("You suck");
        }
    }
}
