using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScalingNorth : MonoBehaviour
{
    float i = 1;
    // Start is called before the first frame update
    public void scaling_cube()
    {
        i = i + 0.5f;
        transform.localScale = new Vector3(1f, i, 1f);
    }

    public void OnCollisionEnter(Collision collision)
    {
        Color myColor = GetComponent<Renderer>().material.color;
        Color otherColor = collision.gameObject.GetComponent<Renderer>().material.color;
        if (myColor.Equals(otherColor) || collision.gameObject.CompareTag("center_cube"))
        {
            i = 1;
            transform.localScale = new Vector3(1, 1, 1);
            Destroy(collision.gameObject);
        }
    }
}
