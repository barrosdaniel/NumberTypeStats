string[] types = {"sbyte", "byte", "short", "ushort", "int", "uint", "long",
    "ulong", "float", "double", "decimal"};

// Generate table header
string tableHeaderBorder = String.Format("{0,-8} {1,-8} {2,-36} {3,-36}",
                                         "--------",
                                         "--------",
                                         "------------------------------------",
                                         "------------------------------------");
string tableHeader = String.Format("{0,-8} {1,-8} {2,-36} {3,-36}", "Type", "Bytes", "Min", "Max");

// Print table header
WriteLine(tableHeaderBorder);
WriteLine(tableHeader);
WriteLine(tableHeaderBorder);
WriteLine("{0,-8} {1,-8} {2,36} {3,36}", "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
WriteLine("{0,-8} {1,-8} {2,36} {3,36}", "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
WriteLine("{0,-8} {1,-8} {2,36} {3,36}", "short", sizeof(short), short.MinValue, short.MaxValue);
WriteLine("{0,-8} {1,-8} {2,36} {3,36}", "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
WriteLine("{0,-8} {1,-8} {2,36} {3,36}", "int", sizeof(int), int.MinValue, int.MaxValue);
WriteLine("{0,-8} {1,-8} {2,36} {3,36}", "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
WriteLine("{0,-8} {1,-8} {2,36} {3,36}", "long", sizeof(long), long.MinValue, long.MaxValue);
WriteLine("{0,-8} {1,-8} {2,36} {3,36}", "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
WriteLine("{0,-8} {1,-8} {2,36} {3,36}", "float", sizeof(float), float.MinValue, float.MaxValue);
WriteLine("{0,-8} {1,-8} {2,36} {3,36}", "double", sizeof(double), double.MinValue, double.MaxValue);
WriteLine("{0,-8} {1,-8} {2,36} {3,36}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
WriteLine(tableHeaderBorder);
