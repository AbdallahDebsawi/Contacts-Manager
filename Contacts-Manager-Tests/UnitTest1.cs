using System;
using System.Collections.Generic;
using Xunit;
using Contacts_Manager;

namespace Contacts_Manager_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddContact()
        {
            // Arrange
            Program.contacts.Clear();

            //Act
            var updatedContacts = Program.AddContact("Abdallah Debsawi");

            // Assert
            Assert.Contains("Abdallah Debsawi", updatedContacts);
        }

        [Fact]
        public void TestRemoveContact()
        {
            // Arrange
            Program.contacts.Clear();

            // Act
            Program.AddContact("Abdallah Debsawi");
            var updatedContacts = Program.RemoveContact("Abdallah Debsawi");

            // Assert
            Assert.DoesNotContain("Abdallah Debsawi", updatedContacts);
        }

        [Fact]
        public void TestViewAllContacts()
        {
            // Arrange
            Program.contacts.Clear();

            // Act
            Program.AddContact("Abdallah Debsawi");
            Program.AddContact("dodo");
            var contacts = Program.ViewAllContacts();

            // Assert
            Assert.Contains("Abdallah Debsawi", contacts);
            Assert.Contains("dodo", contacts);
        }

        [Fact]
        public void TestAddDuplicateContact()
        {
            // Arrange
             Program.contacts.Clear();

            // Act
            Program.AddContact("Abdallah Debsawi");
            var updatedContacts = Program.AddContact("Abdallah Debsawi");

            // Assert
            Assert.Single(updatedContacts);
        }
    }
}