using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.NewProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new display and stock instances
            StockDisplay stockDisplay = new StockDisplay();
            StockDisplay stockDisplay1 = new StockDisplay();
            Stock stock = new Stock();

            Stock.AskPriceDelegate aDelegate = new
               Stock.AskPriceDelegate(stockDisplay.AskPriceChanged);
            Stock.AskPriceDelegate bDelegate = new
               Stock.AskPriceDelegate(stockDisplay1.AskPriceChanged);
            
            stock.AskPriceChanged += aDelegate;
            stock.AskPriceChanged += bDelegate;
            
            for (int looper = 0; looper < 10; looper++)
            {
                stock.AskPrice = looper;
            }
            
            stock.AskPriceChanged -= aDelegate;

            for (int looper = 0; looper < 10; looper++)
            {
                stock.AskPrice = looper;
            }

            stock.AskPriceChanged -= bDelegate;

            Console.ReadKey();
        }
    }

    public class Stock
    {

        
        public delegate void AskPriceDelegate(object aPrice);
        
        public event AskPriceDelegate AskPriceChanged;
        
        object _askPrice;
        
        public object AskPrice
        {
            set
            {
                _askPrice = value;
                AskPriceChanged(_askPrice);
            }
        }
    }

    //represents the user interface in the application
    public class StockDisplay
    {

        public void AskPriceChanged(object aPrice)
        {
            Console.Write("The new ask price is:" + aPrice + "\r\n");
        }

    }//StockDispslay class



}
