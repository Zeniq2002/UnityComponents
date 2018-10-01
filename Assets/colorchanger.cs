using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchanger : MonoBehaviour
{   
    public SpriteRenderer rend;
    public Color color;
    public float moveSpeed = 6f;
    public float rotationSpeed = 360;
    public TrailRenderer trailRend; 

    // Use this for initialization

    void Start ()
    {
        rend.color = color;
        rend.color = new Color(0.2f, 1, 0.33f);

        transform.position = new Vector3(-1f, transform.position.y);
        transform.Translate(-5, 0, 0, Space.World);
    }

	
	// Update is called once per frame
	void Update ()
    {
        // go left
        if(Input.GetKey(KeyCode.LeftArrow))
        {
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }
        // go right
        if (Input.GetKey(KeyCode.RightArrow))
        {
        transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
        }
        // get boost
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(moveSpeed * Time.deltaTime, 0, 0, Space.Self);
            rend.color = Color.green; //new color(0,1,0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-moveSpeed / 3f * Time.deltaTime, 0, 0);
            trailRend.endColor = new Color(1, 0, 1);
            trailRend.startColor = new Color(1, 0.5f, 0);
        }
        transform.Translate(0 * Time.deltaTime, 0, 0, Space.Self);
	}
}