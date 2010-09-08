//  Koffeinfrei Batch Replacer
//  Copyright (C) 2010  Alexis Reigel
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.IO;
using Koffeinfrei.BatchReplacer.Model;
using Koffeinfrei.BatchReplacer.Model.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Koffeinfrei.BatchReplacer.Tests
{
    [TestClass]
    public class ReplacerTests
    {
        private string outputFile;
        private Replacer replacer;
        public TestContext TestContext { get; set; }
        
        [TestInitialize]
        public void Setup()
        {
            // input file
            string inputFile = Path.Combine(TestContext.DeploymentDirectory, "input.txt");
            File.WriteAllText(inputFile, "asdf\n12s34\nASDF\n12S34");

            // output dir
            string outputDirName = "out_" + DateTime.Now.Ticks;
            outputFile = Path.Combine(
                TestContext.DeploymentDirectory, outputDirName, "input.txt");

            replacer = new Replacer
                           {
                               InputFiles = new ReplacableFiles(new List<string> { inputFile }),
                               OutputDirectoryName = outputDirName
                           };
        }


        [TestMethod]
        public void StartAndReportProgress_RuleInNormalMode_ReplacesOccurence()
        {
            // Arrange
            replacer.Rules = new Rules
                                 {
                                     new Rule
                                         {
                                             Mode = Rule.ModeType.Normal,
                                             Search = "asdf",
                                             Replace = "qwer"
                                         }
                                 };


            // Act
            foreach (int percent in replacer.StartAndReportProgress())
            {
            }

            // Assert
            Assert.AreEqual("qwer\n12s34\nASDF\n12S34", File.ReadAllText(outputFile));
        }

        [TestMethod]
        public void StartAndReportProgress_RuleInNormalIgnoreCaseMode_ReplacesOccurence()
        {
            // Arrange
            replacer.Rules = new Rules
                                 {
                                     new Rule
                                         {
                                             Mode = Rule.ModeType.NormalIgnoreCase,
                                             Search = "asdf",
                                             Replace = "qwer"
                                         }
                                 };


            // Act
            foreach (int percent in replacer.StartAndReportProgress())
            {
            }

            // Assert
            Assert.AreEqual("qwer\n12s34\nqwer\n12S34", File.ReadAllText(outputFile));
        }

        [TestMethod]
        public void StartAndReportProgress_RuleInRegexMode_ReplacesOccurence()
        {
            // Arrange
            replacer.Rules = new Rules
                                 {
                                     new Rule
                                         {
                                             Mode = Rule.ModeType.Regex,
                                             Search = @"\d{2}[a-z]\d",
                                             Replace = "wxyz"
                                         }
                                 };


            // Act
            foreach (int percent in replacer.StartAndReportProgress())
            {
            }

            // Assert
            Assert.AreEqual("asdf\nwxyz4\nASDF\n12S34", File.ReadAllText(outputFile));
        }

        [TestMethod]
        public void StartAndReportProgress_RuleInRegexIgnoreCaseMode_ReplacesOccurence()
        {
            // Arrange
            replacer.Rules = new Rules
                                 {
                                     new Rule
                                         {
                                             Mode = Rule.ModeType.RegexIgnoreCase,
                                             Search = @"\d{2}[a-z]\d",
                                             Replace = "wxyz"
                                         }
                                 };


            // Act
            foreach (int percent in replacer.StartAndReportProgress())
            {
            }

            // Assert
            Assert.AreEqual("asdf\nwxyz4\nASDF\nwxyz4", File.ReadAllText(outputFile));
        }

        [TestMethod]
        public void StartAndReportProgress_RuleInRegexMode_UsesRegexMatchingGroup()
        {
            // Arrange
            replacer.Rules = new Rules
                                 {
                                     new Rule
                                         {
                                             Mode = Rule.ModeType.Normal,
                                             Search = "asdf",
                                             Replace = "qwer"
                                         },
                                         new Rule
                                         {
                                             Mode = Rule.ModeType.Regex,
                                             Search = @"\d{2}[a-z]\d",
                                             Replace = "wxyz"
                                         }
                                 };


            // Act
            foreach (int percent in replacer.StartAndReportProgress())
            {
            }

            // Assert
            Assert.AreEqual("qwer\nwxyz4\nASDF\n12S34", File.ReadAllText(outputFile));
        }

        [TestMethod]
        public void StartAndReportProgress_2RulesInNormalAndInRegexMode_ReplacesOccurence()
        {
            // Arrange
            replacer.Rules = new Rules
                                 {
                                     new Rule
                                         {
                                             Mode = Rule.ModeType.Normal,
                                             Search = "asdf",
                                             Replace = "qwer"
                                         }
                                 };


            // Act
            foreach (int percent in replacer.StartAndReportProgress())
            {
            }

            // Assert
            Assert.AreEqual("qwer\n12s34\nASDF\n12S34", File.ReadAllText(outputFile));
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void StartAndReportProgress_NotAllPropertiesAreSet_RaisesError()
        {
            // Act
            replacer.StartAndReportProgress().GetEnumerator().MoveNext();
        }

        [TestMethod]
        public void StartAndReportProgress_RuleInNormalMode_Returns100PercentAtTheEnd()
        {
            // Arrange
            replacer.Rules = new Rules
                                 {
                                     new Rule
                                         {
                                             Mode = Rule.ModeType.Normal,
                                             Search = "asdf",
                                             Replace = "qwer"
                                         }
                                 };


            // Act
            int percentTracked = 0;
            foreach (int percent in replacer.StartAndReportProgress())
            {
                percentTracked = percent;
            }

            // Assert
            Assert.AreEqual(100, percentTracked);
        }
    }
}