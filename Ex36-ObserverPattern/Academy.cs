using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ex36_ObserverPattern
{
    public delegate void NotifyHandler();

    public class Academy : Organization, IAcademy
    {
        private NotifyHandler students;
        private string _message;
        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
                Notify();
            }
        }

        public Academy(string name, string adress) : base(name)
        {

        }

        public void Attach(IStudent s)
        {
            students += s.Update;   
        }

        public void Detach(Student s)
        {
            students -= s.Update;
        }

        public void Notify()
        {
            students();   
        }
    }
}
