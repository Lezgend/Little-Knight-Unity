using UnityEngine;
using UnityEngine.UI;
using System.Collections;
/// <summary>
/// HP & MP Manager
/// </summary>
public class HpManager : MonoBehaviour {
    // HP bar
    public Slider hpBar;

    // Max State 
    public int hpMax = 100;

    // Current State
    public static int hp = 60;

    // Init HP State
    public void InitHp()
    {
        SetHp(hpMax);
    }

    // Set Damage on HP State
    public void DoDamageHp(int point)
    {
        SetHp(hp - point);
    }

    // Set Recover on HP State
    public void DoSaveHp(int point)
    {
        SetHp(hp + point);
    }

    // Set HP State
    public void SetHp(int point)
    {
        hp = Mathf.Clamp(point, 0, hpMax);
        if (hpBar)
            hpBar.value = (float)hp / (float)hpMax;
    }

}
