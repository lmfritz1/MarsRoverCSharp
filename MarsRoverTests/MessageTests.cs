using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover;

namespace MarsRoverTests
{
    [TestClass]
    public class MessageTests
    {
        Command[] commands = { new Command("foo", 0), new Command("bar", 20) };
        //Test5
        [TestMethod]
        public void ArgumentNullExceptionThrownIfNameNotPassedToConstructor()
        {
            try
            {
                new Message("New Rover", commands);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Message required.", ex.Message);
            }
        }

        //Test6

        [TestMethod]
        
        public void ConstructorSetsName ()
        {
            Message message1 = new Message("Linford", commands);
            Assert.IsTrue("Linford" == message1.Name);
            Assert.AreEqual("Linford", message1.Name);
        }

        //Test7
        [TestMethod]
        public void ConstructorSetsCommandsField()
        {
            Message message1 = new Message("Linford", commands);
            Assert.AreEqual(commands, message1.Commands);
        }
    }
}
