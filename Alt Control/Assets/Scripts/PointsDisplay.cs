using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointsDisplay : MonoBehaviour
{
    public PointManager pointManager;
    public TextMeshProUGUI textBox;
    void Start()
    {
        pointManager = Object.FindFirstObjectByType<PointManager>();
        textBox.text = pointManager.points.ToString() + " Points!";
    }
}
