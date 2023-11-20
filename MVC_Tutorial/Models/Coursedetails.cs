using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Tutorial.Models
{
    public class Coursedetails
    {
        public Coursedata studentdetails(int id) {
            Coursedata cd = new Coursedata();
            switch (id)
            {

                case 1:
                    {

                        cd = new Coursedata()
                        {
                            Title = "Tutorial1",
                            Name = "C-Sharp",
                            Rollnumber = 20,
                            Mark = 200
                        };
                        break;
                    }
                case 2:
                    {

                        cd = new Coursedata()
                        {
                            Title = "Tutorial2",
                            Name = "C-Sharp",
                            Rollnumber = 20,
                            Mark = 200
                        };
                        break;
                    }
                case 3:
                    {

                        cd = new Coursedata()
                        {
                            Title = "Tutorial3",
                            Name = "C-Sharp",
                            Rollnumber = 20,
                            Mark = 200
                        };
                        break;
                    }
                case 4:
                    {

                        cd = new Coursedata()
                        {
                            Title = "Tutorial4",
                            Name = "C-Sharp",
                            Rollnumber = 20,
                            Mark = 200
                        };
                        break;
                    }
            }
            return cd;
       }
    }
}