using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AirFIT
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SessaoTrabalho : Page
    {
        public SessaoTrabalho()
        {
            this.InitializeComponent();
        }

       

        private void Sessao_Click(object sender,RoutedEventArgs e)
        {
            
            MyFrame.Navigate(typeof(CriarSessão));
        }

        private void Atividades_Click(object sender,RoutedEventArgs e)
        {
           
            MyFrame.Navigate(typeof(Associar));
        }

        private void Consulta_Click(object sender,RoutedEventArgs e)
        {
            
            MyFrame.Navigate(typeof(ConsultarHistorico));
        }

       

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            MapControl MapControl2 = new MapControl();
            MapControl2.ZoomInteractionMode = MapInteractionMode.GestureAndControl;
            MapControl2.TiltInteractionMode = MapInteractionMode.GestureAndControl;
            MapControl2.MapServiceToken = "q5yae3MMjfyvg0USdquc~LoDIfvyRcpIo_VjZ592QPg~AtDD9SkSucOnzN2nlogM6i7MIA_VU-dqneSe5_x_Hqlwdb_-zmqPdeirmudhQTcT";
          


            BasicGeoposition cityPosition = new BasicGeoposition()
            {
                Latitude = 47.604,
                Longitude = -122.329

            };
            Geopoint cityCenter = new Geopoint(cityPosition);



            //Set the map location

            var acessStatus = await Geolocator.RequestAccessAsync();
            switch (acessStatus)
            {
                case GeolocationAccessStatus.Allowed:

                    Geolocator geolocator = new Geolocator();
                    Geoposition pos = await geolocator.GetGeopositionAsync();
                    Geopoint myLocatio = pos.Coordinate.Point;

                    MapControl1.Center = myLocatio;
                    MapControl1.ZoomLevel = 12;
                    MapControl1.LandmarksVisible = true;

                    break;
                case GeolocationAccessStatus.Denied:
                    break;
                case GeolocationAccessStatus.Unspecified:
                    break;
            }


        }
        private async void showStreetsideView()
        {
            // Check if Streetside is supported.
            if (MapControl1.IsStreetsideSupported)
            {
                // Find a panorama near Avenue Gustave Eiffel.
                BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 48.858, Longitude = 2.295 };
                Geopoint cityCenter = new Geopoint(cityPosition);
                StreetsidePanorama panoramaNearCity = await StreetsidePanorama.FindNearbyAsync(cityCenter);

                // Set the Streetside view if a panorama exists.
                if (panoramaNearCity != null)
                {
                    // Create the Streetside view.
                    StreetsideExperience ssView = new StreetsideExperience(panoramaNearCity);
                    ssView.OverviewMapVisible = true;
                    MapControl1.CustomExperience = ssView;
                }
            }
            else
            {
                // If Streetside is not supported
                ContentDialog viewNotSupportedDialog = new ContentDialog()
                {
                    Title = "Streetside is not supported",
                    Content = "\nStreetside views are not supported on this device.",
                    PrimaryButtonText = "OK"
                };
                await viewNotSupportedDialog.ShowAsync();
            }
        }

        private async void display3DLocation()
        {
            if (MapControl1.Is3DSupported)
            {
                // Set the aerial 3D view.
                MapControl1.Style = MapStyle.Aerial3DWithRoads;

                // Specify the location.
                BasicGeoposition hwGeoposition = new BasicGeoposition() { Latitude = 34.134, Longitude = -118.3216 };
                Geopoint hwPoint = new Geopoint(hwGeoposition);

                // Create the map scene.
                MapScene hwScene = MapScene.CreateFromLocationAndRadius(hwPoint,
                                                                                     80, /* show this many meters around */
                                                                                     0, /* looking at it to the North*/
                                                                                     60 /* degrees pitch */);
                // Set the 3D view with animation.
                await MapControl1.TrySetSceneAsync(hwScene, MapAnimationKind.Bow);
            }
            else
            {
                // If 3D views are not supported, display dialog.
                ContentDialog viewNotSupportedDialog = new ContentDialog()
                {
                    Title = "3D is not supported",
                    Content = "\n3D views are not supported on this device.",
                    PrimaryButtonText = "OK"
                };
                await viewNotSupportedDialog.ShowAsync();
            }
        }

    }
}
