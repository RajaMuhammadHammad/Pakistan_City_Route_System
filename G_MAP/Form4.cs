using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Drawing;

namespace G_MAP
{
    public partial class Form4 : Form
    {
        private GMapOverlay routeOverlay;
        private GMapOverlay cityOverlay;

        public Form4()
        {
            InitializeComponent();
            cityOverlay = new GMapOverlay("cityOverlay");
        }

        private static readonly List<PointLatLng> value = new List<PointLatLng>
        {new PointLatLng(24.8607,67.0011),
            new PointLatLng(    31.582045  , 74.329376),

            new PointLatLng(34.025917  , 71.560135),
            new PointLatLng(    31.418715  , 73.079109),
            new PointLatLng(25.3960,  68.3578),
            new PointLatLng(    33.738045  , 73.084488),

            new PointLatLng(    33.626057  , 73.071442),

            new PointLatLng(    30.183270  , 66.996452),

            new PointLatLng(    27.563993  , 68.215134),

            new PointLatLng(    35.920834  , 74.308334),

            new PointLatLng(    30.677717  , 73.106812),

            new PointLatLng(    29.395721  , 71.683334),

            new PointLatLng(    32.571144  , 74.075005),

            new PointLatLng(    25.067562  , 66.917038),

            new PointLatLng(    34.206123  , 72.029800),
            new PointLatLng(    25.126389  , 62.322498)

        };

        List<PointLatLng> finalRouteCoords;

        private void Form4_Load(object sender, EventArgs e)
        {
            InitializePakistanMap();
            InitializeFinalPathListCords();
        }

        private void InitializePakistanMap()
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            map.Dock = DockStyle.Fill;
            map.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            map.Zoom = 7;

            // Initialize the overlay for the route
            routeOverlay = new GMapOverlay("routeOverlay");
            map.Overlays.Add(routeOverlay);
            map.MinZoom = 5;
            map.MaxZoom = 100000;
            map.Zoom = 10;
            map.DragButton = MouseButtons.Left;

            cityOverlay = new GMapOverlay("cityOverlay"); // Initialize the overlay for city markers
            map.Overlays.Add(cityOverlay); // Add city overlay to the map

            foreach (PointLatLng cityPosition in value)
            {
                GMapMarker cityMarker = new GMarkerGoogle(cityPosition, GMarkerGoogleType.blue_dot);
                cityOverlay.Markers.Add(cityMarker); // Add city markers to the city overlay
            }
        }

        private void HighlightStartAndEndMarkers()
        {
            if (finalRouteCoords != null && finalRouteCoords.Count > 1 && cityOverlay != null) // Check for null cityOverlay
            {
                GMapMarker startMarker = cityOverlay.Markers.FirstOrDefault(marker => marker.Position == finalRouteCoords.First());
                GMapMarker endMarker = cityOverlay.Markers.FirstOrDefault(marker => marker.Position == finalRouteCoords.Last());

                if (startMarker != null && endMarker != null)
                {
                    startMarker = new GMarkerGoogle(startMarker.Position, GMarkerGoogleType.yellow_dot);
                    endMarker = new GMarkerGoogle(endMarker.Position, GMarkerGoogleType.yellow_dot);

                    map.Overlays.Remove(cityOverlay);
                    cityOverlay.Markers.Clear();
                    cityOverlay.Markers.Add(startMarker);
                    cityOverlay.Markers.Add(endMarker);
                    map.Overlays.Add(cityOverlay);
                }
            }
        }

        private void InitializeFinalPathListCords()
        {
            finalRouteCoords = new List<PointLatLng>();
            foreach (int i in Algoritm.path)
            {
                
                    if (i == 0)
                {
                    finalRouteCoords.Add(new PointLatLng(24.8607, 67.0011));
                    HighlightStartAndEndMarkers();
                }
                else if (i == 1)
                {
                    finalRouteCoords.Add(new PointLatLng(31.582045, 74.329376));
                    HighlightStartAndEndMarkers();
                }
                else if (i == 2)
                {
                    finalRouteCoords.Add(new PointLatLng(34.025917, 71.560135));
                }
                else if (i == 3)
                {
                    finalRouteCoords.Add(new PointLatLng(31.418715, 73.079109));
                }
                else if (i == 4)
                {
                    finalRouteCoords.Add(new PointLatLng(25.3960, 68.3578));
                }
                else if (i == 5)
                {
                    finalRouteCoords.Add(new PointLatLng(33.738045, 73.084488));
                }
                else if (i == 6)
                {
                    finalRouteCoords.Add(new PointLatLng(33.626057, 73.071442));
                }
                else if (i == 7)
                {
                    finalRouteCoords.Add(new PointLatLng(30.183270, 66.996452));
                }
                else if (i == 8)
                {
                    finalRouteCoords.Add(new PointLatLng(27.563993, 68.215134));
                }
                else if (i == 9)
                {
                    finalRouteCoords.Add(new PointLatLng(35.920834, 74.308334));
                }
                else if (i == 10)
                {
                    finalRouteCoords.Add(new PointLatLng(30.677717, 73.106812));
                }
                else if (i == 11)
                {
                    finalRouteCoords.Add(new PointLatLng(29.395721, 71.683334));
                }
                else if (i == 12)
                {
                    finalRouteCoords.Add(new PointLatLng(32.571144, 74.075005));
                }
                else if (i == 13)
                {
                    finalRouteCoords.Add(new PointLatLng(25.067562, 66.917038));
                }
                else if (i == 14)
                {
                    finalRouteCoords.Add(new PointLatLng(34.206123, 72.029800));
                }
                else
                {
                    finalRouteCoords.Add(new PointLatLng(25.126389, 62.322498));
                }
            }
            
            DrawRoute();
            HighlightStartAndEndMarkers();
        }

        private void DrawRoute()
        {
            // Clear existing routes
            routeOverlay.Routes.Clear();

            // Draw route using the locations list
            GMapRoute route = new GMapRoute(finalRouteCoords, "Route");
            route.Stroke = new Pen(System.Drawing.Color.Red, 2); // Set the route color and thickness

            // Add route to overlay
            routeOverlay.Routes.Add(route);

            // Update the map to display the route
            map.ZoomAndCenterRoutes("routeOverlay");
        }

        private void map_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 F3 = new Form3();
            F3.Show();

        }
    }
}
