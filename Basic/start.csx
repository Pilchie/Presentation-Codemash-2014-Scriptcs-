#load "greeter.csx"

using System.Net.Http;

var greeter = new Greeter();
greeter.Greet(ScriptArgs[0]);
