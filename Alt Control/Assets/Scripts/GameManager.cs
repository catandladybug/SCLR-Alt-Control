using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public PlayerController player;
    public PointManager pointManager;
    float playerSpeed;
    float enemySpeed;
    public Enemy enemy;
    public TextMeshProUGUI attackPrompt;
    public TextMeshProUGUI countdownText;
    public float distance;
    public int count = 4;
    bool windowOpened = false;
    // Start is called before the first frame update
    void Start()
    {
        player = Object.FindFirstObjectByType<PlayerController>();
        enemy = Object.FindFirstObjectByType<Enemy>();
        pointManager = Object.FindFirstObjectByType<PointManager>();
        pointManager.SetPlayer();
        
        playerSpeed = player.speed;
        player.speed = 0f;
        enemySpeed = enemy.speed;
        enemy.speed = 0f;
        Countdown();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(player.transform.position, enemy.transform.position);
        if (!player.attackWindowOpen && distance < 200f && !windowOpened)
        {
            player.attackWindowOpen = true;
            windowOpened = true;
            attackPrompt.text = "Press " + player.enemyWeakness;
            Invoke("End", 2f);
        }
    }

    void End()
    {
        if (!player.enemyAttacked)
            attackPrompt.text = "You Lose!";
        else
            attackPrompt.text = "You Win!";
        Invoke("LoadNextScene", 1f);
    }

    void Countdown()
    {
        count--;
        if (count == 0)
        {
            CountdownFinal();
            return;
        }
        countdownText.text = count.ToString();
        if (count > 0)
        {
            Invoke("Countdown", 1f);
        }
    }

    void CountdownFinal()
    {
        countdownText.text = "Go!";
        player.speed = playerSpeed;
        player.disabled = false;
        enemy.speed = enemySpeed;
        Invoke("CountdownClear", 1f);
    }

    void CountdownClear()
    {
        countdownText.text = "";
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
