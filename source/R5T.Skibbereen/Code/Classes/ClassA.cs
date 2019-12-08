using System;


namespace R5T.Skibbereen
{
    public class ClassA
    {
        public const string ValueA = "A";


        public string Value { get; set; }


        public ClassA(string value)
        {
            this.Value = value;
        }

        public ClassA()
            : this(ClassA.ValueA)
        {
        }
    }
}
