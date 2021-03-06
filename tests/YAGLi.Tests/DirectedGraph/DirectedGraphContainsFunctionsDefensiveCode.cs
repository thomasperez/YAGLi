﻿using NFluent;
using NUnit.Framework;
using System.Collections.Generic;
using YAGLi.Tests.Utils;

namespace YAGLi.Tests.DirectedGraph
{
    [TestFixture(TestOf = typeof(DirectedGraph<Vertex, Edge<Vertex>>))]
    public class DirectedGraphContainsFunctionsDefensiveCode
    {
        private readonly Vertex NULL_VERTEX = null;
        private readonly Edge<Vertex> NULL_EDGE = null;
        private readonly Edge<Vertex>[] NULL_EDGE_ARRAY = null;
        private readonly IEnumerable<Edge<Vertex>> NULL_EDGE_IENUMERABLE = null;
        private readonly Edge<Vertex>[] EDGE_ARRAY_WHO_CONTAINS_NULL = new Edge<Vertex>[] { null };
        private readonly IEnumerable<Edge<Vertex>> EDGE_IENUMERABLE_WHO_CONTAINS_NULL = new Edge<Vertex>[] { null };
        private readonly Vertex[] NULL_VERTEX_ARRAY = null;
        private readonly IEnumerable<Vertex> NULL_VERTEX_COLLECTION = null;
        private readonly Vertex[] VERTEX_ARRAY_WHO_CONTAINS_NULL = new Vertex[] { null };
        private readonly IEnumerable<Vertex> VERTEX_COLLECTION_WHO_CONTAINS_NULL = new Vertex[] { null };
        private readonly Edge<Vertex>[] EDGE_ARRAY_WITH_EDGE_WITH_NULL_VERTEX = new Edge<Vertex>[] { new Edge<Vertex>(null, null) };
        private readonly IEnumerable<Edge<Vertex>> EDGE_IENUMERABLE_WITH_EDGE_WITH_NULL_VERTEX = new Edge<Vertex>[] { new Edge<Vertex>(null, null) };

        private readonly DirectedGraph<Vertex, Edge<Vertex>> _graph = new DirectedGraph<Vertex, Edge<Vertex>>(true, true, new VertexEqualityComparer());
        private bool _result;

        [SetUp]
        public void SetUp()
        {
            _result = true;
        }

        [TearDown]
        public void TearDown()
        {
            Check.That(_result).IsFalse();
        }

        [Test]
        public void ContainsEdge_with_a_null_edge_should_return_false()
        {
            _result =  _graph.ContainsEdge(NULL_EDGE);
        }

        [Test]
        public void ContainsEdges_with_a_null_IEnumerable_of_Edges_should_return_false()
        {
            _result =  _graph.ContainsEdges(NULL_EDGE_IENUMERABLE);
        }

        [Test]
        public void ContainsEdges_with_a_IEnumerable_of_Edges_that_contains_a_null_vertex_should_return_false()
        {
            _result =  _graph.ContainsEdges(EDGE_IENUMERABLE_WHO_CONTAINS_NULL);
        }

        [Test]
        public void ContainsEdges_with_a_IEnumerable_of_Edges_that_contains_a_vertex_with_a_null_edge_should_return_false()
        {
            _result =  _graph.ContainsEdges(EDGE_IENUMERABLE_WITH_EDGE_WITH_NULL_VERTEX);
        }

        [Test]
        public void ContainsEdges_with_a_null_array_of_Edges_should_return_false()
        {
            _result =  _graph.ContainsEdges(NULL_EDGE_ARRAY);
        }

        [Test]
        public void ContainsEdges_with_a_array_of_Edges_that_contains_a_null_vertex_should_return_false()
        {
            _result =  _graph.ContainsEdges(EDGE_ARRAY_WHO_CONTAINS_NULL);
        }

        [Test]
        public void ContainsEdges_with_a_array_of_Edges_that_contains_a_vertex_with_a_null_edge_should_return_false()
        {
            _result =  _graph.ContainsEdges(EDGE_ARRAY_WITH_EDGE_WITH_NULL_VERTEX);
        }

        [Test]
        public void ContainsVertex_with_a_null_vertex_should_return_false()
        {
            _result =  _graph.ContainsVertex(NULL_VERTEX);
        }

        [Test]
        public void ContainsVertices_with_a_null_IEnumerable_of_Vertices_should_return_false()
        {
            _result =  _graph.ContainsVertices(NULL_VERTEX_COLLECTION);
        }

        [Test]
        public void ContainsVertices_with_a_IEnumerable_of_Vertices_that_contains_a_null_vertex_should_return_false()
        {
            _result =  _graph.ContainsVertices(VERTEX_COLLECTION_WHO_CONTAINS_NULL);
        }

        [Test]
        public void ContainsVertices_with_a_null_array_of_Vertices_should_return_false()
        {
            _result =  _graph.ContainsVertices(NULL_VERTEX_ARRAY);
        }

        [Test]
        public void ContainsVertices_with_a_array_of_Vertices_that_contains_a_null_vertex_should_return_false()
        {
            _result =  _graph.ContainsVertices(VERTEX_ARRAY_WHO_CONTAINS_NULL);
        }
    }
}
