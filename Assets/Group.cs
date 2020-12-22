using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Group : ICloneable
{
    public int Course;
    public string Spec;

    public object Clone()
    {
        return this.MemberwiseClone();
    }
}
