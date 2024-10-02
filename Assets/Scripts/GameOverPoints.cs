using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverPoints : MonoBehaviour
{
	public int finalPoints;
	public TextMeshProUGUI pointsText;


	public void FinalPoints()
	{
		//find points tracker object and get the final points to display
		finalPoints = GameObject.Find("PointsTracker").GetComponent<PointsTracker>().totalPoints;
		pointsText.text = "Game Over! \n Points: " + finalPoints.ToString();
	}
}
