using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
//using SimpleJson.Reflection;
using System.Text.RegularExpressions;
using System.Linq;

namespace CodeFightTests
{
    [TestClass]
    public class Sample
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        int makeArrayConsecutive2(int[] statues)
        {
            int result = 0;
            int min = statues[0];
            for (int i = 0; i <= statues.Length - 1; i++)
            {
                if (statues[i] < min)
                {
                    min = statues[i];
                }
            }
            int max = statues[0];
            for (int i = 0; i <= statues.Length - 1; i++)
            {
                if (statues[i] > max)
                {
                    max = statues[i];
                }
            }
            for (int i = min; i < max; i++)
            {
                bool b = Array.Exists(statues, x => x == min + i);
                if (!b)
                {
                    result = result + 1;
                }
            }
            return result;
        }
    }
}
