string[] types = {"sbyte", "byte", "short", "ushort", "int", "uint", "long",
    "ulong", "float", "double", "decimal"};

// Print table header
string tableHeader = String.Format("{0,-8} {1,-8} {2,-40} {3,-40}", "Type", "Bytes", "Min", "Max");

WriteLine(tableHeader);

decimal typeMax = Decimal.MaxValue;
WriteLine(typeMax);
string typeMaxString = typeMax + "";
WriteLine(typeMaxString.Length);