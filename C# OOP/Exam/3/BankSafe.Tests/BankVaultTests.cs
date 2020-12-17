using NUnit.Framework;
using System;

namespace BankSafe.Tests
{
    public class BankVaultTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ItemCtorWork()
        {
            Item item = new Item("gosho", "id");

            Assert.AreEqual("gosho", item.Owner);
            Assert.AreEqual("id", item.ItemId);
        }

        [Test]
        public void BankAddNotWork()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Item item = new Item("gosho", "id");
                BankVault bank = new BankVault();
                bank.AddItem("neshto", item);
            });
        }

        [Test]
        public void BankAddNullCellWork()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Item item = new Item("gosho", "id");
                Item item2 = new Item("pesho", "id");
                BankVault bank = new BankVault();
                bank.AddItem("A1", item);
                bank.AddItem("A1", item2);

            });
        }

        [Test]
        public void BankAddCellIDWork()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                Item item = new Item("gosho", "id");
                Item item2 = new Item("pesho", "id");
                BankVault bank = new BankVault();
                bank.AddItem("A1", item);
                bank.AddItem("A2", item2);

            });
        }

        [Test]
        public void BankAddWork()
        {
            Item item = new Item("gosho", "id");
            BankVault bank = new BankVault();
            Assert.AreEqual($"Item:{item.ItemId} saved successfully!", bank.AddItem("A1", item));

        }

        [Test]
        public void BankRemoveNotWork()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Item item = new Item("gosho", "id");
                BankVault bank = new BankVault();
                bank.AddItem("A1", item);
                bank.RemoveItem("neshto", item);
            });
        }

        [Test]
        public void BankRemoveNotWork2()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Item item = new Item("gosho", "id");
                BankVault bank = new BankVault();
                bank.AddItem("A1", item);
                bank.RemoveItem("A2", item);
            });
        }

        [Test]
        public void BankRemoveWork()
        {
            Item item = new Item("gosho", "id");
            BankVault bank = new BankVault();
            bank.AddItem("A1", item);

            Assert.AreEqual($"Remove item:{item.ItemId} successfully!", bank.RemoveItem("A1", item));
        }
    }
}