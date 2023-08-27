using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding01
{
		public class Alumno : INotifyPropertyChanged
		{
			
			public event PropertyChangedEventHandler PropertyChanged;

			string nombre = string.Empty;
			public string Nombre
		{
			get => nombre;
			set
			{
				if (nombre == value)
					return;
				nombre = value;
				OnPropertyChanged(nameof(Nombre));
				OnPropertyChanged(nameof(MostrarNombre));
			}
		}
			public string MostrarNombre => $"Nombre Ingresado:{Nombre}";

			void OnPropertyChanged(string nombre)
			{
			
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
			}
		}
	
}
