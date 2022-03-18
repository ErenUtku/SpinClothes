using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMovement : Movement
{
    private LevelManager levelmanager;

    [HideInInspector]
    public bool gameFinished=false;

    /*------------------------------------------------------------------------------------------------------------------*/

    private void Awake()
    {
        levelmanager = FindObjectOfType<LevelManager>();
    }

    private void FixedUpdate()
    {
        if (gameFinished == false)
        {
            if (Input.GetMouseButtonDown(0) || Input.GetMouseButton(0))
            {
                levelmanager.StartTheGame();
                Move(Vector3.forward);
            }

            if (Input.GetMouseButtonUp(0))
                Move(Vector3.zero);
        }

        else
        {
            Move(Vector3.forward);
        }
       
    }
   
}
