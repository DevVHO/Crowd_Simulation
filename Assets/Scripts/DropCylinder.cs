using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropCylinder : MonoBehaviour
{
    public GameObject  Obstacles;
        GameObject [] Agents ;

    // Start is called before the first frame update
    void Start()
    {
        Agents = GameObject.FindGameObjectsWithTag("agent");
    }
    // Update is called once per frame
    void Update()
    {
         if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray.origin, ray.direction, out hitInfo))
            {
                Instantiate(Obstacles, hitInfo.point, Obstacles.transform.rotation);
                foreach(GameObject a in Agents)
                {
                    a.GetComponent<AIControl>().DetectNewObstacle(hitInfo.point);
                }
            }
        }
    }
}
