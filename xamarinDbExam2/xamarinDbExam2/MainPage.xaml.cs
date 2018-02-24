using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Microsoft.EntityFrameworkCore;

namespace xamarinDbExam2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            MyDB mdb = new MyDB();
            mdb.Database.EnsureCreated();
            mdb.MyPerson.Add( new Person {Id=1,Name="Emad",Age=22 });
            mdb.SaveChanges();
            var a = mdb.MyPerson.ToList();
		}
	}
}
