using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student : ICloneable
{
    public string firstname { get; set; }
    public string lastname { get; set; }
    public int age { get; set; }
    public Group groupname { get; set; }

    public object Clone()
    {
        return new Student { firstname = this.firstname, lastname = this.lastname, age = this.age, groupname = (Group)this.groupname.Clone() };
    }
}

