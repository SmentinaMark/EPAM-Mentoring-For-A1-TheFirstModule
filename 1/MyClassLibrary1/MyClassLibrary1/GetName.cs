using System;

namespace MyClassLibrary1
{
    public class GetName
    {
        public string Name { get; set; }
        public GetName(string name = "Empty string")
        {
            Name = name;
        }
        public string GetNameMethod()
        {
            return $"{DateTime.Now.ToString("hh:mm:ss")} | Hello, {Name}";
        }
    }
}
