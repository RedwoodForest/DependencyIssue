using System;
using System.Reflection;
using Lextm.SharpSnmpLib;

namespace DependencyIssue {
    public class Program {
        static void Main() {
            Console.Out.WriteLine(typeof(ObjectIdentifier).GetCustomAttributes(typeof(Attribute)));
            Console.ReadLine();
        }
    }
}
