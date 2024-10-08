using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    [SerializeField] int lives = 3; 
    [SerializeField] float speed = 6.0f;
    float x = 0;
    float y = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerMove = new Vector2(x, y);
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            playerMove = new Vector2(speed,y) * Time.deltaTime;

        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            playerMove = new Vector2(-speed, y) * Time.deltaTime;

        }
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            playerMove = new Vector2(x, speed) * Time.deltaTime;

        }
        if (Input.GetAxisRaw("Vertical") < 0)
        {
            playerMove = new Vector2(x, -speed) * Time.deltaTime;

        }
        
        transform.Translate(playerMove);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.gameObject.tag == "item")
        {
            Destroy(coll.gameObject);
        }
        if (coll.gameObject.tag == "wall")
        {
            
        }
    }
    void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 100, 20), "Lives:" + lives);
    }
}
