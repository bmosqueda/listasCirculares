using System;
using System.Windows.Forms;

namespace Bases_con_listas_circulares
{
    public partial class Form1 : Form
    {
        public class Base
        {
            //its the time (in minutes) that take you to arrive of the before base
            private int timeToArrive;
            public int TimeToArrive { get { return timeToArrive; } }
            public Base Next { get; set; }
            private string name;
            public string Name { get { return name; } }

            public Base(string name, int timeToArrive)
            {
                this.name = name;
                this.timeToArrive = timeToArrive;
            }

            public string shortDescription()
            {
                return "\n**** " + name + " ****\nTimeToArrive: " +timeToArrive;
            }

            public override string ToString()
            {
                return "\n***********************\n" +
                    name;
            }
        }

        public class Route
        {
            private int basesNumber;
            public int BasesNumber { get { return basesNumber; } }

            private int startHour;
            public int StartHour { get { return startHour; } }
            private int finalHour;
            private int FinalHour { get { return finalHour; } }

            private int startMinute;
            public int StartMinute { get { return startMinute; } }
            private int finalMinute;
            private int FinalMinute { get { return finalMinute; } }

            private string name;
            public string Name { get { return name; } }

            private Base first;
            private Base last;

            public Route(string name, int startHour, int startMinute, int finalHour, int finalMinute)
            {
                this.name = name;
                this.startHour = startHour;
                this.finalHour = finalHour;
                this.startMinute = startMinute;
                this.finalMinute = finalMinute;
            }

            public void insert(Base newBase, int position)
            {
                if (position < basesNumber && position > 0)
                {
                    if (first != null && position > 1)
                    {
                        Base before = first;
                        Base temp = first;
                        for (int i = 2; i <= position; i++)
                        {
                            before = temp;
                            temp = temp.Next;
                        }
                        newBase.Next = temp;
                        before.Next = newBase;
                        basesNumber++;
                    }
                    else if (first == null)
                    {
                        first = newBase;
                        last = newBase;
                        basesNumber = 1;
                        first.Next = last;
                        last.Next = first;
                    }
                    else
                    {
                        basesNumber++;
                        newBase.Next = first;
                        last.Next = newBase;
                        first = newBase;
                    }
                }
                else
                {
                    addLast(newBase);
                }
            }

            public void addLast(Base newBase)
            {
                if (first != null)
                {
                    last.Next = newBase;
                    newBase.Next = first;
                    last = newBase;
                    basesNumber++;
                }
                else
                {
                    first = newBase;
                    last = newBase;
                    basesNumber = 1;
                    first.Next = last;
                    last.Next = first;
                }
            }

            public string listRoute()
            {
                string listRoute = "No hay ninguna base en la ruta";
                if (first != null)
                {
                    int currentHour = startHour;
                    int currentMinute = startMinute;

                    int diferenceMinutes = (finalHour - startHour) * 60 + finalMinute - startMinute;
                    int minutesSpend = 0;
                    Base temp = first;
                    listRoute = first.ToString() + "\nHora  " + startHour + ":" + StartMinute;

                    while (minutesSpend <= diferenceMinutes)
                    {
                        temp = temp.Next;
                        addMinutes(ref currentHour, ref currentMinute, temp.TimeToArrive);
                        minutesSpend += temp.TimeToArrive;

                        listRoute += temp.ToString() + "\nHora  " + currentHour + ":" + currentMinute;
                    }
                }
                return listRoute;
            }

            public string list()
            {
                if (first != null)
                {
                    string productsString = first.shortDescription();
                    Base temp = first;
                    for (int i = 2; i <= basesNumber; i++)
                    {
                        temp = temp.Next;
                        productsString += temp.shortDescription();
                    }
                    return productsString;
                }
                else
                    return "No se ha agregado ningún producto al inventario";
            }

            private void addMinutes(ref int hour, ref int minutes, int minutesToAdd)
            {
                if (minutesToAdd > 59)
                {
                    hour += minutesToAdd / 60;
                    minutes += minutesToAdd % 60;
                }
                else
                    minutes += minutesToAdd;

                hour += minutes / 60;
                minutes %= 60;
                if (hour > 23)
                {
                    hour /= 24;
                }
            }
            
            public Base search(string name)
            {
                if(first != null)
                {
                    Base temp = first;
                    for(int i = 1; i <= basesNumber; i++)
                    {
                        if (temp.Name == name)
                            return temp;
                        temp = temp.Next;
                    }
                }
                return null;
            }

