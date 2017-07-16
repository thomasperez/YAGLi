﻿using TechTalk.SpecFlow;
using YAGLi.Specs.Common.AbstractSteps;
using YAGLi.Specs.Common.Validators;
using YAGLi.Tests.Utils;

namespace YAGLi.Specs.Common.Steps
{
    public sealed class IncidentVerticesOfStep : StepWithVertexCollectionValidator
    {
        public IncidentVerticesOfStep(GraphBuilder builder, VertexCollectionValidator validator) : base(builder, validator) { }

        [When(@"I get the incident vertices of the edge")]
        public void WhenIGetTheIncidentVerticesOfTheEdge(Edge<Vertex> edge)
        {
            Validator.Subject = Builder.Instance.IncidentVerticesOf(edge);
        }
    }
}
