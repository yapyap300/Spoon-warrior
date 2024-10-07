using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAI : MonoBehaviour
{
    private Enemy boss;
    private BTRunner runner;

    void Awake()
    {
        boss = GetComponent<Enemy>();
        runner = new BTRunner(boss.SetTree());
    }
    void Update()
    {
        runner.Operater();
    }
}
