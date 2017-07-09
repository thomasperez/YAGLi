﻿using TechTalk.SpecFlow;
using YAGLi.Specs.Common.Validators;
using YAGLi.Specs.UndirectedGraph;
using YAGLi.Tests.Utils;

namespace YAGLi.Specs.Common.Steps
{
    [Binding]
    public class IncidentVerticesOfStep
    {
        private readonly UndirectedGraphBuilder _builder;
        private readonly VertexCollectionValidator _validator;

        public IncidentVerticesOfStep(UndirectedGraphBuilder builder, VertexCollectionValidator validator)
        {
            _builder = builder;
            _validator = validator;
        }

        [When(@"I get the incident vertices of the edge")]
        public void WhenIGetTheIncidentVerticesOfTheEdge(Edge<Vertex> edge)
        {
            _validator.Subject = _builder.Instance.IncidentVerticesOf(edge);
        }
    }
}