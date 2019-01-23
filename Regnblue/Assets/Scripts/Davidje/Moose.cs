using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moose : MonoBehaviour
{
	[SerializeField] private Transform m_PlayerTransform;
	[SerializeField] private List<Transform> m_WayPoints;
	[SerializeField] private int m_CurrentWaypointGoal;
	[SerializeField] private float m_Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x - m_PlayerTransform.position.x <= 0.5f && transform.position.z - m_PlayerTransform.position.z <= 0.5f)
		{
			transform.position = Vector3.MoveTowards(transform.position, m_WayPoints[m_CurrentWaypointGoal].position , m_Speed * Time.deltaTime);
		}
		WayPointChecking();
    }

	private void WayPointChecking()
	{
		if(transform.position.x  == m_WayPoints[0].position.x && transform.position.z == m_WayPoints[0].position.z && m_CurrentWaypointGoal == 0)
		{
			m_CurrentWaypointGoal = 1;
		}
		else if (transform.position.x == m_WayPoints[1].position.x && transform.position.z == m_WayPoints[1].position.z && m_CurrentWaypointGoal == 1)
		{
			m_CurrentWaypointGoal = 2;
		}
		else if (transform.position.x == m_WayPoints[2].position.x && transform.position.z == m_WayPoints[2].position.z && m_CurrentWaypointGoal == 2)
		{
			m_CurrentWaypointGoal = 3;
		}
		else if (transform.position.x == m_WayPoints[3].position.x && transform.position.z == m_WayPoints[3].position.z && m_CurrentWaypointGoal == 3)
		{
			//m_CurrentWaypointGoal = 4;
		}
	}
}
