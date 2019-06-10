using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider other)
    {
        if (other.tag == "Player")
            other.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
    }

    private void OnTriggerStay2D(Collider other)
    {
        if (!(other.tag == "Player"))
            return;

        float y = Input.GetAxis("Vertical");
        other.transform.Translate(new Vector3(0, other, 0));
    }
    private void OnTriggerExit2D(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
