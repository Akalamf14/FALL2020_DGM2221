﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseDownBehaviour : MonoBehaviour
{
   public UnityEvent mouseDownEvent;


  private void OnMouseDown()
  {
    mouseDownEvent.Invoke();
  }
}
