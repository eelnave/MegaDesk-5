﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_EvanPeterson
{
    public class DeskQuote
    {
        public Desk Desk { get; set; }
        public static int RushDays { get; set; }
        public string Name { get; set; }
        public DateTime QuoteDate { get; set; }
        public decimal QuoteCost { get; set; }

       public DeskQuote(Desk desk, int rushDays, string name, DateTime quoteDate)
        {
            Desk = desk;
            RushDays = rushDays;
            Name = name;
            QuoteDate = quoteDate;
            QuoteCost = CalculateQuote(Desk);

        }

        public static decimal CalculateQuote(Desk desk)
        {
            decimal quote = 200M;

            quote += AreaCost(desk.Width, desk.Depth);
            quote += DrawerCost(desk.Drawers);
            quote += SurfaceMaterialCost(desk.Material);
            if (RushDays > 0)
            {
                int area = GetArea(desk.Width, desk.Depth);
                quote += RushCost(RushDays, area);
            }
            return quote;

            decimal AreaCost(int width, int depth)
            {
                int area = GetArea(width, depth);
                if (area > 1000)
                {
                    return area - 1000;
                }
                else
                {
                    return 0;
                }
            }

            decimal DrawerCost(int drawers)
            {
                return drawers * 50;
            }

            decimal SurfaceMaterialCost(Desk.SurfaceMaterial material)
            {
                switch (material)
                {
                    case Desk.SurfaceMaterial.Laminate:
                        return 100M;
                    case Desk.SurfaceMaterial.Oak:
                        return 200M;
                    case Desk.SurfaceMaterial.Pine:
                        return 50M;
                    case Desk.SurfaceMaterial.Rosewood:
                        return 300M;
                    case Desk.SurfaceMaterial.Veneer:
                        return 125M;
                    default:
                        MessageBox.Show("Invalid Material!",
                        "Error!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        return 0;
                }
            }

            decimal RushCost(int RushDays, int Area)
            {
                decimal[,] CostArray = new decimal[3, 3];
                using (StreamReader reader = new StreamReader("rushOrderPrices.txt"))
                {
                    int i, j;
                    i = 0;
                    j = 0;
                    while (reader.EndOfStream == false)
                    {
                        CostArray[i, j] = decimal.Parse(reader.ReadLine());
                        j++;
                        if (j == 3)
                        {
                            i++;
                            j = 0;
                        }
                    }
                }

                int x;
                int y;

                if (Area < 1000)
                {
                    x = 0;
                }
                else if (Area > 1000 && Area < 2000)
                {
                    x = 1;
                }
                else
                {
                    x = 2;
                }

                if (RushDays == 3)
                {
                    y = 0;
                }
                else if (RushDays == 5)
                {
                    y = 1;
                }
                else
                {
                    y = 2;
                }

                return CostArray[x , y];
            }

            int GetArea(int width, int depth)
            {
                int area = width * depth;
                return area;
            }

        }

        public string CsvString()
        {
            return $"{RushDays},{Name},{QuoteDate},{QuoteCost},{Desk.DeskId}";
        }
        
    }
}

