using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Imagsa.Chronos;
using System;
using System.Runtime.InteropServices;
using ImagsaSDK.JavaServices;

namespace ImagsaSDK
{
    public partial class Form1 : Form
    {
        public ChronosSDK chronosSDK;
        private List<Event> liveEvents = new List<Event>();
        private List<Event> liveEventsFiltered = new List<Event>();
        public JavaServices.CarEnterClient Client = new CarEnterClient();
       
        private const int MAX_LIVE_EVENTS = 1000;

        // Live viewer
        private System.Timers.Timer timer;
        private int lastId;
        private Object retrievingLastEventLock = new Object();
        private bool retrievingLastEvent = false;
        public Form1()
        {
            InitializeComponent();
            //chronosSDK
            chronosSDK = new ChronosSDK();
            if (connect())
            {
                
            }
        }

        private bool connect()
        {
            try
            {
                chronosSDK.Connect("192.168.1.110", Convert.ToInt32("4359"), false);
            }
            catch (System.Exception ex)
            {
                return false;
            }
            lblStatus.Text = "Connected";

            // Start the timer
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            timer.Start();

            return true;
        }

        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            // Check if currently retrieving last event
            lock (retrievingLastEventLock)
            {
                if (retrievingLastEvent) return;
                retrievingLastEvent = true;
            }

            // Check not initial event
            try
            {
                // Is there any new event?
                int id = chronosSDK.GetLatest();

                if (lastId == 0) lastId = id;

                while (id > lastId)
                {
                    // Check no more than 100
                    if (id > lastId + 100) id = lastId + 100;

                    // Get the event
                    //List<Event> evts = chronosSDK.GetEvents(lastId + 1, id);
                    //evts.Reverse();

                    List<Event> evts = chronosSDK.GetEvents(lastId + 1, id);
                    evts.Reverse();
                    Event test = evts[0];
                    this.Invoke((MethodInvoker)delegate
                    {
                        string PlateResult = "";
                           
                        if (test.OCR_Plate == "UNKNOWN")
                        {
                            //PlateResult = "MM1234";
                            lblLicense.Text = PlateResult;
                            lblTime.Text = DateTime.Now.ToLongTimeString();
                        }
                        else
                        {
                            PlateResult = test.OCR_Plate;
                            lblLicense.Text = PlateResult; 
                        }
                        Client.getVehicleNo(PlateResult);
                       
                    });
                    lastId = id;
                }     
            }
            catch (ChronosException ex)
            {
            }

            lock (retrievingLastEventLock)
            {
                retrievingLastEvent = false;
            }
        }
    }
}
