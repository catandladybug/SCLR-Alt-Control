using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody rb;
    public bool attackWindowOpen = false;
    public int enemyWeakness;
    public bool enemyAttacked = false;
    public TextMeshProUGUI attackInput;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        enemyWeakness = Random.Range(1, 4);
    }

    private void Update()
    {
        if (attackWindowOpen)
        {
            if (Input.GetKey(KeyCode.Alpha1))
            {
                if(enemyWeakness == 1)
                    enemyAttacked = true;
                attackInput.text = "1!";
            }
            else if (Input.GetKey(KeyCode.Alpha2))
            {
                if (enemyWeakness == 2)
                    enemyAttacked = true;
                attackInput.text = "2!";
            }
            else if (Input.GetKey(KeyCode.Alpha3))
            {
                if (enemyWeakness == 3)
                    enemyAttacked = true;
                attackInput.text = "3!";
            }
            else if (Input.GetKey(KeyCode.Alpha4))
            {
                if (enemyWeakness == 4)
                    enemyAttacked = true;
                attackInput.text = "4!";
            }
        }
        if (Input.GetKey(KeyCode.Space) && speed < 70)
            speed += .1f;
        else if (speed > 20)
            speed -= .1f;
    }

    void FixedUpdate()
    {
        movePlayer();
    }

    void movePlayer()
    {
        rb.velocity = new Vector3(0, 0, speed);
    }
}
