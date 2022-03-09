using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CarDrive : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public float gravityMultiplier;
    public TextMeshProUGUI text_Points;

    private int pointsCollected = 0;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Restart();
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void FixedUpdate()
    {
        Accelerate();
        Turn();
        Fall();
    }

    void Accelerate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * speed * 10);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.AddRelativeForce(-new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * speed * 10);
        }

        Vector3 locVel = transform.InverseTransformDirection(rb.velocity);
        locVel = new Vector3(0, locVel.y, locVel.z);
        rb.velocity = transform.TransformDirection(locVel);
    }

    void Turn()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(-transform.up * turnSpeed * 10);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(transform.up * turnSpeed * 10);
        }
    }

    void Fall()
    {
        rb.AddForce(Vector3.down * gravityMultiplier * 10);
    }

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.CompareTag("Coin"))
        {
            pointsCollected++; //Lis‰t‰‰n yksi piste lis‰‰
            text_Points.text = pointsCollected.ToString(); //P‰ivitet‰‰n UI tekstikentt‰
            Destroy(collision.gameObject); //Tuhotaan ker‰tty kolikko
        }
    }

}
