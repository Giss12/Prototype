using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public interface ICommand
    {
        void Invoke();
        void Undo();
    }
    public class MoveForward : ICommand
    {
        Transform transform {get;set;}
        float dist {get;set;}
        public void Invoke()
        {
            transform.Translate(transform.forward * dist);
        }
        public void Undo()
        {
            transform.Translate(transform.forward * -dist);
        }
    }
    public class Rotate : ICommand
    {
        Transform transform {get;set;}
        float angle {get;set;}
        public void Invoke()
        {
            transform.Rotate(transform.forward * angle);
        }
        public void Undo()
        {
            transform.Rotate(transform.forward * -angle);
        }
    }
