using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
	private float m_Health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

	public void TakeDamage(float damage)
	{
		m_Health = m_Health - damage;
		if (m_Health <= 0)
		{
			Destroy(this.gameObject);
		}
	}
}
