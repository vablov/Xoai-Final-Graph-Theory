using System;
using System.Collections.Generic;

public class Graph
{
    private Dictionary<int, List<(int, double)>> _adjacencyList;

    public Graph()
    {
        _adjacencyList = new Dictionary<int, List<(int, double)>>();
    }

    // Thêm cạnh giữa hai điểm
    public void AddEdge(int u, int v, double weight)
    {
        if (!_adjacencyList.ContainsKey(u))
            _adjacencyList[u] = new List<(int, double)>();
        if (!_adjacencyList.ContainsKey(v))
            _adjacencyList[v] = new List<(int, double)>();

        _adjacencyList[u].Add((v, weight));
        _adjacencyList[v].Add((u, weight)); // Đồ thị vô hướng
    }

    // Thuật toán Dijkstra
    public (List<int> path, double distance) Dijkstra(int start, int end)
    {
        var distances = new Dictionary<int, double>();
        var previous = new Dictionary<int, int>();
        var priorityQueue = new SortedSet<(double, int)>();
        var visited = new HashSet<int>();

        foreach (var vertex in _adjacencyList.Keys)
        {
            distances[vertex] = double.MaxValue;
            previous[vertex] = -1;
        }

        distances[start] = 0;
        priorityQueue.Add((0, start));

        while (priorityQueue.Count > 0)
        {
            var (currentDistance, currentVertex) = priorityQueue.Min;
            priorityQueue.Remove(priorityQueue.Min);

            if (visited.Contains(currentVertex))
                continue;

            visited.Add(currentVertex);

            if (currentVertex == end)
                break;

            foreach (var (neighbor, weight) in _adjacencyList[currentVertex])
            {
                double newDist = currentDistance + weight;

                if (newDist < distances[neighbor])
                {
                    priorityQueue.Remove((distances[neighbor], neighbor));
                    distances[neighbor] = newDist;
                    previous[neighbor] = currentVertex;
                    priorityQueue.Add((newDist, neighbor));
                }
            }
        }

        // Tạo đường đi ngắn nhất
        var path = new List<int>();
        int current = end;

        while (current != -1)
        {
            path.Add(current);
            current = previous[current];
        }

        path.Reverse();

        return (path, distances[end]);
    }
}