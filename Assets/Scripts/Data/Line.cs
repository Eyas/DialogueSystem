﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Line
{
    public enum Expression { Idle, Smile, Angry }; // adjust sesuai kebutuhan nanti

    //public Character character;
    public Expression expression;
    [TextArea(2, 5)]
    public string text;

}
