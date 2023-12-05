using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XAttackArea : MonoBehaviour
{
    private int damage = 10;

    private int dmgType()
    {
        if(this.tag == "SideAttack")
            return 9;
        return 6;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.GetComponent<CartiHealth>() != null)
        {
            CartiHealth health = collider.GetComponent<CartiHealth>();
            health.Damage(dmgType());
        }
        else if(collider.GetComponent<TravisHealth>() != null)
        {
            TravisHealth health = collider.GetComponent<TravisHealth>();
            health.Damage(dmgType());
        }
        else if(collider.GetComponent<XHealth>() != null)
        {
            XHealth health = collider.GetComponent<XHealth>();
            health.Damage(dmgType());
        }
        else if(collider.GetComponent<UziHealth>() != null)
        {
            UziHealth health = collider.GetComponent<UziHealth>();
            health.Damage(dmgType());
        }
    }
}
