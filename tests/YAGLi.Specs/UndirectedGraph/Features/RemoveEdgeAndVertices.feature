﻿Feature: Removing edge(s), with her/their vertices, from a undirected graph

Scenario: Remove an edge and her vertices from a undirected graph who allow parallel edges
	Given the property allow loops
	And the property allow parallel edges
	And the vertices
	| Name |
	| v0   |
	| v1   |
	| v2   |
	| v3   |
	| v4   |
	And the edges
    | End1 | End2 |
	| v0   | v1   |
	| v1   | v4   |
	| v4   | v4   |
	| v4   | v3   |
	| v3   | v4   |
	And the undirected graph created with them
	When I remove the edge and her vertices from the undirected graph
    | End1 | End2 |
	| v0   | v1   |
	Then I get a new undirected graph
	And he contains the vertices
	| Name |
	| v2   |
	| v3   |
	| v4   |
	And he contains the edges
	| End1 | End2 |
	| v4   | v4   |
	| v4   | v3   |
	| v3   | v4   |

Scenario: Remove an edge and her vertices from a undirected graph who disallow parallel edges
	Given the property allow loops
	And the property disallow parallel edges
	And the vertices
	| Name |
	| v0   |
	| v1   |
	| v2   |
	| v3   |
	| v4   |
	And the edges
    | End1 | End2 |
	| v0   | v1   |
	| v1   | v4   |
	| v4   | v4   |
	| v4   | v3   |
	And the undirected graph created with them
	When I remove the edge and her vertices from the undirected graph
    | End1 | End2 |
	| v0   | v1   |
	Then I get a new undirected graph
	And he contains the vertices
	| Name |
	| v2   |
	| v3   |
	| v4   |
	And he contains the edges
	| End1 | End2 |
	| v4   | v4   |
	| v4   | v3   |

Scenario: Remove a IEnumerable of edges with their vertices from a undirected graph who allow parallel edges
	Given the property allow loops
	And the property allow parallel edges
	And the vertices
	| Name |
	| v0   |
	| v1   |
	| v2   |
	| v3   |
	| v4   |
	And the edges
    | End1 | End2 |
	| v0   | v1   |
	| v1   | v4   |
	| v4   | v4   |
	| v4   | v3   |
	| v3   | v4   |
	And the undirected graph created with them
	When I remove the following IEnumerable of edges with their vertices from the undirected graph
    | End1 | End2 |
	| v0   | v1   |
	| v1   | v4   |
	Then I get a new undirected graph
	And he contains the vertices
	| Name |
	| v2   |
	| v3   |
	And he contains the edges
	| End1 | End2 |

Scenario: Remove an array of edges with their vertices from a undirected graph who allow parallel edges
	Given the property allow loops
	And the property allow parallel edges
	And the vertices
	| Name |
	| v0   |
	| v1   |
	| v2   |
	| v3   |
	| v4   |
	And the edges
    | End1 | End2 |
	| v0   | v1   |
	| v1   | v4   |
	| v4   | v4   |
	| v4   | v3   |
	| v3   | v4   |
	And the undirected graph created with them
	When I remove the following array of edges with their vertices from the undirected graph
    | End1 | End2 |
	| v0   | v1   |
	| v1   | v4   |
	Then I get a new undirected graph
	And he contains the vertices
	| Name |
	| v2   |
	| v3   |
	And he contains the edges
	| End1 | End2 |

Scenario: Remove a IEnumerable of edges with their vertices from a undirected graph who disallow parallel edges
	Given the property allow loops
	And the property disallow parallel edges
	And the vertices
	| Name |
	| v0   |
	| v1   |
	| v2   |
	| v3   |
	| v4   |
	And the edges
    | End1 | End2 |
	| v0   | v1   |
	| v1   | v4   |
	| v4   | v4   |
	| v4   | v3   |
	And the undirected graph created with them
	When I remove the following IEnumerable of edges with their vertices from the undirected graph
    | End1 | End2 |
	| v0   | v1   |
	| v1   | v4   |
	Then I get a new undirected graph
	And he contains the vertices
	| Name |
	| v2   |
	| v3   |
	And he contains the edges
	| End1 | End2 |

Scenario: Remove an array of edges with their vertices from a undirected graph who disallow parallel edges
	Given the property allow loops
	And the property disallow parallel edges
	And the vertices
	| Name |
	| v0   |
	| v1   |
	| v2   |
	| v3   |
	| v4   |
	And the edges
    | End1 | End2 |
	| v0   | v1   |
	| v1   | v4   |
	| v4   | v4   |
	| v4   | v3   |
	And the undirected graph created with them
	When I remove the following array of edges with their vertices from the undirected graph
    | End1 | End2 |
	| v0   | v1   |
	| v1   | v4   |
	Then I get a new undirected graph
	And he contains the vertices
	| Name |
	| v2   |
	| v3   |
	And he contains the edges
	| End1 | End2 |

Scenario: Remove a parallel edge her vertices from a undirected graph
	Given the property allow loops
	And the property allow parallel edges
	And the vertices
	| Name |
	| v0   |
	| v1   |
	| v2   |
	| v3   |
	| v4   |
	And the edges
    | End1 | End2 |
	| v0   | v1   |
	| v1   | v4   |
	| v4   | v4   |
	| v4   | v3   |
	| v3   | v4   |
	And the undirected graph created with them
	When I remove the edge and her vertices from the undirected graph
    | End1 | End2 |
	| v3   | v4   |
	Then I get a new undirected graph
	And he contains the vertices
	| Name |
	| v0   |
	| v1   |
	| v2   |
	And he contains the edges
	| End1 | End2 |
	| v0   | v1   |