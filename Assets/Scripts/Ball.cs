using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Ball : MonoBehaviour
{
    public GameObject ground;

    public Text countText;
    public GameObject fin;
    public Text deathText;

    private Rigidbody rb;
    private int count;
    private int death;
    private int sum;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        death = 0;
        sum = 9;
        SetText();
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetText();
        }
        if (other.gameObject.CompareTag("Hole"))
        {
            death = death + 1;
            transform.position = (ground.transform.right) * 2 + (ground.transform.up) * 2 + (ground.transform.forward) * 6;
            rb.velocity = new Vector3(0.0f, 0.0f, 0.0f);
            SetText();
        }

    }

    void SetText()
    {
        countText.text = "Count: " + count.ToString();
        deathText.text = "Death: " + death.ToString();
        if (count >= sum)
        {
            fin.SetActive(true);
        }
    }

}