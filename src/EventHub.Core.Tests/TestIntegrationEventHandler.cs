﻿using EventHub.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Core.Tests
{
    public class TestIntegrationEventHandler : IIntegrationEventHandler<TestIntegrationEvent>
    {
        public bool Handled { get; private set; }

        public TestIntegrationEventHandler()
        {
            Handled = false;
        }

        public async Task Handle(TestIntegrationEvent @event)
        {
            Handled = true;
        }
    }
}
