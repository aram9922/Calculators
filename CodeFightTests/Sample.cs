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
            almostIncreasingSequence(new int[] { 1, 3, 2 });
        }
        bool almostIncreasingSequence(int[] sequence)
        {
            int error = 0;
            bool error1 = false;
            bool error2 = false;
            for (int i = 0; i <= sequence.Length - 1; i++)
            {
                if (sequence[i] > sequence[i + 1] && error != 1)
                {
                    error = error + 1;
                    if (error1 = sequence[i - 1] < sequence[i + 1])
                    {
                        ;
                        continue;
                    }
                    if (error2 = sequence[i] < sequence[i + 2])
                    {
                        ;
                        continue;
                    }
                    if (!(error1 || error2))
                    {
                        return false;
                    }
                }
                else if (sequence[i] < sequence[i + 1])
                {
                    continue;
                }
                else { return false; }
            }
        }
    }
}

