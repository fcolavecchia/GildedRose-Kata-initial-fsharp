module GildedRose.ApprovalTests

open System
open System.Text
open System.IO

open NUnit.Framework

[<Test>]
let ``Thirty day report is correct`` () =
    let expected = File.ReadAllText "GildedRoseTest.ApprovalTest.ThirtyDays.received.txt"

    let fakeoutput = new StringBuilder()
    Console.SetOut(new StringWriter(fakeoutput))
    Console.SetIn(new StringReader("a\n"))

    GildedRose.Program.main [||] |> ignore
    let actual = fakeoutput.ToString()

    File.WriteAllText ("GildedRoseTest.ApprovalTest.ThirtyDays.actual.txt", actual) 
    
    Assert.AreEqual(expected, actual)
