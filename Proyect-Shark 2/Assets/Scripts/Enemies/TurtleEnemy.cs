using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleEnemy : Enemy
{ private void Update() {
    base.Move();
}
    protected override void Move()
    {
        transform.Translate(Vector3.forward * enemyStats.speed * Time.deltaTime);
    }
}
