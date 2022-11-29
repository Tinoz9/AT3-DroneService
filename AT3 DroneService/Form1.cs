using System.Text.RegularExpressions;

namespace AT3_DroneService
{
    public partial class Form1 : Form
    {
        Queue<Drone> RegularService = new Queue<Drone>(); //6.2
        Queue<Drone> ExpressService = new Queue<Drone>(); //6.3
        List<Drone> FinishedList = new List<Drone>(); //6.4
        public Form1()
        {
            InitializeComponent();
        }

        private void AddNewItem() //6.5 add new item and scales cost according to service level.
        {
            ServiceTag();
            string Priority = GetServicePriority();
            if (!String.IsNullOrEmpty(Priority) && !String.IsNullOrEmpty(nameBox.Text) && !String.IsNullOrEmpty(dronBox.Text) && !String.IsNullOrEmpty(probBox.Text) && !String.IsNullOrEmpty(costBox.Text))
            {
                if (Priority == "Regular")
                {
                    RegularService.Enqueue(new Drone(nameBox.Text, dronBox.Text, probBox.Text, double.Parse(costBox.Text), Decimal.ToInt32(tagUp.Value)));
                }
                else
                {
                    double ecost = Convert.ToDouble(costBox.Text) * 1.15; //6.6
                    ExpressService.Enqueue(new Drone(nameBox.Text, dronBox.Text, probBox.Text, ecost, Decimal.ToInt32(tagUp.Value)));
                }
            } else
            {
                MessageBox.Show("A text box is empty");
            }
            clears();
            rDisplay();
        }

        private void rDisplay() //6.8, 6.9 displays all of the items in the queue in the appropriate listviewbox.
        {
            listViewR.Items.Clear();
            foreach(Drone r in RegularService)
            {
                ListViewItem listview1 = new ListViewItem(r.CName);
                listview1.SubItems.Add(r.DModel);
                listview1.SubItems.Add(r.SProblem);
                listview1.SubItems.Add(r.SCost.ToString());
                listview1.SubItems.Add(r.STag.ToString());
                listViewR.Items.Add(listview1);
            }

            listViewE.Items.Clear();
            foreach (Drone e in ExpressService)
            {
                
                ListViewItem listview2 = new ListViewItem(e.CName);
                listview2.SubItems.Add(e.DModel);
                listview2.SubItems.Add(e.SProblem);
                listview2.SubItems.Add(e.SCost.ToString());
                listview2.SubItems.Add(e.STag.ToString());
                listViewE.Items.Add(listview2);
            }

        }

        private void ServiceTag() //6.11 increments the service tag control
        {
            tagUp.Value = tagUp.Value + tagUp.Increment;
            
        }

        private String GetServicePriority() //6.7 makes sure that the radiobutton has been checked and returns the text value
        {
            String priority = null;
            foreach (RadioButton r in groupBox.Controls)
            {
                if (r.Checked)
                {
                    priority = r.Text;
                }
            }
            return priority;
        }
        private void finDisplay() 
        {
            finBox.Items.Clear();
            foreach (Drone dr in FinishedList)
            {
                finBox.Items.Add(dr.CName + " " + dr.SCost);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddNewItem();
        }

        private void regBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (regBtn.Checked == true)
            {
                expBtn.Checked = false;
            }
        }

        private void rFinBtn_Click(object sender, EventArgs e)
        {
            rfin();
        }

        private void eFinBtn_Click(object sender, EventArgs e)
        {
            efin();
        }

        private void rfin() //6.14 checks to make sure regular service count is not 0 then will add the next item in the queue to the finished list and then displays.
        {
            if (RegularService.Count > 0)
            {
                FinishedList.Add(RegularService.Peek());
                RegularService.Dequeue();
                rDisplay();

                finDisplay();
            }
        }

        private void efin() //6.15 checks to make sure regular service count is not 0 then will add the next item in the queue to the finished list and then displays.
        {
            if (ExpressService.Count > 0)
            {
                FinishedList.Add(ExpressService.Peek());
                ExpressService.Dequeue();
                rDisplay();

                finDisplay();
            }
        }


        private void costBox_KeyPress(object sender, KeyPressEventArgs e) //6.10 makes sure that their can only be one decimal point entered as well as makes sure that it can only enter 1 decimal place.
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (Regex.IsMatch(costBox.Text, @"\.\d") && e.KeyChar != 8) 
            { 
                e.Handled = true; 
            }
        }

        private void listViewR_SelectedIndexChanged(object sender, EventArgs e)
        {
            rselect();
        }
        private void rselect() //6.12 mouse click method that will display client name and service problem in the related text boxes.
        {
            if (listViewR.SelectedItems.Count != 0)
            {
                int nselect = listViewR.SelectedIndices[0];
                nameBox.Text = RegularService.ElementAt(nselect).CName;
                probBox.Text = RegularService.ElementAt(nselect).SProblem;
            }
        }

        private void listViewE_SelectedIndexChanged(object sender, EventArgs e)
        {
            eselect();
        }

        private void eselect() //6.13 mouse click method that will display client name and service problem in the related text boxes.
        {
            if (listViewE.SelectedItems.Count != 0)
            {
                int nselect = listViewE.SelectedIndices[0];
                nameBox.Text = ExpressService.ElementAt(nselect).CName;
                probBox.Text = ExpressService.ElementAt(nselect).SProblem;
            }
        }

        private void finBox_MouseDoubleClick(object sender, MouseEventArgs e) //6.16 on double click event will remove item at index
        {
            if (finBox.SelectedItems.Count > 0)
            {
                FinishedList.RemoveAt(finBox.SelectedIndex);
            }
            finDisplay();
        }
        private void clears() //6.17 clears textboxes by setting them null;
        {
            nameBox.Text = null;
            probBox.Text = null;
            dronBox.Text = null;
            costBox.Text = null;
        }
    }
}