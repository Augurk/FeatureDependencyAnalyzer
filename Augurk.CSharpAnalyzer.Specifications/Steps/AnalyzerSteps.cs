﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Augurk.CSharpAnalyzer.Collectors;
using Augurk.CSharpAnalyzer.Commands;
using Augurk.CSharpAnalyzer.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using TechTalk.SpecFlow;
using System.Threading.Tasks;

namespace Augurk.CSharpAnalyzer.Specifications.Steps
{
    [Binding]
    public class AnalyzerSteps
    {
        private string _solution = Path.Combine(AppContext.BaseDirectory, @"..\..\..\Augurk.CSharpAnalyzer.sln");
        private string _targetProject;
        private JToken _output;

        [Given(@"'(.*)' contains feature files")]
        public void GivenContainsFeatureFiles(string projectName)
        {
            _targetProject = projectName;
        }
        
        [When(@"an analysis is run")]
        public async Task WhenAnAnalysisIsRun()
        {
            var options = new AnalyzeOptions();
            options.Solution = _solution;
            options.SpecificationsProject = _targetProject;

            var command = new AnalyzeCommand();

            _output = await command.Analyze(options);
        }

        [Then(@"the following report is returned for '(.*)'")]
        public void ThenTheFollowingReportIsReturnedFor(string projectName, Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the first (.*) lines of the resulting report are")]
        public void ThenTheFirstLinesOfTheResultingReportAre(int numberOfLinesToCheck, Table table)
        {
            if (_output == null)
            {
                Assert.Inconclusive("Please use a matching WHEN step before using this THEN step.");
            }

            Assert.AreEqual(numberOfLinesToCheck, table.RowCount, "The provided number of rows does not match the mentioned number of rows.");

            List<dynamic> flatList = new List<dynamic>();
            Flatten(_output as JArray, flatList);

            for (int counter = 0; counter < numberOfLinesToCheck; counter++)
            {
                Assert.AreEqual(table.Rows[counter]["Kind"], flatList[counter].Kind, $"The Kind does not match on row {counter}");
                Assert.AreEqual(string.IsNullOrWhiteSpace(table.Rows[counter]["Local"]) ? false : Boolean.Parse(table.Rows[counter]["Local"]),
                                flatList[counter].Local, $"Row {counter} locallity is incorrect");
                Assert.AreEqual(table.Rows[counter]["Expression/Signature"], flatList[counter].Signature, $"The Expression/Signature does not match on row {counter}");
            }
        }

        private void Flatten(JArray invocations, List<dynamic> flatList)
        {
            foreach (var invocation in invocations)
            {
                JToken regExpressions = invocation["RegularExpressions"];

                flatList.Add(new
                {
                    Kind = invocation["Kind"].Value<String>(),
                    Local = invocation["Local"]?.Value<bool>() ?? false,
                    Signature = regExpressions == null ? invocation["Signature"].Value<String>() : String.Join(",", ((JArray)regExpressions).ToList())
                });

                JArray deeperInvocations = invocation["Invocations"] as JArray;

                if (deeperInvocations != null)
                {
                    Flatten(deeperInvocations, flatList);
                }
            }
        }
    }
}
