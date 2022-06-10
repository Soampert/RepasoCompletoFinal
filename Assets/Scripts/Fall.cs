using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{

    public float speed = 5f;
    public float yLim = 0f;

   

    private PlayerController PlayerControllerScript;

    // Start is called before the first frame update
    void Start()
    {

        PlayerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }


    // Update is called once per frame
    void Update()
    {
        if (!PlayerControllerScript.gameOver)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }

        // if (transform.position.y < yLim && gameObject.CompareTag("Ground"))
        if (transform.position.y <= yLim)
        {
            Destroy(gameObject);
        }
    }
}
