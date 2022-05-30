using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataBinding1
{
    public partial class MainPage : ContentPage
    {
        public Empleado NuevoEmpleado { get; set; }
        public MainPage()
        {
            NuevoEmpleado = new Empleado();
            NuevoEmpleado.NombreCompleto = "Vivian Munguía";
            NuevoEmpleado.Email = "vivian.munguia.mtz@gmail.com";
            BindingContext = NuevoEmpleado;
            InitializeComponent();
        }
    }
}
