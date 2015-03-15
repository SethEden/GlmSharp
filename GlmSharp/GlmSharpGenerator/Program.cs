﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlmSharpGenerator
{
    class Program
    {
        public static readonly Dictionary<string, TypeBase> Types = new Dictionary<string, TypeBase>();

        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: path/to/gen-folder/");
                return;
            }
            var path = args[0];

            Console.WriteLine("GlmSharp Generator");
            foreach (var type in BaseTypeInfo.Types)
                for (var comp = 2; comp <= 4; ++comp)
                {
                    var vect = new VectorType
                    {
                        Name = type.Prefix + "vec",
                        Components = comp,
                        BaseTypeInfo = type,
                        BaseType = type.Name
                    };
                    var swizzler = vect.SwizzleType;
                    Types.Add(vect.ClassName, vect);
                    Types.Add(swizzler.ClassName, swizzler);
                }

            Console.WriteLine();
            Console.WriteLine("Types:");
            foreach (var type in Types.Keys)
                Console.WriteLine("    " + type);

            Console.WriteLine();
            Console.WriteLine("Generate:");
            foreach (var type in Types.Values)
            {
                var filename = Path.Combine(path, type.ClassName + ".cs");
                File.WriteAllLines(filename, type.CSharpFile);
                Console.WriteLine("    " + filename);
            }
        }
    }
}