module GildedRose.UnitTests.Items

open GildedRose

// Some items that can be used in tests ... or not

let normal = {Name = "+5 Dexterity Vest"; SellIn = 10; Quality = 20}
let agedBrie = {Name = "Aged Brie"; SellIn = 2; Quality = 0}
let elixir = {Name = "Elixir of the Mongoose"; SellIn = 5; Quality = 7}
let sulfuras = {Name = "Sulfuras, Hand of Ragnaros"; SellIn = 0; Quality = 80}
let sulfurasSoldOut = {Name = "Sulfuras, Hand of Ragnaros"; SellIn = -1; Quality = 80}
let backstagePass = {Name = "Backstage passes to a TAFKAL80ETC concert"; SellIn = 15; Quality = 20}
let backstagePass10days = {Name = "Backstage passes to a TAFKAL80ETC concert"; SellIn = 10; Quality = 49}
let backstagePass5days = {Name = "Backstage passes to a TAFKAL80ETC concert"; SellIn = 5; Quality = 49}
let backstagePassAfterOnDate = {Name = "Backstage passes to a TAFKAL80ETC concert"; SellIn = 0; Quality = 49}
let conjured = {Name = "Conjured Mana Cake"; SellIn = 3; Quality = 6}