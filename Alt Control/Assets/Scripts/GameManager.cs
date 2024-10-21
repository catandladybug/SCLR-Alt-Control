using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerController player;
    public Enemy enemy;
    public TextMeshProUGUI attackPrompt;
    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        player = Object.FindFirstObjectByType<PlayerController>();
        enemy = Object.FindFirstObjectByType<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(player.transform.position, enemy.transform.position);
        if (!player.attackWindowOpen && distance < 200f)
        {
            player.attackWindowOpen = true;
            attackPrompt.text = "Press " + player.enemyWeakness;
            Invoke("End", 2f);
        }
    }

    void End()
    {
        if(!player.enemyAttacked)
            attackPrompt.text = "You Lose!";
        else
            attackPrompt.text = "You Win!";
    }
}
