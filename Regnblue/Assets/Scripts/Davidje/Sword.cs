using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AxeState
{
	Ready,
	NotReady
}

public class Sword : MonoBehaviour
{
    private Animator m_Animator;
	private AxeState m_AxeState;
	private float m_OriginalTimer;
	private float m_Timer;
	private bool m_CurrentlyActive;
	private float m_Damage;
	public void SetTrapState(AxeState trapState)
	{
		m_AxeState = trapState;
	}

	private void Start()
	{
		m_Animator = GetComponent<Animator>();
	}

	private void Update()
	{
		if (!m_CurrentlyActive)
		{
			m_Timer = m_Timer - Time.deltaTime;
		}
		if (m_Timer <= 0 && Input.GetMouseButtonDown(0))
		{
			m_Timer = 1;
			m_CurrentlyActive = true;
			SetTrapState(AxeState.NotReady);
		}
		m_Animator.SetInteger("State", (int)m_AxeState);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Enemy") && m_CurrentlyActive)
		{
			Debug.Log("hallo");
			EnemyHealth enemyHit = other.GetComponent<EnemyHealth>();
			enemyHit.TakeDamage(m_Damage);
			m_Timer = 1;
			SetTrapState(AxeState.Ready);
			m_CurrentlyActive = false;
			Debug.Log("Hallo2");
		}
	}
}
