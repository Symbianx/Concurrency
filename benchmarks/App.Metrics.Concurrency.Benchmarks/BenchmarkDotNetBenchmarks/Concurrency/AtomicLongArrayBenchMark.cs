﻿// <copyright file="AtomicLongArrayBenchMark.cs" company="Allan Hardy">
// Copyright (c) Allan Hardy. All rights reserved.
// </copyright>

using BenchmarkDotNet.Attributes;

namespace App.Metrics.Concurrency.Benchmarks.BenchmarkDotNetBenchmarks.Concurrency
{
    public class AtomicLongArrayBenchmark : DefaultBenchmarkBase
    {
        private AtomicLongArray _num;

        [GlobalSetup]
        public override void Setup()
        {
            _num = new AtomicLongArray(10);
        }

        [Benchmark]
        public void Decrement()
        {
            _num.Decrement(1);
        }

        [Benchmark]
        public void Get()
        {
            // ReSharper disable UnusedVariable
            var x = _num.GetValue(1);
            // ReSharper restore UnusedVariable
        }

        [Benchmark]
        public void Increment()
        {
            _num.Increment(1);
        }
    }
}