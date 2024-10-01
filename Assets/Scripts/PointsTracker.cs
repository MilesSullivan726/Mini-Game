using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsTracker : MonoBehaviour
{
    public int totalPoints = 0;
    public TextMeshProUGUI pointsText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdatePoints(int points)
    {
       
        totalPoints += points;
        Debug.Log(totalPoints);
		pointsText.text = "Points: " + totalPoints.ToString();
	}
}
