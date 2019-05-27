﻿using System;
using Io.Cucumber.Messages;
using TechTalk.SpecFlow.CommonModels;

namespace TechTalk.SpecFlow.CucumberMessages
{
    public interface ICucumberMessageFactory
    {
        IResult<TestRunStarted> BuildTestRunStartedMessage(DateTime timeStamp);

        IResult<TestCaseStarted> BuildTestCaseStartedMessage(Guid pickleId, DateTime timeStamp);

        IResult<Wrapper> BuildWrapperMessage(IResult<TestRunStarted> testRunStarted);

        IResult<Wrapper> BuildWrapperMessage(IResult<TestCaseStarted> testCaseStarted);
    }
}
