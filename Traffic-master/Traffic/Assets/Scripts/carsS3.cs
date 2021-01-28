using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carsS3 : MonoBehaviour
{
    public bool run;
    public bool isGreen;

    void Start()
    {
        transform.Rotate(0f, 0.0f, 0f, Space.Self);
    }

    void Update()
    {
        if (GameObject.Find("Manager").GetComponent<Manager>().UnoThree || run)
        {
            gameObject.transform.position += new Vector3(0f, 2 * Time.deltaTime, 0f);
        }

        else if (!GameObject.Find("Manager").GetComponent<Manager>().UnoThree || !run)
        {
            gameObject.transform.position = gameObject.transform.position;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "controlS3")
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
