using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoveHV : CharacterBehaviour1
{
    protected override void OnHorizontal()
    {
        hInput = Input.GetAxis("Horizontal") * moveSpeed.value;
        movement.Set(vInput,yVar,hInput);
    }
}
