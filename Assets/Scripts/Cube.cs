using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Cube : MonoBehaviour
{
    public Text counter;
    string text;
    private int c = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cube")
        {
            c++;
            counter.text = c.ToString();
        }
    }
}
