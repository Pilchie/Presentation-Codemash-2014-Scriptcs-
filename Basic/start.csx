#load "greeter.csx"

#r "System.Net.Http"
using System.Net.Http;

var greeter = new Greeter();
greeter.Greet(ScriptArgs[0]);
