using System.Text.Json;

using SimpleC.Base;
using SimpleC.Lexer;
using SimpleC.Main;

// See https://aka.ms/new-console-template for more information

Console.WriteLine("This is a basic test of the C compiler...");

var grammarFile = "C:\\Backup\\_Source\\Git\\SimpleC\\c-grammar.json";
var grammarJson = File.ReadAllText(grammarFile);
var grammar = JsonSerializer.Deserialize<LexigraphicalGrammar>(grammarJson);

var compiler = new CCompiler(grammar);
compiler.CompilerEvent += (args) =>
{
    Console.WriteLine("Compiler Event:  " + args.ToString());
};

//compiler.Parse();