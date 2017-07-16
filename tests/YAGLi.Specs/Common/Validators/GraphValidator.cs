﻿using NFluent;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using YAGLi.Interfaces;
using YAGLi.Tests.Utils;

namespace YAGLi.Specs.Common.Validators
{
    [Binding]
    public sealed class GraphValidator
    {
        public IModelAGraph<Vertex, Edge<Vertex>> Subject { get; set; }

        [Then(@"he should contains the vertices")]
        public void ThenHeShouldContainsTheVerticesAnd(IEnumerable<Vertex> vertices)
        {
            Check.That(Subject.Vertices).ContainsExactly(vertices);
        }

        [Then(@"he should contains the edges")]
        public void ThenTheEdges(IEnumerable<Edge<Vertex>> edges)
        {
            Check.That(Subject.Edges).ContainsExactly(edges);
        }

        [Then(@"he contains the vertices")]
        public void ThenThisNewUndirectedGraphShouldContainsTheVertices(IEnumerable<Vertex> vertices)
        {
            Check.That(Subject.Vertices)
                .IsOnlyMadeOf(vertices)
                .And
                .HasSize(vertices.Count());
        }

        [Then(@"he contains the edges")]
        public void ThenThisNewUndirectedGraphShouldContainsTheEdges(IEnumerable<Edge<Vertex>> edges)
        {
            Check.That(Subject.Edges)
                .IsOnlyMadeOf(edges)
                .And
                .HasSize(edges.Count());
        }
    }
}
