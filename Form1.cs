using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GMap_Sample
{
    public partial class Form1 : Form
    {
        private List<PointLatLng> _points;
        private GMapOverlay markersOverlay;
        private GMapOverlay polygonsOverlay;
        private GMapOverlay routesOverlay;

        public Form1()
        {
            InitializeComponent();

            _points = new List<PointLatLng>();
            markersOverlay = new GMapOverlay("markers");
            polygonsOverlay = new GMapOverlay("polygons");
            routesOverlay = new GMapOverlay("routes");

            map.Overlays.Add(markersOverlay);
            map.Overlays.Add(polygonsOverlay);
            map.Overlays.Add(routesOverlay);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.CacheLocation = @"cache";
            map.DragButton = MouseButtons.Left;
            map.ShowCenter = false;
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 10;
        }

        private void btnDijkstra_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy tọa độ từ TextBox
                double startLat = Convert.ToDouble(txtStartLat.Text);
                double startLng = Convert.ToDouble(txtStartLng.Text);
                PointLatLng startPoint = new PointLatLng(startLat, startLng);

                double endLat = Convert.ToDouble(txtEndLat.Text);
                double endLng = Convert.ToDouble(txtEndLng.Text);
                PointLatLng endPoint = new PointLatLng(endLat, endLng);

                if (!_points.Contains(startPoint))
                    _points.Add(startPoint);
                if (!_points.Contains(endPoint))
                    _points.Add(endPoint);

                // Thuật toán Dijkstra
                var path = DijkstraAlgorithm(startPoint, endPoint);

                if (path != null)
                {
                    // Vẽ đường đi với màu khác
                    GMapRoute route = new GMapRoute(path, "Dijkstra Path")
                    {
                        Stroke = new Pen(Color.Blue, 3) // Đường màu xanh lam
                    };

                    routesOverlay.Routes.Clear();
                    routesOverlay.Routes.Add(route);
                    map.Position = startPoint;

                    MessageBox.Show("Đã tìm thấy đường đi ngắn nhất.");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy đường đi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btnPrim_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy tọa độ từ TextBox
                double startLat = Convert.ToDouble(txtStartLat.Text);
                double startLng = Convert.ToDouble(txtStartLng.Text);
                PointLatLng startPoint = new PointLatLng(startLat, startLng);

                if (!_points.Contains(startPoint))
                    _points.Add(startPoint);

                // Thuật toán Prim
                var treeEdges = PrimAlgorithm(startPoint);

                if (treeEdges.Count > 0)
                {
                    routesOverlay.Routes.Clear();

                    // Vẽ các cạnh cây khung nhỏ nhất
                    foreach (var edge in treeEdges)
                    {
                        GMapRoute route = new GMapRoute(new List<PointLatLng> { edge.Item1, edge.Item2 }, "Prim Edge")
                        {
                            Stroke = new Pen(Color.Green, 2) // Đường màu xanh lá
                        };
                        routesOverlay.Routes.Add(route);
                    }

                    map.Position = startPoint;
                    MessageBox.Show("Cây khung nhỏ nhất đã được vẽ.");
                }
                else
                {
                    MessageBox.Show("Không thể tìm cây khung nhỏ nhất.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private List<PointLatLng> DijkstraAlgorithm(PointLatLng start, PointLatLng end)
        {
            int n = _points.Count;
            double[] distances = Enumerable.Repeat(double.MaxValue, n).ToArray();
            bool[] visited = new bool[n];
            int[] previous = new int[n];
            distances[_points.IndexOf(start)] = 0;

            for (int i = 0; i < n; i++) previous[i] = -1;

            for (int count = 0; count < n - 1; count++)
            {
                int u = -1;
                double minDistance = double.MaxValue;

                for (int i = 0; i < n; i++)
                {
                    if (!visited[i] && distances[i] < minDistance)
                    {
                        minDistance = distances[i];
                        u = i;
                    }
                }

                if (u == -1) break;
                visited[u] = true;

                for (int v = 0; v < n; v++)
                {
                    if (!visited[v])
                    {
                        double distance = GetDistance(_points[u], _points[v]);

                        if (distances[u] + distance < distances[v])
                        {
                            distances[v] = distances[u] + distance;
                            previous[v] = u;
                        }
                    }
                }
            }

            int endIndex = _points.IndexOf(end);
            if (distances[endIndex] == double.MaxValue) return null;

            List<PointLatLng> path = new List<PointLatLng>();
            for (int at = endIndex; at != -1; at = previous[at])
            {
                path.Insert(0, _points[at]);
            }

            return path;
        }

        private List<(PointLatLng, PointLatLng)> PrimAlgorithm(PointLatLng start)
        {
            int n = _points.Count;
            bool[] inTree = new bool[n];
            double[] minEdge = Enumerable.Repeat(double.MaxValue, n).ToArray();
            int[] parent = new int[n];
            List<(PointLatLng, PointLatLng)> treeEdges = new List<(PointLatLng, PointLatLng)>();

            int startIndex = _points.IndexOf(start);
            minEdge[startIndex] = 0;

            for (int i = 0; i < n; i++) parent[i] = -1;

            for (int count = 0; count < n; count++)
            {
                int u = -1;
                double minDistance = double.MaxValue;

                for (int i = 0; i < n; i++)
                {
                    if (!inTree[i] && minEdge[i] < minDistance)
                    {
                        minDistance = minEdge[i];
                        u = i;
                    }
                }

                if (u == -1) break;
                inTree[u] = true;

                if (parent[u] != -1)
                {
                    treeEdges.Add((_points[parent[u]], _points[u]));
                }

                for (int v = 0; v < n; v++)
                {
                    double distance = GetDistance(_points[u], _points[v]);

                    if (!inTree[v] && distance < minEdge[v])
                    {
                        minEdge[v] = distance;
                        parent[v] = u;
                    }
                }
            }

            return treeEdges;
        }

        private double GetDistance(PointLatLng p1, PointLatLng p2)
        {
            double latDiff = p1.Lat - p2.Lat;
            double lngDiff = p1.Lng - p2.Lng;
            return Math.Sqrt(latDiff * latDiff + lngDiff * lngDiff);
        }
        private void btnLoadIntoMap_Click(object sender, EventArgs e)
        {
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;

            // Đọc giá trị nhập vào từ các TextBox
            double lat = Convert.ToDouble(txtLat.Text);
            double lng = Convert.ToDouble(txtLong.Text);

            // Tạo điểm PointLatLng với giá trị vĩ độ và kinh độ
            PointLatLng point = new PointLatLng(lat, lng);

            // Thêm điểm vào danh sách _points
            _points.Add(point);

            // Cập nhật vị trí của bản đồ
            map.Position = point;
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 10;

            // Xóa tất cả overlay cũ trước khi thêm mới
            //map.Overlays.Clear();

            // Tạo marker với kiểu pushpin đỏ
            GMarkerGoogle marker = new GMarkerGoogle(point, GMarkerGoogleType.red_pushpin);

            // Tạo overlay và thêm marker vào overlay
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            markersOverlay.Markers.Add(marker);

            // Thêm overlay vào bản đồ
            map.Overlays.Add(markersOverlay);
        }

        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            // Thêm điểm vào danh sách các điểm
            _points.Add(new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLong.Text)));
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            // Xóa danh sách các điểm và các markers hiện tại
            _points.Clear();
            markersOverlay.Markers.Clear();
            polygonsOverlay.Polygons.Clear();  // Xóa các polygons cũ nếu cần
        }

        private void btnAddPoly_Click(object sender, EventArgs e)
        {
            if (_points.Count >= 3) // Đảm bảo có đủ điểm để tạo một polygon hợp lệ
            {
                var polygon = new GMapPolygon(_points, "My Area")
                {
                    Stroke = new Pen(Color.Red, 2),
                    Fill = new SolidBrush(Color.FromArgb(50, Color.Red)) // Màu sắc của khu vực
                };

                // Thêm polygon vào overlay polygons
                polygonsOverlay.Polygons.Add(polygon);
            }
            else
            {
                MessageBox.Show("Cần ít nhất 3 điểm để tạo polygon.");
            }
        }

        private void btnsatt_Click(object sender, EventArgs e)
        {
            map.MapProvider = GMap.NET.MapProviders.GoogleHybridMapProvider.Instance;
        }

    }
}
