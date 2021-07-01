using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;

namespace PA
{
    public partial class Form1 : Form
    {
        bool newinfocomplete = false;
        bool newFinfocomplete = false;
        bool rowchosen = false;
        bool alignchosen = false;
        string daate = "";
        int passengersReserved = 0;

        public Form1()
        {
            InitializeComponent();
            
            Width = 780;
            Height = 470;

            MaximizeBox = false;

            fID_text.ContextMenu = new ContextMenu();
            cap_text.ContextMenu = new ContextMenu();
            row_text.ContextMenu = new ContextMenu();
            fID_text.ShortcutsEnabled = false;
            cap_text.ShortcutsEnabled = false;
            row_text.ShortcutsEnabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int index = 0;                     //for data grid view

            try
            {
                XmlDocument xDoc1 = new XmlDocument();
                xDoc1.Load(Environment.CurrentDirectory.ToString() + "\\TicketFile.xml");

                foreach (XmlNode node in xDoc1.DocumentElement)
                {
                    Tickets tick = new Tickets(node.ChildNodes[0].InnerText, node.ChildNodes[1].InnerText, node.ChildNodes[2].InnerText, node.ChildNodes[3].InnerText, node.ChildNodes[4].InnerText, node.ChildNodes[5].InnerText, Convert.ToInt32(node.ChildNodes[6].InnerText));
                    Tickets.ticketList.Add(tick);
                    passNames_box.Items.Add(tick.FirstName + " " + tick.LastName);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(Environment.CurrentDirectory.ToString() + "\\PA.xml");

                foreach (XmlNode node in xDoc.DocumentElement)
                {
                    Flight fly = new Flight(node.ChildNodes[0].InnerText, Convert.ToInt32(node.ChildNodes[1].InnerText), node.ChildNodes[2].InnerText, node.ChildNodes[3].InnerText, node.ChildNodes[4].InnerText, node.ChildNodes[5].InnerText, Convert.ToInt32(node.ChildNodes[6].InnerText), Convert.ToInt32(node.ChildNodes[7].InnerText), node.ChildNodes[8].InnerText, node.ChildNodes[9].InnerText, node.ChildNodes[10].InnerText, node.ChildNodes[11].InnerText);

                    Flight.flightList.Add(fly);

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[index].Cells[0].Value = fly.DepartureTime + " " + fly.DepartureDate;
                    dataGridView1.Rows[index].Cells[1].Value = fly.From;
                    dataGridView1.Rows[index].Cells[2].Value = fly.To;
                    dataGridView1.Rows[index].Cells[3].Value = fly.FlightID;
                    dataGridView1.Rows[index].Cells[4].Value = fly.Stopovers;
                    dataGridView1.Rows[index].Cells[5].Value = fly.AirplaneName;
                    dataGridView1.Rows[index].Cells[6].Value = fly.Meal;

                    index++;

                    flightName_drop.Items.Add(fly.From + "-" + fly.To);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void check_Click(object sender, EventArgs e)
        {
            daate = departure_pick.Value.Month.ToString() + "." + departure_pick.Value.Day.ToString() + "." + departure_pick.Value.Year.ToString();
            passengersReserved = 0;

            for (int i = 0; i < Flight.flightList.Count; i++)
            {
                if (daate == Flight.flightList[i].DepartureDate && flightName_drop.SelectedItem.ToString() == Flight.flightList[i].FlightName)
                {
                    newinfocomplete = true;
                    break;
                }
            }

            for (int i = 0; i < Tickets.ticketList.Count; i++)
            {
                if (daate == Tickets.ticketList[i].Daate && flightName_drop.SelectedItem.ToString() == Tickets.ticketList[i].FlightNameT)
                {
                    passengersReserved++;
                }
            }

            if (passengersReserved == totSeats)
            {
                newinfocomplete = false;
                MessageBox.Show("All places are occupied!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (newinfocomplete == true)
                {
                    if (fName_text.Text != "" && lName_text.Text != "")
                    {
                        for (int i = 0; i < Tickets.ticketList.Count; i++)
                        {
                            if (align_box.SelectedItem.ToString() == "A" && row_box.SelectedItem.ToString() == "7")    //Default record values
                            {
                                newinfocomplete = false;
                                MessageBox.Show("This place is not available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }

                            if (fName_text.Text == Tickets.ticketList[i].FirstName && lName_text.Text == Tickets.ticketList[i].LastName && flightName_drop.SelectedItem.ToString() == Tickets.ticketList[i].FlightNameT && daate == Tickets.ticketList[i].Daate)
                            {
                                newinfocomplete = false;
                                MessageBox.Show("You have already registered for this flight!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }

                            if (row_box.SelectedItem.ToString() == Tickets.ticketList[i].SeatRow && align_box.SelectedItem.ToString() == Tickets.ticketList[i].SeatAlign && flightName_drop.SelectedItem.ToString() == Tickets.ticketList[i].FlightNameT && daate == Tickets.ticketList[i].Daate)
                            {
                                newinfocomplete = false;
                                MessageBox.Show("This place is already reserved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        }
                    }
                    else
                    {
                        newinfocomplete = false;
                        MessageBox.Show("Fill in all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    newinfocomplete = false;
                    MessageBox.Show("There is no such flight on the chosen date!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (newinfocomplete == true)
            {
                MessageBox.Show("This seat is free to book!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                book_button.Enabled = true;
            }
        }
        private void book_button_Click(object sender, EventArgs e)
        {

            if (fName_text.Text != "" && lName_text.Text != "" && phone_text.Text != "" && mail_text.Text != "")
            {
                Tickets tick = new Tickets(fName_text.Text, lName_text.Text, daate, row_box.SelectedItem.ToString(), align_box.SelectedItem.ToString(), flightName_drop.SelectedItem.ToString(), passengersReserved);
                Tickets.ticketList.Add(tick);
                passNames_box.Items.Add(tick.FirstName + " " + tick.LastName);

                XmlDocument xmlDoc = new XmlDocument();
                FileStream fs = new FileStream(Environment.CurrentDirectory.ToString() + "\\TicketFile.xml", FileMode.Open);
                xmlDoc.Load(fs);

                try
                {
                    XmlElement eTicke = xmlDoc.CreateElement("Tickets");
                    XmlElement eFirstName = xmlDoc.CreateElement("FirstName");
                    XmlElement eLastname = xmlDoc.CreateElement("LastName");
                    XmlElement eDaate = xmlDoc.CreateElement("Daate");
                    XmlElement eSeatRow = xmlDoc.CreateElement("SeatRow");
                    XmlElement eSeatAlign = xmlDoc.CreateElement("SeatAlign");
                    XmlElement eFlightNameT = xmlDoc.CreateElement("FlightNameT");
                    XmlElement eTicketID = xmlDoc.CreateElement("TicketID");

                    XmlText tFirstName = xmlDoc.CreateTextNode(tick.FirstName);
                    XmlText tLastname = xmlDoc.CreateTextNode(tick.LastName);
                    XmlText tDaate = xmlDoc.CreateTextNode(tick.Daate);
                    XmlText tSeatRow = xmlDoc.CreateTextNode(tick.SeatRow);
                    XmlText tSeatAlign = xmlDoc.CreateTextNode(tick.SeatAlign);
                    XmlText tFlightNameT = xmlDoc.CreateTextNode(tick.FlightNameT);
                    XmlText tTicketID = xmlDoc.CreateTextNode(tick.TicketID.ToString());

                    eFirstName.AppendChild(tFirstName);
                    eLastname.AppendChild(tLastname);
                    eDaate.AppendChild(tDaate);
                    eSeatRow.AppendChild(tSeatRow);
                    eFirstName.AppendChild(tFirstName);
                    eSeatAlign.AppendChild(tSeatAlign);
                    eFlightNameT.AppendChild(tFlightNameT);
                    eTicketID.AppendChild(tTicketID);

                    eTicke.AppendChild(eFirstName);
                    eTicke.AppendChild(eLastname);
                    eTicke.AppendChild(eDaate);
                    eTicke.AppendChild(eSeatRow);
                    eTicke.AppendChild(eSeatAlign);
                    eTicke.AppendChild(eFlightNameT);
                    eTicke.AppendChild(eTicketID);

                    fs.Close();

                    xmlDoc.DocumentElement.AppendChild(eTicke);
                }

                catch (Exception ex)
                {
                    newinfocomplete = false;
                    MessageBox.Show(ex.Message, "Error while putting records in a database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (newinfocomplete == true)
                {
                    try
                    {
                        xmlDoc.Save(Environment.CurrentDirectory.ToString() + "\\TicketFile.xml");
                    }
                    catch (Exception ex)
                    {
                        newinfocomplete = false;
                        fs.Close();
                        MessageBox.Show(ex.Message, "Error while saving the database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (newinfocomplete == true)
                    {
                        MessageBox.Show("Booking is saved!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);

        }

        string departureDate = "";
        string arrivalDate = "";
        private void ndep_DateSelected(object sender, DateRangeEventArgs e)
        {
            departureDate = e.Start.Month.ToString() + "." + e.Start.Day.ToString() + "." + e.Start.Year.ToString();
        }

        private void narr_DateSelected(object sender, DateRangeEventArgs e)
        {
            arrivalDate = e.Start.Month.ToString() + "." + e.Start.Day.ToString() + "." + e.Start.Year.ToString();
        }

        private void fID_text_TextChanged(object sender, EventArgs e)
        {
            if (fID_text.Text.StartsWith("0"))
            {
                fID_text.Text = fID_text.Text.Remove(0, 1);
            }
        }

        private void cap_text_TextChanged(object sender, EventArgs e)
        {
            if (cap_text.Text.StartsWith("0"))
            {
                cap_text.Text = cap_text.Text.Remove(0, 1);
            }
        }

        private void row_text_TextChanged(object sender, EventArgs e)
        {
            if (row_text.Text.StartsWith("0"))
            {
                row_text.Text = row_text.Text.Remove(0, 1);
            }
        }

        
        private void addF_Button_Click(object sender, EventArgs e)
        {
            if (fID_text.Text != "" && nfrom.Text != "" && nto.Text != "" && nairname.Text != "" && cap_text.Text != "" && row_text.Text != "" && stop.Text != "" && mealYN.SelectedItem.ToString() != "" && departureDate != "" && arrivalDate != "")
            {
                newFinfocomplete = true;

                string timeForTakeOff = numericUpDown1.Value.ToString() + " : " + numericUpDown2.Value.ToString() + "GMT";

                Flight fly = new Flight((nfrom.Text + "-" + nto.Text), Convert.ToInt32(fID_text.Text), nfrom.Text, nto.Text, stop.Text, nairname.Text, Convert.ToInt32(cap_text.Text), Convert.ToInt32(row_text.Text), mealYN.SelectedItem.ToString(), departureDate, arrivalDate, timeForTakeOff);
                Flight.flightList.Add(fly);

                flightName_drop.Items.Add(fly.From + "-" + fly.To);

                int index = dataGridView1.Rows.Count;
                dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = fly.DepartureTime + " " + fly.DepartureDate;
                dataGridView1.Rows[index].Cells[1].Value = fly.From;
                dataGridView1.Rows[index].Cells[2].Value = fly.To;
                dataGridView1.Rows[index].Cells[3].Value = fly.FlightID;

                XmlDocument xmlDoc = new XmlDocument();
                FileStream fs = new FileStream(Environment.CurrentDirectory.ToString() + "\\PA.xml", FileMode.Open);
                xmlDoc.Load(fs);

                try
                {
                    XmlElement eFlight = xmlDoc.CreateElement("Flight");
                    XmlElement eFlightName = xmlDoc.CreateElement("FlightName");
                    XmlElement eFlightID = xmlDoc.CreateElement("FlightID");
                    XmlElement eFrom = xmlDoc.CreateElement("From");
                    XmlElement eTo = xmlDoc.CreateElement("To");
                    XmlElement eStopovers = xmlDoc.CreateElement("Stopovers");
                    XmlElement eAirplaneName = xmlDoc.CreateElement("AirplaneName");
                    XmlElement eCapacity = xmlDoc.CreateElement("Capacity");
                    XmlElement eNumberOfRows = xmlDoc.CreateElement("NumberOfRows");
                    XmlElement eMeal = xmlDoc.CreateElement("Meal");
                    XmlElement eDepartureDate = xmlDoc.CreateElement("DepartureDate");
                    XmlElement eArrivalDate = xmlDoc.CreateElement("ArrivalDate");
                    XmlElement eDepartureTime = xmlDoc.CreateElement("DepartureTime");

                    XmlText tFlightName = xmlDoc.CreateTextNode(fly.FlightName);
                    XmlText tFlightID = xmlDoc.CreateTextNode(fly.FlightID.ToString());
                    XmlText tFrom = xmlDoc.CreateTextNode(fly.From);
                    XmlText tTo = xmlDoc.CreateTextNode(fly.To);
                    XmlText tStopovers = xmlDoc.CreateTextNode(fly.Stopovers);
                    XmlText tAirplaneName = xmlDoc.CreateTextNode(fly.AirplaneName);
                    XmlText tCapacity = xmlDoc.CreateTextNode(fly.Capacity.ToString());
                    XmlText tNumberOfRows = xmlDoc.CreateTextNode(fly.NumberOfRows.ToString());
                    XmlText tMeal = xmlDoc.CreateTextNode(fly.Meal.ToString());
                    XmlText tDepartureDate = xmlDoc.CreateTextNode(fly.DepartureDate);
                    XmlText tArrivalDate = xmlDoc.CreateTextNode(fly.ArrivalDate);
                    XmlText tDepartureTime = xmlDoc.CreateTextNode(fly.DepartureTime);

                    eFlightName.AppendChild(tFlightName);
                    eFlightID.AppendChild(tFlightID);
                    eFrom.AppendChild(tFrom);
                    eTo.AppendChild(tTo);
                    eStopovers.AppendChild(tStopovers);
                    eAirplaneName.AppendChild(tAirplaneName);
                    eCapacity.AppendChild(tCapacity);
                    eNumberOfRows.AppendChild(tNumberOfRows);
                    eMeal.AppendChild(tMeal);
                    eDepartureDate.AppendChild(tDepartureDate);
                    eArrivalDate.AppendChild(tArrivalDate);
                    eDepartureTime.AppendChild(tDepartureTime);

                    eFlight.AppendChild(eFlightName);
                    eFlight.AppendChild(eFlightID);
                    eFlight.AppendChild(eFrom);
                    eFlight.AppendChild(eTo);
                    eFlight.AppendChild(eStopovers);
                    eFlight.AppendChild(eAirplaneName);
                    eFlight.AppendChild(eCapacity);
                    eFlight.AppendChild(eNumberOfRows);
                    eFlight.AppendChild(eMeal);
                    eFlight.AppendChild(eDepartureDate);
                    eFlight.AppendChild(eArrivalDate);
                    eFlight.AppendChild(eDepartureTime);

                    fs.Close();

                    xmlDoc.DocumentElement.AppendChild(eFlight);
                }

                catch (Exception ex)
                {
                    newFinfocomplete = false;
                    MessageBox.Show(ex.Message, "Fix the informations!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (newFinfocomplete == true)
                {
                    try
                    {
                        xmlDoc.Save(Environment.CurrentDirectory.ToString() + "\\PA.xml");
                    }
                    catch (Exception ex)
                    {
                        newFinfocomplete = false;
                        fs.Close();
                        MessageBox.Show(ex.Message, "Can't save!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (newFinfocomplete == true)
                    {
                        MessageBox.Show("New flight saved!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Fill in all the fields!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        int totSeats = 0;

        private void flightName_drop_SelectedValueChanged(object sender, EventArgs e)
        {
            row_box.Items.Clear();

            int numberRows = 0;

            for (int i = 0; i < Flight.flightList.Count; i++)
            {
                if (flightName_drop.SelectedItem.ToString() == Flight.flightList[i].FlightName)
                {
                    departure_pick.Value = Convert.ToDateTime(Flight.flightList[i].DepartureDate);
                    totSeats = Flight.flightList[i].Capacity;
                    numberRows = Flight.flightList[i].NumberOfRows;
                    break;
                }
            }

            for (byte i = 0; i < numberRows; i++)
            {
                row_box.Items.Add((i + 1).ToString());
            }
        }

        private void row_box_SelectedValueChanged(object sender, EventArgs e)
        {
            if (row_box.SelectedItem != null) { rowchosen = true; }
        }
        private void align_box_SelectedValueChanged(object sender, EventArgs e)
        {
            if (align_box.SelectedItem != null) { alignchosen = true; }
            if (rowchosen == true && alignchosen == true){ check.Enabled = true; available.Text = "Click on check button to see if your seat if available"; }
        }
        private void passNames_box_SelectedValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Tickets.ticketList.Count; i++)
            {
                if ((Tickets.ticketList[i].FirstName + " " + Tickets.ticketList[i].LastName) == passNames_box.SelectedItem.ToString())
                {
                    MessageBox.Show("Ticket ID: " + Tickets.ticketList[i].TicketID + " \nFlight Direction: " + Tickets.ticketList[i].FlightNameT + " \nDeparture Date: " + Tickets.ticketList[i].Daate + " \nDeparture Time: " + Flight.flightList[i].DepartureTime + " \nCustomer Name: " + (Tickets.ticketList[i].FirstName + " " + Tickets.ticketList[i].LastName) + " \nSeat No: " + Tickets.ticketList[i].SeatAlign + Tickets.ticketList[i].SeatRow, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

    }
}