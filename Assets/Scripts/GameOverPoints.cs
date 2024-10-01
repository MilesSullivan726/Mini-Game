using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverPoints : MonoBehaviour
{
	public int finalPoints;
	public TextMeshProUGUI pointsText;

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void FinalPoints()
	{

		finalPoints = GameObject.Find("PointsTracker").GetComponent<PointsTracker>().totalPoints;
		pointsText.text = "Game Over! \n Points: " + finalPoints.ToString();
	}
}
