module GildedRose.UnitTests.Tests 

open GildedRose
open System.Collections.Generic
open NUnit.Framework

open GildedRose.UnitTests.Items 


[<Test>]
let ``My test`` () =
    let Items = new List<Item>()  
    Items.Add({Name = "foo"; SellIn = 0; Quality = 0})
    let app = new GildedRose(Items)
    app.UpdateQuality()
    
    let expectedItem = {Name = "foo"; SellIn = -1; Quality = 0}
    
    Assert.AreEqual(expectedItem,Items[0])
    

[<Test>]
let ``Dexterity vest`` () =
    let Items = new List<Item>()  
    Items.Add({Name = "+5 Dexterity Vest"; SellIn = 10; Quality = 20})
    let app = new GildedRose(Items)
    app.UpdateQuality()
    
    let expectedItem = {Name = "+5 Dexterity Vest"; SellIn = 9; Quality = 19}
    
    Assert.AreEqual(expectedItem,Items[0])
    
