using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DataStructures
{
    public class SequenceListTest
    {
        [SetUp]
        public void Setup()
        {
            System.Console.WriteLine("Setup");
        }

        [Test]
        public void Test1()
        {
            SequenceList<int> sequenceList = new SequenceList<int>(5);
            sequenceList.Add(1);
            sequenceList.Add(2);
            sequenceList.Add(3);
            sequenceList.Add(4);
            sequenceList.Add(5);
            for (int i = 0; i < sequenceList.GetLength; i++)
            {
                Console.WriteLine(sequenceList[i]);
            }

            System.Console.WriteLine("________________________");
            int removeInt =  sequenceList.RemoveAt(2);
            System.Console.WriteLine(removeInt);

            System.Console.WriteLine("________________________");

            sequenceList.Insert(2, 6);
            for (int i = 0; i < sequenceList.GetLength; i++)
            {
                Console.WriteLine(sequenceList[i]);
            }
        }
    }
}