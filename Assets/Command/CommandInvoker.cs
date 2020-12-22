using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker : MonoBehaviour
{
    Queue<ICommand> comands= new Queue<ICommand>();
    Stack<ICommand> numbers = new Stack<ICommand>();
    public void AddCommand(ICommand icom)
    {
        comands.Enqueue(icom);
    }
    public void ProccesAll()
    {
        while(comands.Count != 0)
        {
            comands.Dequeue();
        }
    }
    public void Procces()
    {
        ICommand com = comands.Dequeue();
        com.Invoke();
        numbers.Push(com);
    }
    public void Undo()
    {
        numbers.Pop().Undo();
    }
    public void ClearQueue()
    {
        numbers.Clear();
    }
}