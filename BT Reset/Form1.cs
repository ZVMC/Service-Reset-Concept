using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Timers;

namespace BT_Reset
{
    public partial class Form1 : Form
    {

        string BTSystem = "Bartender System Service";
        string LabelSystem = "SystemStatus";
        string BTIntegration = "Bartender Integration Service";
        string LabelIntegration = "IntegrationStatus";
        string BTPrint = "Bartender Print Scheduler";
        string LabelPrint = "PrintStatus";
        int OnOffSwitch = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //check status of running services and update text boxes
            RefreshDisplay();
        }

        private void ServiceStatusRefresh(string ServiceName, string LabelName)
        {
            string Running = "Running";
            string Starting = "Starting..";
            string Stopped = "Stopped";
            string Stopping = "Stopping...";
            
            try
            {
                using( ServiceController BTSystem = new ServiceController(ServiceName) )
                {
                    switch (BTSystem.Status)
                    {
                        case ServiceControllerStatus.Running:
                            this.Controls["Label_" + LabelName].Text = Running;
                            return;

                        case ServiceControllerStatus.Stopped:
                            this.Controls["Label_" + LabelName].Text = Stopped;
                            return;

                        case ServiceControllerStatus.StartPending:
                            this.Controls["Label_" + LabelName].Text = Starting;
                            return;

                        case ServiceControllerStatus.StopPending:
                            this.Controls["Label_" + LabelName].Text = Stopping;
                            return;
                    }
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Debug ArgumentException box");
                return;
            }
            catch (Win32Exception)
            {
                MessageBox.Show("Debug Win32Exception box");
                return;
            }
        }

        private void ChangeService(string ServiceName)
        {
            using (ServiceController BTService = new ServiceController(ServiceName))
            {
                switch (OnOffSwitch)
                {
                    //off
                    case 0:
                        BTService.Stop();
                        return;
                    //on
                    case 1:
                        BTService.Start();
                        return;
                }
                
            }
        }

        private void Button_Stop_Click(object sender, EventArgs e)
        {
            //stop services 3 times
            OnOffSwitch = 0;
            ChangeService(BTSystem);
            ChangeService(BTPrint);
            ChangeService(BTIntegration);
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            OnOffSwitch = 1;
            ChangeService(BTSystem);
            ChangeService(BTPrint);
            ChangeService(BTIntegration);
        }

        private void Button_Restart_Click(object sender, EventArgs e)
        {
            OnOffSwitch = 0;
            ChangeService(BTSystem);
            ChangeService(BTPrint);
            ChangeService(BTIntegration);
            RefreshDisplay();
            //wait 10 seconds
            System.Timers.Timer StartTimer = new System.Timers.Timer();
            StartTimer.Interval = 10000;
            StartTimer.Elapsed += StartTimer_Elapsed;
            StartTimer.Start();
            //System.Threading.Thread.Sleep(10000);
            
            
        }

        private void StartTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            OnOffSwitch = 1;
            Task task = new Task(ChangeService(BTSystem));
            ChangeService(BTSystem);
            ChangeService(BTPrint);
            ChangeService(BTIntegration);
            RefreshDisplay();
        }

        private void RefreshDisplay()
        {
            ServiceStatusRefresh(BTSystem, LabelSystem);
            ServiceStatusRefresh(BTIntegration, LabelIntegration);
            ServiceStatusRefresh(BTPrint, LabelPrint);
        }

        private void DEBUG_Refresh_Click(object sender, EventArgs e)
        {
            RefreshDisplay();
        }
    }
}
