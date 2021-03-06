﻿using System.Collections.Generic;
using TechTalk.SpecFlow;
using YAGLi.Specs.Common.Validators;
using YAGLi.Specs.DirectedGraph.AbstractSteps;
using YAGLi.Specs.DirectedGraph.Builders;
using YAGLi.Tests.Utils;

namespace YAGLi.Specs.DirectedGraph.Steps
{
    public sealed class AddVertexSteps : DirectedGraphStepWithGraphValidator
    {
        public AddVertexSteps(DirectedGraphBuilder builder, GraphValidator validator) : base(builder, validator) { }

        [When(@"I add the vertices to the directed graph")]
        public void WhenIAddTheVertices(IEnumerable<Vertex> vertices)
        {
            Validator.Subject = Builder.Instance.AddVertices(vertices);
        }

        [When(@"I add the vertex ""(.*)"" to the directed graph")]
        public void WhenIAddTheVertex(Vertex vertex)
        {
            Validator.Subject = Builder.Instance.AddVertex(vertex);
        }
    }
}
