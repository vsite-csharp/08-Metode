using System.Collections;

namespace Vsite.CSharp.Metode.Testovi
{
    [TestClass]
    public abstract class ConsoleTest
    {
        protected class ConsoleTestWriter : StringWriter
        {
            public override void WriteLine(string? value)
            {
                output.Enqueue(value);
            }

            public override void WriteLine(int value)
            {
                output.Enqueue(value);
            }

            public override void WriteLine(double value)
            {
                output.Enqueue(value);
            }

            public override void WriteLine(object? value)
            {
                output.Enqueue(value?.ToString());
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

            private readonly Queue<string> input = new Queue<string>();
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
