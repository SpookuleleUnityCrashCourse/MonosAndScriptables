using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMono : MonoBehaviour
{

    public float characterAttackStat;
    public TestSO testSO;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
            testSO.attackBuff += 10;
        
        float totalDamage = testSO.baseDamage * characterAttackStat + testSO.attackBuff;
        
        Debug.Log("Total damage of this weapon is " + totalDamage);
    }
}
