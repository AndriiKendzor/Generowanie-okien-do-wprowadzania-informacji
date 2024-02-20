using System.Drawing;
using System.Windows.Forms;

namespace G9_63656_C11
{
    internal class Ak_63656_Controlls
    {
        public Button Ak_63656_Create_Button(string ak_63656_name, int ak_63656_x, int ak_63656_y, int ak_63656_width, int ak_63656_height, Font ak_63656_czcionka, Color ak_63656_foreColor, Color ak_63656_backColor, string ak_63656_text)
        {
            Button ak_63656_button = new Button //utworzenie nowego obiektu typu Button
            {
                Name = ak_63656_name, //ustawienie unikatowej nazwy kontrolki
                Location = new Point(ak_63656_x, ak_63656_y), //ustawienie położenia punktu zaczepienia
                Width = ak_63656_width, //szerokość przycisku
                Height = ak_63656_height, //wysokość przycisku
                AutoSize = false, //wyłączenie odwołania do wartości domyślnych
                Font = ak_63656_czcionka, //ustawienie parametrów czcionki
                ForeColor = ak_63656_foreColor, //ustawienie koloru czcionki
                BackColor = ak_63656_backColor, //ustawienie koloru tła
                Text = ak_63656_text, //ustawienie treści napisu na przycisku
                TextAlign = ContentAlignment.MiddleCenter //oraz jego położenia
            };
            return ak_63656_button;
        }

        public CheckBox Ak_63656_Create_CheckBox(string ak_63656_name, Point ak_63656_location, int ak_63656_width, Font ak_63656_czcionka, Color ak_63656_foreColor, bool ak_63656_selected, string ak_63656_text)
        {
            CheckBox ak_63656_checkBox = new CheckBox //utworzenie nowego obiektu typu CheckBox
            {
                Location = ak_63656_location,
                Width = ak_63656_width,
                Font = ak_63656_czcionka,
                ForeColor = ak_63656_foreColor,
                Checked = ak_63656_selected, //ustawienie stanu początkowego
                Name = ak_63656_name, //ustawienie nazwy kontrolki
                Text = ak_63656_text
            };
            return ak_63656_checkBox;
        }

        public GroupBox Ak_63656_Create_GoupBox(int ak_63656_x, int ak_63656_y, int ak_63656_width, int ak_63656_height, string ak_63656_text, string ak_63656_name)
        {
            GroupBox ak_63656_groubBox = new GroupBox //utworzenie nowego obiektu typu GroupBox
            {

                Location = new Point(ak_63656_x, ak_63656_y),
                Width = ak_63656_width,
                Height = ak_63656_height,
                Text = ak_63656_text,
                Name = ak_63656_name
            };
            return ak_63656_groubBox;
        }

        public Label Ak_63656_Create_Label(string ak_63656_name, Point ak_63656_location, Font ak_63656_czcionka, Color ak_63656_backColor, Color ak_63656_foreColor, int ak_63656_width, int ak_63656_height, string ak_63656_text)
        {
            Label ak_63656_label = new Label //utworzenie nowego obiektu typu Label
            {
                Location = ak_63656_location,
                AutoSize = false, //wyłączenie domyślnego rozmiaru
                Width = ak_63656_width,
                Height = ak_63656_height,
                Font = ak_63656_czcionka,
                BackColor = ak_63656_backColor,
                ForeColor = ak_63656_foreColor,
                Name = ak_63656_name,
                Text = ak_63656_text
            };
            return ak_63656_label;
        }

        public TextBox Ak_63656_Create_TextBox(string ak_63656_name, Point ak_63656_location, int ak_63656_width, int ak_63656_height, Font ak_63656_czcionka, Color ak_63656_backColor, Color ak_63656_foreColor)
        {
            TextBox ak_63656_textBox = new TextBox //utworzenie nowego obiektu typu Label
            {
                Location = ak_63656_location,
                Width = ak_63656_width,
                Height = ak_63656_height,
                Name = ak_63656_name,
                Font = ak_63656_czcionka,
                BackColor = ak_63656_backColor,
                ForeColor = ak_63656_foreColor,
                BorderStyle = BorderStyle.FixedSingle, //ustawienie typu obramowania
            };
            return ak_63656_textBox;
        }

    }
}
