using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Vsite.CSharp.Metode.Testovi
{
    [TestClass]
    public abstract class ConsoleTest
    {
        protected class ConsoleTestWriter : StringWriter
        {
            public override void WriteLine(string? text)
            {
                output.Enqueue(text);
            }

            public override void WriteLine(int number)
            {
                output.Enqueue(number);
            }

            public override void WriteLine(double number)
            {
                output.Enqueue(number);
            }

            public override void WriteLine(object? obj)
            {
                output.Enqueue(obj?.ToString());
            }

            public string? GetString()
            {
                return (string?)output.Dequeue();
            }

            public int? GetInt()
            {
                return (int?)output.Dequeue();
            }

            public double? GetDouble()
            {
                return (double?)output.Dequeue();
            }

            public object? GetObject()
            {
                return output.Dequeue();
            }

            public bool IsEmpty
            {
                get { return output.Count == 0; }
            }

            public int Count
            {
                get { return output.Count; }
            }

            public override void Write(string? text)
            {
                output.Enqueue(text);
            }

            Queue output = new Queue();
        }

        protected class ConsoleTestReader : StringReader
        {
            public ConsoleTestReader(string s) : base(s)
            {
                Push(s);
            }

            public override string ReadLine()
            {
                return input.Dequeue();
            }

            public void Push(string s)
            {
                if (s.Length > 0)
                    input.Enqueue(s);
            }

            Queue<string> input = new Queue<string>();
        }

        protected ConsoleTestWriter? cw = null;
        protected ConsoleTestReader? cr = null;

        [TestInitialize()]
        public virtual void Initialize()
        {
            cw = new ConsoleTestWriter();
            cr = new ConsoleTestReader("");
            Console.SetOut(cw);
            Console.SetIn(cr);
        }

        [TestCleanup()]
        public virtual void Cleanup()
        {
            cw?.Dispose();
            cr?.Dispose();
        }
    }
}
