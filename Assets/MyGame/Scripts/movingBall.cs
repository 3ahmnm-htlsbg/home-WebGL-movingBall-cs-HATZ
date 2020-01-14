using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingBall : MonoBehaviour
{

    public GameObject ball;
    [SerializeField] private GameObject[] ballPositions;

    private int GenerateNumber()
    {
        return Random.Range(0,4);
    }

  public void TranslateBall()
    {
       ball.transform.position = ballPositions[GenerateNumber()].transform.position;
    }
}