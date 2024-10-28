using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    public PlayerController player;
    public float points;
    bool pointsCalcd;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        SetPlayer();
    }

    private void Update()
    {
        if(player.enemyAttacked)
        {
            points = player.speed * 100f;
            points = Mathf.Ceil(points);
        }
        else
        {
            points = 0;
        }
    }

    public void SetPlayer()
    {
        player = Object.FindFirstObjectByType<PlayerController>();
    }
}
