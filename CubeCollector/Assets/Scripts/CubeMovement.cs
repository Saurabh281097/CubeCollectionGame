using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CubeMovement : MonoBehaviour
{
    public float velocity;

    public TMP_Text ScoreText;

    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal,0,vertical);
        transform.Translate(movement * velocity * Time.deltaTime);
    }

    
    void OnTriggerEnter(Collider otherObj)
    {
        Debug.Log("Cube is collided");

        if(otherObj.tag == "CollectionCube")
        {
            score = score + 1;
            ScoreText.text = "Score : " + score.ToString();
        }

        if(otherObj.tag == "EnemyCube")
        {
            ScoreText.text = "Be Careful EnemyCube";
        }
    }
}
