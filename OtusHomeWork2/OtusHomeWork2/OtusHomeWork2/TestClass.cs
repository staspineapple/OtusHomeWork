using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OtusHomeWork2
{
    [Serializable]
    public class TestClass: ISerializable
    {
        public TestClass(int a, string b, int c, string d) 
        {
            varOne = a;
            varTwo = b;
            varThree = c;
            varFour = d;
        }
        public TestClass() { }

        public int varOne { get; set; }

        public string varTwo { get; set; }

        public int varThree { get; set; }

        public string varFour { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("varOne", this.varOne);
            info.AddValue("varTwo", this.varTwo);
            info.AddValue("varThree", this.varThree);
            info.AddValue("varFour", this.varFour);
        }

        public TestClass(SerializationInfo info, StreamingContext context)
        {
            this.varOne = (int)info.GetValue("varOne", typeof(int));
            this.varTwo = (string)info.GetValue("varTwo", typeof(string));
            this.varThree = (int)info.GetValue("varThree", typeof(int));
            this.varFour = (string)info.GetValue("varFour", typeof(string));
        }

        public override string ToString()
        {
            return $"1: {varOne}; 2: {varTwo}; 3: {varThree}; 4: {varFour};";
        }

     }

}
