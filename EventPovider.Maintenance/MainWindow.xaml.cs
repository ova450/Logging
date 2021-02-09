using Microsoft.EntityFrameworkCore;
using ova.common.logging.EventProvider.Data;
using ova.common.logging.EventProvider.Model;
using ova.common.Onion.Core.Domain.Model;
using System;
using System.Collections.ObjectModel;
using System.Windows;


namespace ova.common.logging.EventProvider.Maintenance
{
    public class EventViewModel<T> where T: class, IEntityBase
    {
        public EventViewModel(DbContext dbcontext) {db = dbcontext;}
        private readonly DbContext db;
        public ObservableCollection<T>  GetEvents() 
        {
            db.Set<T>().Load();
            return db.Set<T>().Local.ToObservableCollection();
        }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            using Context db = new Context();
            db.SaveChanges();

            componentsGrid.ItemsSource = new EventViewModel<Component>(db).GetEvents();

            Console.WriteLine($"консоль");

            //string[] eventheads = { "Id", "Name" };
        }
    }
}
