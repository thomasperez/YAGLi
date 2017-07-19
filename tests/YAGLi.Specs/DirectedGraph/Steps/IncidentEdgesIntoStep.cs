﻿using TechTalk.SpecFlow;
using YAGLi.Specs.Common.Validators;
using YAGLi.Specs.DirectedGraph.AbstractSteps;
using YAGLi.Tests.Utils;

namespace YAGLi.Specs.DirectedGraph.Steps
{
    public sealed class IncidentEdgesIntoStep : DirectedGraphStepWithEdgeCollectionValidator
    {
        public IncidentEdgesIntoStep(DirectedGraphBuilder builder, EdgeCollectionValidator validator) : base(builder, validator) { }

        [When(@"I retrieve the incident edges into ""(.*)""")]
        public void WhenIRetrieveTheIncidentEdgesInto(Vertex vertex)
        {
            _validator.Subject = _builder.Instance.IncidentEdgesInto(vertex);
        }
    }
}
