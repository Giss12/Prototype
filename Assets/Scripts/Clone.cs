using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clone : MonoBehaviour
{
    void Start()
    {
        Group gr = new Group { Course = 1 };
        Student s1 = new Student { firstname = "Ivan", lastname = "Ivanov", age = 18, groupname =  gr};
        Student s2 = (Student)s1.Clone();
        s2.groupname.Course = 2;
        Debug.Log(s2.groupname.Course);
        Debug.Log(s1.groupname.Course);

    }
}