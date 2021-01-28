using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carsS4 : MonoBehaviour
{
    public bool run;
    public bool isGreen;


    void Start()
    {
        transform.Rotate(0f, 0.0f, -90f, Space.Self);
    }

    void Update()
    {
        if (GameObject.Find("Manager").GetComponent<Manager>().TwoFour || run)
        {
            gameObject.transform.position += new Vector3(2 * Time.deltaTime, 0f, 0f);
        }

        else if (!GameObject.Find("Manager").GetComponent<Manager>().TwoFour || !run)
        {
            gameObject.transform.position = gameObject.transform.position;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "controlS4")
        {
            run = true;
            print("Control On");
        }

        else if (collision.tag == "Destroyer")
        {
            Destroy(this.gameObject);
        }
    }
}
