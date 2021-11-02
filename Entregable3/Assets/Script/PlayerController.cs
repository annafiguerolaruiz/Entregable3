using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public void ScaleToDirection(KeyCode key, Vector3 axis)
    {
        if (Input.GetKeyDown(key))
        {
            transform.localScale += 2 * axis;
        }
    }

    public void RotateToDirection(KeyCode key, Vector3 axis)
    {
        if (Input.GetKeyDown(key))
        {
            transform.rotation *= Quaternion.Euler(axis);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        ScaleToDirection(KeyCode.W, Vector3.one);
        RotateToDirection(KeyCode.R, new Vector3(45, 0, 45));
    }
}
