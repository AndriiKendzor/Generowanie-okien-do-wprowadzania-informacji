using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace G9_63656_C11
{
    public partial class Ak_63656_WorkPanel : Form
    {
        public static Ak_63656_WorkPanel ak_63656_workPanel;
        Ak_63656_Controlls ak_63656_crl = new Ak_63656_Controlls();
        //Deklaracja pól prywatnych
        private GroupBox ak_63656_Gb001;
        private GroupBox ak_63656_Gb002;
        private GroupBox ak_63656_Gb003;

        private CheckBox ak_63656_checkLabel;
        private CheckBox ak_63656_checkTextBox;

        private TextBox ak_63656_txtTopMarg;
        private TextBox ak_63656_txtLeftMarg;
        private TextBox ak_63656_txtWidth;
        private TextBox ak_63656_txtHeight;
        private TextBox ak_63656_txtColShift;
        private TextBox ak_63656_txtRowShift;
        private ColorDialog ak_63656_colorDialogBackColor = new ColorDialog();
        private ColorDialog ak_63656_colorDialogForeColor = new ColorDialog();



        public Ak_63656_WorkPanel()
        {
            InitializeComponent();
            ak_63656_workPanel = this;
            LoadControlls();
        }
        private void LoadControlls()
        {
            //Tworzenie GoupBox
            ak_63656_Gb001 = ak_63656_crl.Ak_63656_Create_GoupBox(15, 10, 825, 450, "Work Panel", "GbWorkPanel");
            ak_63656_workPanel.Controls.Add(ak_63656_Gb001);
            ak_63656_Gb002 = ak_63656_crl.Ak_63656_Create_GoupBox(850, 10, 120, 450, "Arrangement", "GbArrangement");
            ak_63656_workPanel.Controls.Add(ak_63656_Gb002);
            ak_63656_Gb003 = ak_63656_crl.Ak_63656_Create_GoupBox(15, 465, 955, 80, "Parameters", "GbParameters");
            ak_63656_workPanel.Controls.Add(ak_63656_Gb003);

            Font ak_63656_font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            Color ak_63656_foreColor = Color.DarkBlue;
            Color ak_63656_backColor = Color.FromKnownColor(KnownColor.Control);
            string ak_63656_text = "";

            // ! btAutoGenerate:
            //wywolanie metody pseudo konstruktora
            Button ak_63656_btAutoGenerate = ak_63656_crl.Ak_63656_Create_Button("BtAutoGenerate", 12, 25, 95, 50, ak_63656_font, ak_63656_foreColor, ak_63656_backColor, ak_63656_text = "AUTO");
            //dodanie metod obslugi zdarzen
            ak_63656_btAutoGenerate.Click += new EventHandler(Ak_63656_BtAutoGenerate_Click);
            ak_63656_btAutoGenerate.MouseHover += new EventHandler(Ak_63656_BtMouseHover);
            ak_63656_btAutoGenerate.MouseLeave += new EventHandler(Ak_63656_BtMouseLeave);
            //dodanie przycisku do kontenera
            ak_63656_Gb002.Controls.Add(ak_63656_btAutoGenerate);

            // ! btManual:
            //wywolanie metody pseudo konstruktora
            Button ak_63656_btManual = ak_63656_crl.Ak_63656_Create_Button("btManual", 12, 90, 95, 50, ak_63656_font, ak_63656_foreColor, ak_63656_backColor, ak_63656_text = "MANUAL");
            //dodanie metod obslugi zdarzen
            ak_63656_btManual.Click += new EventHandler(Ak_63656_BtManual_Click);
            ak_63656_btManual.MouseHover += new EventHandler(Ak_63656_BtMouseHover);
            ak_63656_btManual.MouseLeave += new EventHandler(Ak_63656_BtMouseLeave);
            //dodanie przycisku do kontenera
            ak_63656_Gb002.Controls.Add(ak_63656_btManual);

            // ! btClear:
            //wywolanie metody pseudo konstruktora
            Button ak_63656_btClear = ak_63656_crl.Ak_63656_Create_Button("btClear", 12, 300, 95, 50, ak_63656_font, ak_63656_foreColor, ak_63656_backColor, ak_63656_text = "CLEAR");
            //dodanie metod obslugi zdarzen
            ak_63656_btClear.Click += new EventHandler(Ak_63656_BtClear_Click);
            ak_63656_btClear.MouseHover += new EventHandler(Ak_63656_BtMouseHover);
            ak_63656_btClear.MouseLeave += new EventHandler(Ak_63656_BtMouseLeave);
            //dodanie przycisku do kontenera
            ak_63656_Gb002.Controls.Add(ak_63656_btClear);

            // ! btExit:
            //wywolanie metody pseudo konstruktora
            Button ak_63656_btExit = ak_63656_crl.Ak_63656_Create_Button("btExit", 12, 365, 95, 50, ak_63656_font, ak_63656_foreColor, ak_63656_backColor, ak_63656_text = "EXIT");
            //dodanie metod obslugi zdarzen
            ak_63656_btExit.Click += new EventHandler(Ak_63656_BtExit_Click);
            ak_63656_btExit.MouseHover += new EventHandler(Ak_63656_BtMouseHover);
            ak_63656_btExit.MouseLeave += new EventHandler(Ak_63656_BtMouseLeave);
            //dodanie przycisku do kontenera
            ak_63656_Gb002.Controls.Add(ak_63656_btExit);

        }

        //metody MouseHover i MouseLeave:
        private void Ak_63656_BtMouseHover(object ak_63656_sender, EventArgs ak_63656_e)
        {
            Button ak_63656_button = ak_63656_sender as Button;
            if (ak_63656_button != null)
            {
                ak_63656_button.BackColor = Color.Orange;
            }
        }
        private void Ak_63656_BtMouseLeave(object ak_63656_sender, EventArgs ak_63656_e)
        {
            Button ak_63656_button = ak_63656_sender as Button;
            if (ak_63656_button != null)
            {
                ak_63656_button.BackColor = Color.FromKnownColor(KnownColor.Control);
            }
        }

        //metody Click:
        private void Ak_63656_BtAutoGenerate_Click(object ak_63656_sender, EventArgs ak_63656_e)
        {
            Ak_63656_ClearGroupBoxes(0);
            // deklaracja zmiennych lokalnych
            int ak_63656_topMargin = 20;
            int ak_63656_leftMargin = 15;
            int ak_63656_labelWidth = 40;
            int ak_63656_labelHeight = 25;
            int ak_63656_ColShift = 40;
            int ak_63656_RowShift = 0;
            Color ak_63656_textboxColor = Color.Bisque;
            Color ak_63656_foreColor = Color.Red;
            int ak_63656_decision = 3;//labels and TextBoxes
            Ak_63656_Draw(ak_63656_topMargin, ak_63656_leftMargin, ak_63656_labelWidth, ak_63656_labelHeight, ak_63656_ColShift, ak_63656_RowShift, ak_63656_textboxColor, ak_63656_foreColor, ak_63656_decision);
        }

        private void Ak_63656_BtManual_Click(object ak_63656_sender, EventArgs ak_63656_e)
        {
            Ak_63656_ClearGroupBoxes(1);
            //Wywołanie metody tworzącej nowe kontrolki
            Ak_63656_LoadNewControlls();
        }
        private void Ak_63656_BtClear_Click(object ak_63656_sender, EventArgs ak_63656_e)
        {
            Ak_63656_ClearWorkPanel();
        }
        private void Ak_63656_BtExit_Click(object ak_63656_sender, EventArgs ak_63656_e)
        {
            Application.Exit();
        }

        private void Ak_63656_BtBackColor_Click(object ak_63656_sender, EventArgs ak_63656_e)
        {
            Button ak_63656_btBackColor = ak_63656_sender as Button;
            //Wywoływanie ColorDialog
            ak_63656_colorDialogBackColor = new ColorDialog();
            DialogResult ak_63656_result = ak_63656_colorDialogBackColor.ShowDialog();
            if (ak_63656_result == DialogResult.OK)
            {
                Color ak_63656_selectedColor = ak_63656_colorDialogBackColor.Color;
                ak_63656_btBackColor.BackColor = ak_63656_selectedColor;
            }
        }
        private void Ak_63656_BtForeColor_Click(object ak_63656_sender, EventArgs ak_63656_e)
        {
            Button ak_63656_btForeColor = ak_63656_sender as Button;
            //Wywoływanie ColorDialog
            ak_63656_colorDialogForeColor = new ColorDialog();
            DialogResult ak_63656_result = ak_63656_colorDialogForeColor.ShowDialog();
            if (ak_63656_result == DialogResult.OK)
            {
                Color ak_63656_selectedColor = ak_63656_colorDialogForeColor.Color;
                ak_63656_btForeColor.BackColor = ak_63656_selectedColor;

            }
        }

        private void Ak_63656_BtGenerate_Click(object ak_63656_sender, EventArgs ak_63656_e)
        {
            Ak_63656_ClearWorkPanel();
            int ak_63656_labelWidth;
            //Sprawdzanie typu int wprowadzanego tekstu
            if (!int.TryParse(ak_63656_txtWidth.Text, out ak_63656_labelWidth))
            {
                MessageBox.Show("Nieprawidłowa wartość dla Width. Wprowadź liczbę całkowitą.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ak_63656_labelHeight;
            //Sprawdzanie typu int wprowadzanego tekstu
            if (!int.TryParse(ak_63656_txtHeight.Text, out ak_63656_labelHeight))
            {
                MessageBox.Show("Nieprawidłowa wartość dla Height. Wprowadź liczbę całkowitą.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ak_63656_topMargin;
            //Sprawdzanie typu int wprowadzanego tekstu
            if (!int.TryParse(ak_63656_txtTopMarg.Text, out ak_63656_topMargin))
            {
                MessageBox.Show("Nieprawidłowa wartość dla Top Margin. Wprowadź liczbę całkowitą.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ak_63656_leftMargin;
            //Sprawdzanie typu int wprowadzanego tekstu
            if (!int.TryParse(ak_63656_txtLeftMarg.Text, out ak_63656_leftMargin))
            {
                MessageBox.Show("Nieprawidłowa wartość dla Left Margin. Wprowadź liczbę całkowitą.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ak_63656_ColShift;
            //Sprawdzanie typu int wprowadzanego tekstu
            if (!int.TryParse(ak_63656_txtColShift.Text, out ak_63656_ColShift))
            {
                MessageBox.Show("Nieprawidłowa wartość dla Column Shift. Wprowadź liczbę całkowitą.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ak_63656_RowShift;
            //Sprawdzanie typu int wprowadzanego tekstu
            if (!int.TryParse(ak_63656_txtRowShift.Text, out ak_63656_RowShift))
            {
                MessageBox.Show("Nieprawidłowa wartość dla Rows Shift. Wprowadź liczbę całkowitą.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Color ak_63656_textboxColor = ak_63656_colorDialogBackColor.Color;
            Color ak_63656_foreColor = ak_63656_colorDialogForeColor.Color;

            //Zmienna do sprawdzania decyzji użytkownika
            int ak_63656_decision = 0;

            if (ak_63656_checkLabel.Checked)
            {
                ak_63656_decision = 1;//labels
            }
            if (ak_63656_checkTextBox.Checked)
            {
                ak_63656_decision = 2;//TextBoxes
            }
            if (ak_63656_checkLabel.Checked&& ak_63656_checkTextBox.Checked)
            {
                ak_63656_decision = 3;//labels and TextBoxes
            }
            Ak_63656_Draw(ak_63656_topMargin, ak_63656_leftMargin, ak_63656_labelWidth, ak_63656_labelHeight, ak_63656_ColShift, ak_63656_RowShift, ak_63656_textboxColor, ak_63656_foreColor, ak_63656_decision);
        }


        //inne metody:
        private void Ak_63656_LoadNewControlls()
        {
            Font ak_63656_font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            Color ak_63656_foreColor = Color.DarkBlue;
            Color ak_63656_backColor = Color.FromKnownColor(KnownColor.Control);
            string ak_63656_text = "";

            // ! create button
            Button ak_63656_btGenerate = ak_63656_crl.Ak_63656_Create_Button("btGenerate", 845, 20, 95, 50, ak_63656_font, ak_63656_foreColor, ak_63656_backColor, ak_63656_text = "GENERATE");
            //dodanie metod obslugi zdarzen
            ak_63656_btGenerate.Click += new EventHandler(Ak_63656_BtGenerate_Click);
            ak_63656_btGenerate.MouseHover += new EventHandler(Ak_63656_BtMouseHover);
            ak_63656_btGenerate.MouseLeave += new EventHandler(Ak_63656_BtMouseLeave);
            //dodanie przycisku do kontenera
            ak_63656_Gb003.Controls.Add(ak_63656_btGenerate);

            // ! create CheckBoxes checkLabel and checkTextBox:
            ak_63656_checkLabel = ak_63656_crl.Ak_63656_Create_CheckBox("checkLabel", new Point(20, 20), 90, ak_63656_font, ak_63656_foreColor, true, ak_63656_text = "Label");
            ak_63656_Gb003.Controls.Add(ak_63656_checkLabel);

            ak_63656_checkTextBox = ak_63656_crl.Ak_63656_Create_CheckBox("checkTextBox", new Point(20, 40), 90, ak_63656_font, ak_63656_foreColor, true, ak_63656_text = "TextBox");
            ak_63656_Gb003.Controls.Add(ak_63656_checkTextBox);

            // ! create Width/Height (label and TextBox):
            Label ak_63656_labWidth = ak_63656_crl.Ak_63656_Create_Label("labWidth", new Point(120, 25), ak_63656_font, ak_63656_backColor, ak_63656_foreColor, 50, 20, ak_63656_text = "Width:");
            ak_63656_Gb003.Controls.Add(ak_63656_labWidth);

            Label ak_63656_labHeight = ak_63656_crl.Ak_63656_Create_Label("labHeight", new Point(120, 45), ak_63656_font, ak_63656_backColor, ak_63656_foreColor, 50, 20, ak_63656_text = "Height:");
            ak_63656_Gb003.Controls.Add(ak_63656_labHeight);

            ak_63656_txtWidth = ak_63656_crl.Ak_63656_Create_TextBox("txtWidth", new Point(170, 25), 70, 50, ak_63656_font, ak_63656_backColor, ak_63656_foreColor);
            ak_63656_Gb003.Controls.Add(ak_63656_txtWidth);

            ak_63656_txtHeight = ak_63656_crl.Ak_63656_Create_TextBox("txtHeight", new Point(170, 45), 70, 50, ak_63656_font, ak_63656_backColor, ak_63656_foreColor);
            ak_63656_Gb003.Controls.Add(ak_63656_txtHeight);

            // ! create Colors (label and button):
            Label ak_63656_labBackColor = ak_63656_crl.Ak_63656_Create_Label("labBackColor", new Point(250, 25), ak_63656_font, ak_63656_backColor, ak_63656_foreColor, 80, 20, ak_63656_text = "Back Color:");
            ak_63656_Gb003.Controls.Add(ak_63656_labBackColor);

            Label ak_63656_labForeColor = ak_63656_crl.Ak_63656_Create_Label("labForeColor", new Point(250, 45), ak_63656_font, ak_63656_backColor, ak_63656_foreColor, 80, 20, ak_63656_text = "Fore Color:");
            ak_63656_Gb003.Controls.Add(ak_63656_labForeColor);

            Button ak_63656_btBackColor = ak_63656_crl.Ak_63656_Create_Button("btBackColor", 330, 20, 60, 25, ak_63656_font, ak_63656_foreColor, ak_63656_backColor, ak_63656_text = "");
            ak_63656_btBackColor.Click += new EventHandler(Ak_63656_BtBackColor_Click);
            ak_63656_Gb003.Controls.Add(ak_63656_btBackColor);

            Button ak_63656_btForeColor = ak_63656_crl.Ak_63656_Create_Button("btForeColor", 330, 45, 60, 25, ak_63656_font, ak_63656_foreColor, ak_63656_backColor, ak_63656_text = "");
            ak_63656_btForeColor.Click += new EventHandler(Ak_63656_BtForeColor_Click);
            ak_63656_Gb003.Controls.Add(ak_63656_btForeColor);

            // ! create Margin (label and TextBox):
            Label ak_63656_labTopMarg = ak_63656_crl.Ak_63656_Create_Label("labTopMarg", new Point(400, 25), ak_63656_font, ak_63656_backColor, ak_63656_foreColor, 80, 20, ak_63656_text = "Top Margin:");
            ak_63656_Gb003.Controls.Add(ak_63656_labTopMarg);

            Label ak_63656_labLeftMarg = ak_63656_crl.Ak_63656_Create_Label("labLeftMarg", new Point(400, 45), ak_63656_font, ak_63656_backColor, ak_63656_foreColor, 80, 20, ak_63656_text = "Left Margin:");
            ak_63656_Gb003.Controls.Add(ak_63656_labLeftMarg);

            ak_63656_txtTopMarg = ak_63656_crl.Ak_63656_Create_TextBox("txtTopMarg", new Point(480, 25), 70, 50, ak_63656_font, ak_63656_backColor, ak_63656_foreColor);
            ak_63656_Gb003.Controls.Add(ak_63656_txtTopMarg);

            ak_63656_txtLeftMarg = ak_63656_crl.Ak_63656_Create_TextBox("txtLeftMarg", new Point(480, 45), 70, 50, ak_63656_font, ak_63656_backColor, ak_63656_foreColor);
            ak_63656_Gb003.Controls.Add(ak_63656_txtLeftMarg);

            // ! create Shift (label and TextBox):
            Label ak_63656_labColShift = ak_63656_crl.Ak_63656_Create_Label("labColShift", new Point(560, 25), ak_63656_font, ak_63656_backColor, ak_63656_foreColor, 90, 20, ak_63656_text = "Columns Shift:");
            ak_63656_Gb003.Controls.Add(ak_63656_labColShift);

            Label ak_63656_labRowShift = ak_63656_crl.Ak_63656_Create_Label("labRowShift", new Point(560, 45), ak_63656_font, ak_63656_backColor, ak_63656_foreColor, 90, 20, ak_63656_text = "Rows Shift:");
            ak_63656_Gb003.Controls.Add(ak_63656_labRowShift);

            ak_63656_txtColShift = ak_63656_crl.Ak_63656_Create_TextBox("txtColShift", new Point(650, 25), 70, 50, ak_63656_font, ak_63656_backColor, ak_63656_foreColor);
            ak_63656_Gb003.Controls.Add(ak_63656_txtColShift);

            ak_63656_txtRowShift = ak_63656_crl.Ak_63656_Create_TextBox("txtRowShift", new Point(650, 45), 70, 50, ak_63656_font, ak_63656_backColor, ak_63656_foreColor);
            ak_63656_Gb003.Controls.Add(ak_63656_txtRowShift);
        }
        private void Ak_63656_Draw(int ak_63656_topMargin, int ak_63656_leftMargin, int ak_63656_Width, int ak_63656_Height, int ak_63656_ColShift, int ak_63656_RowShift, Color ak_63656_textboxColor, Color ak_63656_foreColor, int ak_63656_decition)
        {
            // deklaracja zmiennych lokalnych
            int ak_63656_nbOfControlls = 110;
            string ak_63656_controlName = "";
            Point ak_63656_controllPoint = new Point(ak_63656_leftMargin, ak_63656_topMargin);
            Font ak_63656_labelFont = new Font("Tahoma", 12, FontStyle.Bold);
            Font ak_63656_textboxFont = new Font("Tahoma", 8, FontStyle.Bold);
            Color ak_63656_labelColor = Color.FromKnownColor(KnownColor.Control);

            // iteracyjne rozmieszczenie obiektów typu Label i TextBox
            for (int ak_63656_i = 1; ak_63656_i <= ak_63656_nbOfControlls; ak_63656_i++)
            {
                // sprawdzania decyzji użytkownika
                if (ak_63656_decition == 1 || ak_63656_decition == 3)
                {
                    // dodanie obiektu typu Label
                    ak_63656_controlName = "Lb" + ak_63656_i.ToString();
                    Label ak_63656_newLabel = ak_63656_crl.Ak_63656_Create_Label(ak_63656_controlName, ak_63656_controllPoint, ak_63656_labelFont, ak_63656_labelColor, ak_63656_foreColor, ak_63656_Width, ak_63656_Height, ak_63656_i.ToString());
                    ak_63656_Gb001.Controls.Add(ak_63656_newLabel);
                    ak_63656_controllPoint.X = ak_63656_controllPoint.X + ak_63656_ColShift;
                    ak_63656_controllPoint.Y = ak_63656_controllPoint.Y + ak_63656_RowShift;
                }
                if (ak_63656_decition == 2 || ak_63656_decition == 3)
                {
                    // dodanie obiektu typu textBox
                    ak_63656_controlName = "Tb" + ak_63656_i.ToString();
                    TextBox ak_63656_newTextBox = ak_63656_crl.Ak_63656_Create_TextBox(ak_63656_controlName, ak_63656_controllPoint, ak_63656_Width, ak_63656_Height, ak_63656_textboxFont, ak_63656_textboxColor, ak_63656_foreColor);
                    ak_63656_Gb001.Controls.Add(ak_63656_newTextBox);
                    ak_63656_controllPoint.X = ak_63656_leftMargin;
                }


                if (ak_63656_controllPoint.Y + 35 > ak_63656_Gb001.Height)
                {
                    ak_63656_leftMargin = ak_63656_leftMargin + 130;
                    ak_63656_controllPoint.X = ak_63656_leftMargin;
                    ak_63656_controllPoint.Y = ak_63656_topMargin;
                }
                else
                    ak_63656_controllPoint.Y = ak_63656_controllPoint.Y + 25;
                if (ak_63656_controllPoint.X + 125 > ak_63656_Gb001.Width)
                    ak_63656_i = ak_63656_nbOfControlls;
            }
            //Sygnalizacja udanego wykonania
            MessageBox.Show("Realizacja zakończona sukcesem", "Powiadomienie", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Ak_63656_ClearWorkPanel()
        {
            // odnalezienie kontenera GroupBox o nazwie GbWorkPanel
            // w kontenerze WorkPanel
            GroupBox ak_63656_gb = (GroupBox)this.Controls.Find("GbWorkPanel", true)[0];
            // sprawdzenie, czy kontener zawiera jakieś kontrolki
            if (ak_63656_gb.Controls.Count > 0)
                ak_63656_gb.Controls.Clear();
        }
        private GroupBox Ak_63656_ClearGroupBoxes(int ak_63656_function)
        {
            // odnalezienie kontenera GroupBox o nazwie „GbWorkPanel”
            // w kontenerze WorkPanel
            GroupBox ak_63656_gb1 = (GroupBox)this.Controls.Find("GbWorkPanel", true)[0];
            // sprawdzenie, czy kontener zawiera jakieś kontrolki
            if (ak_63656_gb1.Controls.Count > 0)
                ak_63656_gb1.Controls.Clear();
            // odnalezienie kontenera GroupBox o nazwie „GbParameters” w kontenerze WorkPanel
            GroupBox ak_63656_gb2 = (GroupBox)this.Controls.Find("GbParameters", true)[0];
            // sprawdzenie, czy kontener zawiera jakieś kontrolki
            if (ak_63656_gb2.Controls.Count > 0)
                ak_63656_gb2.Controls.Clear();
            switch (ak_63656_function)
            {
                case 0:
                    return null;
                    break;
                case 1:
                    return ak_63656_gb1;
                    break;
                case 2:
                    return ak_63656_gb2;
                    break;
                default:
                    return null;
                    break;
            }
        }


    }
}
