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
        // Dùng List<PointLatLng> thay vì List<Point>
        private List<PointLatLng> _points;

        // Thêm overlay cho các markers và polygons
        private GMapOverlay markersOverlay;
        private GMapOverlay polygonsOverlay;

        public Form1()
        {
            InitializeComponent();
            // Khởi tạo danh sách các điểm
            _points = new List<PointLatLng>();

            // Tạo các overlay cho markers và polygons
            markersOverlay = new GMapOverlay("markers");
            polygonsOverlay = new GMapOverlay("polygons");

            // Thêm overlay vào bản đồ
            map.Overlays.Add(markersOverlay);
            map.Overlays.Add(polygonsOverlay);
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
