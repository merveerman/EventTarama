using EventTarama.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventTarama
{
    public partial class MainForm : Form
    {
        List<Producer> producerList = new List<Producer>();

        string eventDesc = "";
        string priorityDesc = "";

        int rownum = 0;
        Stopwatch watch = new Stopwatch();
        string second = "";
        string minute = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSetAndScan_Click(object sender, EventArgs e)
        {
            tmrProgress.Enabled = true;
        }

        private void tmrProgress_Tick(object sender, EventArgs e)
        {
            try
            {
                watch.Start();

                prgBar.Minimum = 0;
                prgBar.Maximum = 400;
                prgBar.Step = 1;
                tmrProgress.Interval = 1000;//1 saniye

                if (prgBar.Value == prgBar.Maximum)
                {
                    tmrProgress.Enabled = false;
                    watch.Stop();

                    TimeSpan timeSpan = TimeSpan.FromMilliseconds(watch.Elapsed.TotalMilliseconds);

                    if (timeSpan != null)
                    {
                        second = string.Format("{0:D2} Saniye", timeSpan.Seconds);
                        minute = string.Format("{0:D2} Dakika", timeSpan.Minutes);
                    }

                    lblCounter.Text = (minute == "" ? "" : minute) + " " + (second == "" ? "" : second);
                    return;
                }

                if (producerList.Count > 0 && producerList.Count % 3 == 0 && producerList.Count == 3)
                {
                    producerList = new List<Producer>();
                    eventDesc = "";
                }

                EventProducer();

                if (prgBar.Value > 0 && (((prgBar.Value + 1) % 3 == 0 && producerList.Count == 3) || prgBar.Value == prgBar.Maximum - 1))
                {
                    rownum++;

                    lstAlerts.Items.Add(EventConsumer(producerList));
                }

                prgBar.Value += 1;
            }
            catch (Exception ex)
            {

            }
        }

        //Kaydetme
        private void EventProducer()
        {
            try
            {
                Random randomPriority = new Random();
                int sayi = randomPriority.Next(1, 4);

                Producer producer = new Producer();
                producer.ProducerId = prgBar.Value;
                producer.ProducerPriority = sayi;

                producerList.Add(producer);
            }
            catch (Exception ex)
            {

            }
        }

        //Tarama
        private string EventConsumer(List<Producer> producerList)
        {
            string result = "";

            try
            {
                foreach (var producerItem in producerList)
                {
                    if (producerItem.ProducerPriority != null)
                    {
                        if (producerItem.ProducerPriority == (int)PriorityTypes.Low)
                        {
                            priorityDesc = PriorityTypes.Low.ToString() + ",";
                        }
                        else if (producerItem.ProducerPriority == (int)PriorityTypes.Medium)
                        {
                            priorityDesc = PriorityTypes.Medium.ToString() + ",";
                        }
                        else if (producerItem.ProducerPriority == (int)PriorityTypes.High)
                        {
                            priorityDesc = PriorityTypes.High.ToString() + ",";
                        }
                    }


                    eventDesc += priorityDesc;
                }
                result = rownum + ". " + eventDesc;
            }
            catch (Exception ex)
            {

            }
            return result;
        }

    }
}
