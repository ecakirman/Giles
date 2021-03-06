﻿using System;
using System.Collections.Generic;

namespace Giles.Core.Runners
{
    [Serializable]
    public class TestResult
    {
        public string Message;
        public string Name;
        public string StackTrace;
        public TestState State;
        public string TestRunner;
        public TimeSpan TimeSpan;
        public int TotalTests;
    }

    [Serializable]
    public enum TestState
    {
        Passed,
        Failed,
        Ignored
    }

    [Serializable]
    public enum SessionRunState
    {
        Success,
        Failure,
        Error,
        NoTests
    }

    [Serializable]
    public class SessionResults
    {
        public SessionResults()
        {
            TestResults = new List<TestResult>();
            Messages = new List<string>();
        }
        public SessionRunState SessionRunState { get; set; }
        public IList<TestResult> TestResults { get; set; }
        public IList<string> Messages { get; set; }
    }
}