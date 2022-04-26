using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Team32App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Locations : ContentPage
    {
        Pin pin1 = new Pin()
        {
            Type = PinType.Place,
            Position = new Position(37.98614299099963d, 23.732310128392367d),
            Label = "Multifunctional Center for Refugees and Migrants",
            Address = "Kapodistriou 2, Athina 106 82, Greece"
        };

        Pin pin2 = new Pin()
        {
            Type = PinType.Place,
            Position = new Position(40.627960201311446d, 23.247887618557346d),
            Label = "Lagkadikion Refugee Accomodation Center",
            Address = "Lagkadikia 570 20, Greece"
        };

        Pin pin3 = new Pin()
        {
            Type = PinType.Place,
            Position = new Position(38.03140449646788d, 23.490776219326644d),
            Label = "Elefsina Refugee and Immigrants Hospital Center",
            Address = "Mandra 192 00, Greece"
        };

        Pin pin4 = new Pin()
        {
            Type = PinType.Place,
            Position = new Position(37.98658415322644d, 23.73248489078773d),
            Label = "Greek Council for Refugees",
            Address = "Solomou 25, Athina 106 82, Greece"
        };

        Pin pin5 = new Pin()
        {
            Type = PinType.Place,
            Position = new Position(37.99203387851862d, 23.77645921703144d),
            Label = "Asylum Service-Central Offices",
            Address = "Leof. Panagioti Kanellopoulou 2, Athina 115 27, Greece"
        };

        Pin pin6 = new Pin()
        {
            Type = PinType.Place,
            Position = new Position(39.60824510944465d, 20.90200331286953d),
            Label = "Katsikas Hospitality Center",
            Address = "2o klm E.O. KATSIKA KOUTSELIO (PALAIOU AERODROMIOU), 45521, Katsikas, Greece"
        };

        Pin pin7 = new Pin()
        {
            Type = PinType.Place,
            Position = new Position(37.98289607670516d, 23.69890542443502d),
            Label = "Eleonas Camp",
            Address = "Agiou Polikarpou 87, Athina 118 55, Greece"
        };

        Pin pin8 = new Pin()
        {
            Type = PinType.Place,
            Position = new Position(40.64645772919333d, 22.919133153343083d),
            Label = "Blue Refugee Center",
            Address = "I. Koletti 25D, Thessaloniki 564 27, Greece"
        };

        public Locations()
        {
            InitializeComponent();

            LocationPicker.Items.Add(pin1.Label);
            LocationPicker.Items.Add(pin2.Label);
            LocationPicker.Items.Add(pin3.Label);
            LocationPicker.Items.Add(pin4.Label);
            LocationPicker.Items.Add(pin5.Label);
            LocationPicker.Items.Add(pin6.Label);
            LocationPicker.Items.Add(pin7.Label);
            LocationPicker.Items.Add(pin8.Label);

            Map.Pins.Add(pin1);
            Map.Pins.Add(pin2);
            Map.Pins.Add(pin3);
            Map.Pins.Add(pin4);
            Map.Pins.Add(pin5);
            Map.Pins.Add(pin6);
            Map.Pins.Add(pin7);
            Map.Pins.Add(pin8);

            Map.MoveToRegion(MapSpan.FromCenterAndRadius(pin1.Position, Distance.FromMeters(5000)));
        }
        private void LocationPicker_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var list = new List<KeyValuePair<string, Position>>();
            list.Add(new KeyValuePair<string, Position>(pin1.Label, pin1.Position));
            list.Add(new KeyValuePair<string, Position>(pin2.Label, pin2.Position));
            list.Add(new KeyValuePair<string, Position>(pin3.Label, pin3.Position));
            list.Add(new KeyValuePair<string, Position>(pin4.Label, pin4.Position));
            list.Add(new KeyValuePair<string, Position>(pin5.Label, pin5.Position));
            list.Add(new KeyValuePair<string, Position>(pin6.Label, pin6.Position));
            list.Add(new KeyValuePair<string, Position>(pin7.Label, pin7.Position));
            list.Add(new KeyValuePair<string, Position>(pin8.Label, pin8.Position));
            var name = LocationPicker.Items[LocationPicker.SelectedIndex];
            foreach (var element in list)
            {
                if (element.Key == name)
                {
                    Map.MoveToRegion(MapSpan.FromCenterAndRadius(element.Value, Distance.FromMeters(1000)));
                }
            }
        }
    }
}