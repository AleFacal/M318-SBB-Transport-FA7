namespace SwissTransportGUI
{
    using SwissTransport.Core;
    using SwissTransport.Models;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class HauptForm : Form
    {
        private readonly ITransport itTransport;
        public HauptForm()
        {
            InitializeComponent();
            this.itTransport = new Transport();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AnzeigeEndeStationen.Visible = false;
            AnzeigeStStationen.Visible = false;
            
        }

        public void StartVerbindung_TextChanged(object sender, EventArgs e)
        {
            string startText = StartVerbindung.Text;
            if (!String.IsNullOrEmpty(startText))
            {
                Autocomplete(StartVerbindung, AnzeigeStStationen);
            }
        }

        public void EndVerbindung_TextChanged(object sender, EventArgs e)
        {
            string endText = EndVerbindung.Text;
            if (!String.IsNullOrEmpty(endText))
            {
                Autocomplete(EndVerbindung, AnzeigeEndeStationen);
            }
        }

        private void Autocomplete(TextBox tBox, DataGridView grid)
        {
            Stations alleStationen = this.itTransport.GetStations(tBox.Text);
            BindingList<Station> stations = new BindingList<Station>();
            foreach (Station station in alleStationen.StationList)
            {
                stations.Add(station);
            }
            grid.Visible = true;
            grid.DataSource = stations;
            foreach (DataGridViewColumn col in grid.Columns)
            {
                if (col.HeaderText == "Id" || col.HeaderText == "Coordinate" || col.HeaderText == "Distance" || col.HeaderText == "Score")
                {
                    col.Visible = false;
                }
            }
        }

        public void VerbindungenSuchen_Click(object sender, EventArgs e)
        {
            Connections allConnections = this.itTransport.GetConnections(StartVerbindung.Text, EndVerbindung.Text, dateTimeVerbindungen.Value.ToString().Split(" ")[0]);
            BindingList<VerbindungenKlasse> connections = new BindingList<VerbindungenKlasse>();
            foreach (Connection connection in allConnections.ConnectionList)
            {
                connections.Add(new VerbindungenKlasse(connection.From.Departure.ToString(), connection.To.Arrival.ToString(), connection.To.Platform, connection.Duration));
            }
            ResultVerbindungen.DataSource = connections;
        }

        //Stationssuche
        private void StSuche_Click(object sender, EventArgs e)
        {
            string allStationNames = StName.Text;
            Stations alleStationen = this.itTransport.GetStations(allStationNames);
            BindingList<Station> stationNames = new BindingList<Station>();
            foreach (Station station in alleStationen.StationList)
            {
                stationNames.Add(station);
            }
            StAnzeige.DataSource = stationNames;
            foreach (DataGridViewColumn col in StAnzeige.Columns)
            {
                if (col.HeaderText == "Distance" || col.HeaderText == "Score" || col.HeaderText == "Coordinate")
                {
                    col.Visible = false;
                }
            }
        }
        //Abfahrten
        private void AbfahrtenSuche_Click(object sender, EventArgs e)
        {
            string abfahrtsStation = AbfahrtStation.Text;
            Stations alleStationen = this.itTransport.GetStations(abfahrtsStation);
            StationBoardRoot stationBoards = this.itTransport.GetStationBoard(abfahrtsStation, alleStationen.StationList[0].Id);
            BindingList<AbfahrtenKlasse> stationen = new BindingList<AbfahrtenKlasse>();

            foreach (StationBoard stationBoard in stationBoards.Entries)
            {
                stationen.Add(new AbfahrtenKlasse(stationBoard.Category, stationBoard.Operator, stationBoard.To, stationBoard.Stop.Departure));
            }
            AbfahrtsFahrten.DataSource = stationen;
        }

        private void StationenTausch(object sender, EventArgs e)
        {
            string startText = StartVerbindung.Text;
            StartVerbindung.Text = EndVerbindung.Text;
            EndVerbindung.Text = startText;
        }

        private void AnzeigeEndeStationen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = AnzeigeEndeStationen.Rows[e.RowIndex];
                EndVerbindung.Text = row.Cells["Name"].Value.ToString();
                AnzeigeEndeStationen.Visible = false;
            }
        }

        private void AnzeigeStStationen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = AnzeigeStStationen.Rows[e.RowIndex];
                StartVerbindung.Text = row.Cells["Name"].Value.ToString();
                AnzeigeStStationen.Visible = false;
            }
        }
    }
}