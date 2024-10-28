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
    public bool disabled = true;
    public int wrongMoves;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        enemyWeakness = Random.Range(1, 5);
    }

    private void Update()
    {
        if (!disabled)
        {
            if(attackWindowOpen)
            {
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    if (enemyWeakness == 1)
                    {
                        enemyAttacked = true;
                        attackInput.color = Color.green;
                    }
                    attackInput.text = "1!";
                    attackWindowOpen = false;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    if (enemyWeakness == 2)
                    {
                        enemyAttacked = true;
                        attackInput.color = Color.green;
                    }
                    attackInput.text = "2!";
                    attackWindowOpen = false;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    if (enemyWeakness == 3)
                    {
                        enemyAttacked = true;
                        attackInput.color = Color.green;
                    }
                    attackInput.text = "3!";
                    attackWindowOpen = false;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha4))
                {
                    if (enemyWeakness == 4)
                    {
                        enemyAttacked = true;
                        attackInput.color = Color.green;
                    }
                    attackInput.text = "4!";
                    attackWindowOpen = false;
                }
            }
            if (Input.GetKey(KeyCode.Space) && speed < 70)
                speed += .01f;
            else if (speed > 20)
                speed -= .01f;
        }
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
