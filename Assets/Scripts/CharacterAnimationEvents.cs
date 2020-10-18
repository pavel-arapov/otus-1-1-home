using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationEvents : MonoBehaviour
{
    Character character;

    void Start()
    {
        character = GetComponentInParent<Character>();
    }

    void ShootEnd()
    {
        character.SetState(Character.State.Idle);
        character.KillEnemy();
    }

    void AttackEnd()
    {
        character.SetState(Character.State.RunningFromEnemy);
        character.KillEnemy();
    }
}
