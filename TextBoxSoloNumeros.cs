using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlesPersonalizadosMySoft
{
    public class TextBoxSoloNumeros : TextBox
    {
        public TextBoxSoloNumeros()
        {
            // Configura la alineación del texto a la derecha al instanciar el control
            this.TextAlign = HorizontalAlignment.Right;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            // Permitir solo números, teclas de control y el punto decimal
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Cancelar entrada
            }

            // Evitar más de un punto decimal
            if (e.KeyChar == '.' && this.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
