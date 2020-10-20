using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoveHV : CharacterBehaviour
{
    protected override void OnHorizontal()
    {
        hInput = Input.GetAxis("Horizontal") * moveSpeed.value;
    }
}