            public Base deleteLast()
            {
                if(last != null)
                {
                    if (basesNumber > 1)
                    {
                        Base temp = first;
                        for (int i = 2; i < basesNumber; i++)
                            temp = temp.Next;
                        Base temp2 = last;
                        temp.Next = first;
                        last = temp;
                        basesNumber--;
                        return temp2;
                    }
                    else
                    {
                        Base temp = last;
                        first = null;
                        last = null;
                        basesNumber--;
                        return temp;
                    }
                }
                return null;
            }

            public Base deleteFirst()
            {
                if (first != null)
                {
                    if (basesNumber > 1)
                    {
                        Base temp = first;
                        last.Next = first.Next;
                        first = first.Next;
                        basesNumber--;
                        return temp;
                    }
                    else
                    {
                        Base temp = first;
                        first = null;
                        last = null;
                        basesNumber--;
                        return temp;
                    }
                }
                return null;
            }

            public Base deleteByName(string name)
            {
                if (last != null)
                {
                    if (basesNumber > 1)
                    {
                        if(first.Name == name)
                        {
                            return deleteFirst();
                        }
                        else if (last.Name == name)
                        {
                            return deleteLast();
                        }
                        else
                        {
                            Base temp = first;
                            for (int i = 2; i < basesNumber; i++)
                            {
                                if(temp.Next.Name == name)
                                {
                                    Base temp2 = temp.Next;
                                    temp.Next = temp.Next.Next;
                                    basesNumber--;
                                    return temp2;
                                }
                                temp = temp.Next;
                            }
                        }
                    }
                    else
                    {
                        Base temp = last;
                        if(temp.Name == name)
                        {
                            first = null;
                            last = null;
                            basesNumber--;
                            return temp;
                        }
                    }
                }
                return null;
            }

            public string getHour(bool isStart)
            {
                int hours = isStart ? startHour : finalHour;
                int minutes = isStart ? startMinute : finalMinute;

                return hours + ":" + minutes;
            }
        }

        public Route route;
        string[] letters = new string[] { "​A", "B", "C", "D", "E", "F", "G", "H", "I", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        public Random random;
        public Form1()
        {
            route = new Route("Ruta 1", 7, 0, 10, 0);
            random = new Random();
            InitializeComponent();
            addBasesToRoute();
        }

        //Debuggin function
        public void addBasesToRoute()
        {
            for (int i = 0; i < 10; i++)
                route.addLast(new Base(letters[i] + "", i * 5));
            
            //for(int i = 10; i < 25; i++)
              //  route.insert(new Base(letters[i] + "", i * 5), random.Next(15));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            route = new Route(txtRouteName.Text, Convert.ToInt32(numStartHour.Value), Convert.ToInt32(numStartMinute.Value),
                Convert.ToInt32(numFinalHour.Value), Convert.ToInt32(numFinalMinute.Value));
        }

        private void btnAddBase_Click(object sender, EventArgs e)
        {
            route.addLast(new Base(txtBaseName.Text, Convert.ToInt32(numTimeToArrive.Value)));
            numInsert.Maximum = route.BasesNumber;
            btnListBases.PerformClick();
        }

        private void btnListRoute_Click(object sender, EventArgs e)
        {
            txtRoute.Text = route.listRoute();
            lblFinalHour.Text = route.getHour(false);
            lblStartHour.Text = route.getHour(true);
        }

        private void btnListBases_Click(object sender, EventArgs e)
        {
            txtCircularList.Text = route.list();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            route.insert(new Base(txtBaseName.Text, Convert.ToInt32(numTimeToArrive.Value)), Convert.ToInt32(numInsert.Value));
            numInsert.Maximum = route.BasesNumber;
            btnListBases.PerformClick();
        }

        private void btnDeleteByName_Click(object sender, EventArgs e)
        {
           Base deleted = route.deleteByName(txtBaseName.Text);
            if (deleted != null)
                MessageBox.Show(deleted.ToString());
            btnListBases.PerformClick();
        }

        private void btnDeleteFirst_Click(object sender, EventArgs e)
        {
            Base deleted = route.deleteFirst();
            if (deleted != null)
                MessageBox.Show(deleted.ToString());
            btnListBases.PerformClick();
        }

        private void btnDeleteLast_Click(object sender, EventArgs e)
        {
            Base deleted = route.deleteLast();
            if (deleted != null)
                MessageBox.Show(deleted.ToString());
            btnListBases.PerformClick();
        }
    }
}
