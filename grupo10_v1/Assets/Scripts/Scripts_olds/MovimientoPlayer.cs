using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("aca es el metodo start");
        gameObject.transform.position = new Vector3(0, 3.44f, 0);
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log("aca es el metodo update");

        if (Input.GetKey("right") && (gameObject.transform.position.x < 11.82))
        {
            gameObject.transform.Translate(3.5f * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("left") && (gameObject.transform.position.x > -11.82))
        {
            gameObject.transform.Translate(-3.5f * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("up"))
        {
            gameObject.transform.Translate(0, 3.5f * Time.deltaTime, 0);
        }

        if ((gameObject.transform.position.y < -6.6))
        {
            Debug.Log("Game over");
        }

    }
}
