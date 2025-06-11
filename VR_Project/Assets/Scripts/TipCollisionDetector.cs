using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCollisionDetector : MonoBehaviour
{
    [Header("可在 Inspector 中修改的伤害值或ID")]
    public int damage = 1;
    public string hitSignal = "OnHitByProjectile";

    private bool hasHit = false;

}
