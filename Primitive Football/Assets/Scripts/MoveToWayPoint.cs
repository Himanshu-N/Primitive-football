using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToWayPoint : MonoBehaviour
{
    public List<GameObject> WayPoints;
    int index = 0;
    [SerializeField] float speedOfWay = 5;
    
    void Update()
    {
        Vector3 DestinationPoint = WayPoints[index].transform.position;
        Vector3 newPos = Vector3.MoveTowards(transform.position, DestinationPoint, speedOfWay * Time.deltaTime);
        transform.position = newPos;

        if (Vector3.Distance(DestinationPoint, newPos) <= 0.01)
        {
            index++;
            if ((index == 2) && (SceneManager.GetActiveScene().buildIndex <= 3))
            {
                index = 0;
            }
            else if(index == 3)
            {
                index = 0;
            }
        }

    }
}
