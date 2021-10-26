using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // transform.position = new Vector3(0, 0, 0);
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            transform.localScale += new Vector3(0.5f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            transform.localScale += new Vector3(0, 0.5f, 0);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            transform.localScale += new Vector3(0, 0, 0.5f);
        }



        //Transform.localScale = new Vector3(0.5, 0, 0);
        // Transform.localScale(KeyCode.X, new Vector3(0.5, 0, 0));
        // ScaleGameObject(KeyCode.Y, new Vector3(0, 0.5, 0));
        // ScaleGameObject(KeyCode.Z, new Vector3(0, 0, 0.5));
    }
}
