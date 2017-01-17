using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBTA_v1
{
    public partial class Main : Form
    {
        #region Members
        private const string url = "http://realtime.mbta.com/developer/api/v2/";
        private const string key = "wX9NwuHnZU2ToO7GmGR9uw";
        private const string format = "json";

        private const string homeLat = "42.3418959";
        private const string homeLon = "-71.1468869";

        private MBTA mbta = new MBTA(url, key);
        private DataTable routes = new DataTable();
        private Dictionary<string, DataTable> stations = new Dictionary<string, DataTable>();
        private DataTable etas = new DataTable();
        #endregion

        #region Constructors
        public Main()
        {
            routes.Columns.Add("id");
            routes.Columns.Add("name");

            etas.Columns.Add("id");
            etas.Columns.Add("destination");
            etas.Columns.Add("eta");

            InitializeComponent();

            gvETAs.AutoGenerateColumns = false;

            gvETAs.Columns.Add("destination", "Destination");
            gvETAs.Columns["destination"].DataPropertyName = "destination";
            gvETAs.Columns["destination"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            gvETAs.Columns.Add("eta", "ETA");
            gvETAs.Columns["eta"].DataPropertyName = "eta";
            gvETAs.Columns["eta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
        }
        #endregion  

        #region Events
        private void Main_Load(object sender, EventArgs e)
        {
            PopulateRoutes();

            GetAllStations();
            PopulateStations();

            UpdatePredictions();
            PopulateETAs();
        }

        private void cboRoutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateStations();
        }

        private void cboStations_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePredictions();
        }
        #endregion

        #region Private Functions
        private void PopulateRoutes()
        {
            Routes r = mbta.GetRoutes();
            foreach (Mode m in r.modes)
                if (m.name == "Subway")
                    foreach (Route ro in m.routes)
                        routes.Rows.Add(ro.ID, ro.name);

            cboRoutes.DataSource = routes;
            cboRoutes.DisplayMember = "name";
            cboRoutes.ValueMember = "id";
        }

        private void PopulateStations()
        {
            string r = cboRoutes.SelectedValue.ToString();

            if (stations.ContainsKey(r))
            {
                cboStations.DataSource = stations[r];
                cboStations.DisplayMember = "name";
                cboStations.ValueMember = "id";
            }
        }

        private void PopulateETAs()
        {
            gvETAs.DataSource = etas;
        }

        private void GetAllStations()
        {
            foreach (DataRow r in routes.Rows)
                stations[r["id"].ToString()] = mbta.GetStationsByRoute(r["id"].ToString());
        }

        private void UpdatePredictions()
        {
            etas.Rows.Clear();
            if (cboStations.SelectedValue != null && cboStations.SelectedValue.GetType() == typeof(string))
            {
                Predictions p = mbta.GetPredictionsByStop(cboStations.SelectedValue.ToString());
                foreach (Mode m in p.modes)
                    foreach (Route r in m.routes)
                        foreach (Direction d in r.directions)
                            foreach (Trip t in d.trips)
                            {
                                int minutesOut = int.Parse(t.ETA) / 60;
                                int secondsOut = int.Parse(t.ETA) % 60;

                                etas.Rows.Add(t.ID, t.headsign, minutesOut.ToString("D2") + ":" + secondsOut.ToString("D2"));
                            }
            }
        }
        #endregion
    }
}
