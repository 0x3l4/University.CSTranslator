﻿namespace University.CSharpTranslator.LexicalAnalysis
{
    public static class Keywords
    {
        public static readonly HashSet<string> ReservedKeywords = new()
        {
            "abstract", "as", "base", "bool",
            "break", "byte", "case", "catch",
            "char", "checked", "class","const",
            "continue","decimal","default","delegate",
            "do","double","else","enum",
            "event","explicit","extern","false",
            "finally","fixed","float","for",
            "foreach","goto","if","implicit",
            "in","int","interface","internal",
            "is","lock","long","namespace",
            "new","null","object","operator",
            "out","override","params","private",
            "protected","public","readonly","ref",
            "return","sbyte","sealed","short",
            "sizeof","stackalloc","static","string",
            "struct","switch","this","throw",
            "true","try","typeof","uint",
            "ulong","unchecked","unsafe","ushort",
            "using","virtual","void","volatile",
            "while"
        };

        public static readonly HashSet<string> ContextualKeywords = new()
        {
            "add", "and","alias","ascending",
            "args","async","await","by",
            "descending","dynamic","equals","from",
            "get","global","group","init","into",
            "join","let","managed","nameof",
            "nint","not","notnull","nuint",
            "on","orderby","partial","record",
            "remove","select","set","unmanaged",
            "value","var","when","where",
            "where","with","yield"
        };
    }
}
